using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace BookingKontrolPasien.Helpers
{
    public class DAL
    {
        public DataTable LoadChartBookingStatus()
        {
            return ExecuteStoredProcedure("sp_ChartBookingStatus");
        }

        public DataTable LoadReportBooking(
            DateTime tanggalMulai,
            DateTime tanggalSelesai,
            string status) 
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@tanggal_mulai", tanggalMulai.Date),
                new SqlParameter("@tanggal_selesai", tanggalSelesai.Date),
                new SqlParameter("@status", (status ?? string.Empty).Trim())
            };

            return ExecuteStoredProcedure("sp_ReportBooking", parameters);
        }

        public int ImportDokter(DataTable importTable)
        {
            int saved = 0;

            using (SqlConnection conn = DBHelper.GetConnection())
            {
                conn.Open();

                foreach (DataRow row in importTable.Rows)
                {
                    if (row["status_validasi"].ToString() != "OK")
                        continue;

                    using (SqlCommand cmd =
                        new SqlCommand("sp_ImportDokter", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue(
                            "@nama",
                            row["nama_dokter"].ToString());

                        cmd.Parameters.AddWithValue(
                            "@spesialisasi",
                            row["spesialisasi"].ToString());

                        cmd.Parameters.AddWithValue(
                            "@hp",
                            row["no_hp"].ToString());

                        cmd.Parameters.AddWithValue(
                            "@source_file",
                            "import_excel_admin");

                        int result = Convert.ToInt32(cmd.ExecuteScalar());

                        if (result == 1)
                            saved++;
                    }
                }
            }

            return saved;
        }

        public int ImportJadwal(DataTable importTable)
        {
            int saved = 0;
            HashSet<string> importedKeys = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            using (SqlConnection conn = DBHelper.GetConnection())
            {
                conn.Open();

                DataTable dokterTable = new DataTable();

                using (SqlCommand cmd = new SqlCommand("sp_LoadDokterCombo", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dokterTable);
                    }
                }

                foreach (DataRow row in importTable.Rows)
                {
                    if (row["status_validasi"].ToString() != "OK")
                        continue;

                    int? dokterId = FindDokterId(
                        dokterTable,
                        row["nama_dokter"].ToString());

                    if (!dokterId.HasValue)
                        continue;

                    string hari = row["hari"].ToString();
                    TimeSpan mulai = TimeSpan.Parse(row["jam_mulai"].ToString());
                    TimeSpan selesai = TimeSpan.Parse(row["jam_selesai"].ToString());
                    string importKey = CreateJadwalKey(dokterId.Value, hari, mulai, selesai);

                    if (!importedKeys.Add(importKey))
                        continue;

                    if (JadwalExists(conn, dokterId.Value, hari, mulai, selesai))
                        continue;

                    using (SqlCommand cmd = new SqlCommand("sp_InsertJadwal", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@did", dokterId.Value);
                        cmd.Parameters.AddWithValue("@hari", hari);
                        cmd.Parameters.AddWithValue("@mulai", mulai);
                        cmd.Parameters.AddWithValue("@selesai", selesai);
                        cmd.Parameters.AddWithValue("@kuota", Convert.ToInt32(row["kuota"]));
                        cmd.ExecuteNonQuery();
                        saved++;
                    }
                }
            }

            return saved;
        }

        private bool JadwalExists(
            SqlConnection conn,
            int dokterId,
            string hari,
            TimeSpan mulai,
            TimeSpan selesai)
        {
            using (SqlCommand cmd = new SqlCommand(@"
                SELECT COUNT(1)
                FROM jadwal_dokter
                WHERE dokter_id = @did
                  AND hari = @hari
                  AND CAST(jam_mulai AS time) = @mulai
                  AND CAST(jam_selesai AS time) = @selesai", conn))
            {
                cmd.Parameters.AddWithValue("@did", dokterId);
                cmd.Parameters.AddWithValue("@hari", hari);
                cmd.Parameters.AddWithValue("@mulai", mulai);
                cmd.Parameters.AddWithValue("@selesai", selesai);

                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        private string CreateJadwalKey(
            int dokterId,
            string hari,
            TimeSpan mulai,
            TimeSpan selesai)
        {
            return dokterId + "|" +
                   hari.Trim().ToLowerInvariant() + "|" +
                   mulai.ToString(@"hh\:mm") + "|" +
                   selesai.ToString(@"hh\:mm");
        }

        private int? FindDokterId(DataTable dokterTable, string namaDokter)
        {
            foreach (DataRow dokter in dokterTable.Rows)
            {
                string nama = dokter["nama_dokter"].ToString();

                if (!string.Equals(nama, namaDokter, StringComparison.OrdinalIgnoreCase))
                    continue;

                return Convert.ToInt32(dokter["id"]);
            }

            return null;
        }

        private DataTable ExecuteStoredProcedure(
            string procedureName,
            SqlParameter[] parameters = null)
        {
            DataTable table = new DataTable();

            using (SqlConnection conn = DBHelper.GetConnection())
            {
                conn.Open();

                using (SqlCommand cmd =
                    new SqlCommand(procedureName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    using (SqlDataAdapter adapter =
                        new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(table);
                    }
                }
            }

            return table;
        }
    }
}

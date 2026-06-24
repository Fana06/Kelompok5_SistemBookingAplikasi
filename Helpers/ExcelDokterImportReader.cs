using ExcelDataReader;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace BookingKontrolPasien.Helpers
{
    /// <summary>
    /// Membaca file Excel (.xlsx) atau CSV (.csv) hasil "Template" import dokter,
    /// lalu memvalidasi tiap baris. Hasilnya berupa DataTable dengan kolom:
    /// nama_dokter, spesialisasi, no_hp, status_validasi ("OK" / "ERROR"), keterangan.
    /// </summary>
    public static class ExcelDokterImportReader
    {
        private static readonly Regex PhoneRegex = new Regex(@"^[0-9]{9,15}$");

        public static DataTable Read(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException("File tidak ditemukan.", filePath);

            string extension = Path.GetExtension(filePath).ToLowerInvariant();

            DataTable raw = extension == ".csv"
                ? ReadCsv(filePath)
                : ReadExcel(filePath);

            return Validate(raw);
        }

        private static DataTable ReadExcel(string filePath)
        {
            using (FileStream stream = File.Open(
                filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
            using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
            {
                DataSet dataSet = reader.AsDataSet(new ExcelDataSetConfiguration
                {
                    ConfigureDataTable = _ => new ExcelDataTableConfiguration
                    {
                        UseHeaderRow = true
                    }
                });

                if (dataSet.Tables.Count == 0 || dataSet.Tables[0].Rows.Count == 0)
                    throw new Exception(
                        "File Excel tidak berisi data. Gunakan tombol Template terlebih dahulu.");

                return dataSet.Tables[0];
            }
        }

        private static DataTable ReadCsv(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);

            if (lines.Length == 0)
                throw new Exception("File CSV kosong.");

            DataTable table = new DataTable();
            string[] headers = SplitCsvLine(lines[0]);

            foreach (string header in headers)
                table.Columns.Add(header.Trim());

            for (int i = 1; i < lines.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lines[i]))
                    continue;

                string[] values = SplitCsvLine(lines[i]);
                DataRow row = table.NewRow();

                for (int c = 0; c < table.Columns.Count && c < values.Length; c++)
                    row[c] = values[c];

                table.Rows.Add(row);
            }

            return table;
        }

        private static string[] SplitCsvLine(string line)
        {
            return line
                .Split(',')
                .Select(v => v.Trim().Trim('"'))
                .ToArray();
        }

        private static DataTable Validate(DataTable raw)
        {
            DataTable result = new DataTable();
            result.Columns.Add("nama_dokter", typeof(string));
            result.Columns.Add("spesialisasi", typeof(string));
            result.Columns.Add("no_hp", typeof(string));
            result.Columns.Add("status_validasi", typeof(string));
            result.Columns.Add("keterangan", typeof(string));

            string colNama = FindColumn(raw, "nama_dokter", "nama");
            string colSpesialisasi = FindColumn(raw, "spesialisasi");
            string colNoHp = FindColumn(raw, "no_hp", "no hp", "telepon", "hp", "nomor_hp");

            foreach (DataRow row in raw.Rows)
            {
                string nama = GetValue(row, colNama);
                string spesialisasi = GetValue(row, colSpesialisasi);
                string noHp = GetValue(row, colNoHp);

                bool baseRowEmpty =
                    string.IsNullOrWhiteSpace(nama) &&
                    string.IsNullOrWhiteSpace(spesialisasi) &&
                    string.IsNullOrWhiteSpace(noHp);

                if (baseRowEmpty)
                    continue;

                string status = "OK";
                string keterangan = "Valid";

                if (string.IsNullOrWhiteSpace(nama))
                {
                    status = "ERROR";
                    keterangan = "Nama dokter wajib diisi";
                }
                else if (string.IsNullOrWhiteSpace(spesialisasi))
                {
                    status = "ERROR";
                    keterangan = "Spesialisasi wajib diisi";
                }
                else if (string.IsNullOrWhiteSpace(noHp) ||
                         !PhoneRegex.IsMatch(noHp))
                {
                    status = "ERROR";
                    keterangan = "No HP tidak valid (hanya angka, 9-15 digit)";
                }

                DataRow newRow = result.NewRow();
                newRow["nama_dokter"] = nama;
                newRow["spesialisasi"] = spesialisasi;
                newRow["no_hp"] = noHp;
                newRow["status_validasi"] = status;
                newRow["keterangan"] = keterangan;
                result.Rows.Add(newRow);
            }

            if (result.Rows.Count == 0)
                throw new Exception(
                    "Tidak ada baris data yang terbaca dari file.");

            return result;
        }

        private static string FindColumn(DataTable table, params string[] candidates)
        {
            foreach (DataColumn col in table.Columns)
            {
                string colName = col.ColumnName.Trim();

                foreach (string candidate in candidates)
                {
                    if (string.Equals(
                        colName, candidate, StringComparison.OrdinalIgnoreCase))
                    {
                        return col.ColumnName;
                    }
                }
            }

            return null;
        }

        private static string GetValue(DataRow row, string columnName)
        {
            if (columnName == null || !row.Table.Columns.Contains(columnName))
                return string.Empty;

            return Convert.ToString(row[columnName]).Trim();
        }
    }
}
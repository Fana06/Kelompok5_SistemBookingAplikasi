using ExcelDataReader;
using System;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;

namespace BookingKontrolPasien.Helpers
{
    public static class ExcelJadwalImportReader
    {
        private static readonly string[] ValidDays =
        {
            "Senin", "Selasa", "Rabu", "Kamis", "Jumat", "Sabtu", "Minggu"
        };

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
            result.Columns.Add("hari", typeof(string));
            result.Columns.Add("jam_mulai", typeof(string));
            result.Columns.Add("jam_selesai", typeof(string));
            result.Columns.Add("kuota", typeof(int));
            result.Columns.Add("status_validasi", typeof(string));
            result.Columns.Add("keterangan", typeof(string));

            string colNama = FindColumn(raw, "nama_dokter", "nama dokter", "dokter", "nama");
            string colHari = FindColumn(raw, "hari");
            string colMulai = FindColumn(raw, "jam_mulai", "jam mulai", "mulai");
            string colSelesai = FindColumn(raw, "jam_selesai", "jam selesai", "selesai");
            string colKuota = FindColumn(raw, "kuota");

            foreach (DataRow row in raw.Rows)
            {
                string nama = GetValue(row, colNama);
                string hari = NormalizeDay(GetValue(row, colHari));
                string mulaiText = GetValue(row, colMulai);
                string selesaiText = GetValue(row, colSelesai);
                string kuotaText = GetValue(row, colKuota);

                bool rowEmpty =
                    string.IsNullOrWhiteSpace(nama) &&
                    string.IsNullOrWhiteSpace(hari) &&
                    string.IsNullOrWhiteSpace(mulaiText) &&
                    string.IsNullOrWhiteSpace(selesaiText) &&
                    string.IsNullOrWhiteSpace(kuotaText);

                if (rowEmpty)
                    continue;

                string status = "OK";
                string keterangan = "Valid";
                TimeSpan mulai;
                TimeSpan selesai;
                int kuota;

                if (string.IsNullOrWhiteSpace(nama))
                {
                    status = "ERROR";
                    keterangan = "Nama dokter wajib diisi";
                }
                else if (!ValidDays.Contains(hari))
                {
                    status = "ERROR";
                    keterangan = "Hari harus Senin sampai Minggu";
                }
                else if (!TryParseTime(mulaiText, out mulai))
                {
                    status = "ERROR";
                    keterangan = "Jam mulai tidak valid, contoh 08:00";
                }
                else if (!TryParseTime(selesaiText, out selesai))
                {
                    status = "ERROR";
                    keterangan = "Jam selesai tidak valid, contoh 10:00";
                }
                else if (mulai >= selesai)
                {
                    status = "ERROR";
                    keterangan = "Jam selesai harus lebih besar dari jam mulai";
                }
                else if (!int.TryParse(kuotaText, out kuota) || kuota <= 0)
                {
                    status = "ERROR";
                    keterangan = "Kuota harus angka lebih dari 0";
                }

                DataRow newRow = result.NewRow();
                newRow["nama_dokter"] = nama;
                newRow["hari"] = hari;
                newRow["jam_mulai"] = TryParseTime(mulaiText, out mulai) ? mulai.ToString(@"hh\:mm") : mulaiText;
                newRow["jam_selesai"] = TryParseTime(selesaiText, out selesai) ? selesai.ToString(@"hh\:mm") : selesaiText;
                newRow["kuota"] = int.TryParse(kuotaText, out kuota) ? kuota : 0;
                newRow["status_validasi"] = status;
                newRow["keterangan"] = keterangan;
                result.Rows.Add(newRow);
            }

            if (result.Rows.Count == 0)
                throw new Exception("Tidak ada baris data yang terbaca dari file.");

            return result;
        }

        private static bool TryParseTime(string value, out TimeSpan time)
        {
            string[] formats = { @"h\:mm", @"hh\:mm", @"h\:mm\:ss", @"hh\:mm\:ss" };

            return TimeSpan.TryParseExact(
                value,
                formats,
                CultureInfo.InvariantCulture,
                out time);
        }

        private static string NormalizeDay(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return string.Empty;

            value = value.Trim().ToLowerInvariant();

            foreach (string day in ValidDays)
            {
                if (day.ToLowerInvariant() == value)
                    return day;
            }

            return value;
        }

        private static string FindColumn(DataTable table, params string[] candidates)
        {
            foreach (DataColumn col in table.Columns)
            {
                string colName = col.ColumnName.Trim();

                foreach (string candidate in candidates)
                {
                    if (string.Equals(colName, candidate, StringComparison.OrdinalIgnoreCase))
                        return col.ColumnName;
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
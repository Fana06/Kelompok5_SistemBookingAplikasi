using BookingKontrolPasien.Helpers;
using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace BookingKontrolPasien.Forms
{
    public partial class Report : Form
    {
        private ReportDocument _reportDocument;

        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            LoadLaporanDokter();
        }

        private void LoadLaporanDokter()
        {
            try
            {
                string reportPath =
                Path.Combine(
                Application.StartupPath,
                "LaporanDokter.rpt");

                if (!File.Exists(reportPath))
                {
                    MessageBox.Show(
                        "File report tidak ditemukan.\n\n" +
                        reportPath);

                    return;
                }

                // Ambil data dokter dari database
                DataTable dt = DBHelper.ExecuteQuery(@"
                    SELECT
                        CAST(id AS varchar(10)) AS id,
                        nama_dokter,
                        spesialisasi,
                        no_hp,
                        CASE
                            WHEN status_aktif = 1 THEN 'Aktif'
                            ELSE 'Nonaktif'
                        END AS status_aktif
                    FROM dokter
                    ORDER BY id
                ");

                // Isi dataset yang dipakai Crystal Report
                DSDokter ds = new DSDokter();

                foreach (DataRow row in dt.Rows)
                {
                    ds.Tables["Dokter"].ImportRow(row);
                }

                _reportDocument = new ReportDocument();

                _reportDocument.Load(reportPath);

                _reportDocument.SetDataSource(ds);

                crystalReportViewer1.ReportSource = _reportDocument;

                crystalReportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Crystal Report",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void Report_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_reportDocument != null)
            {
                _reportDocument.Close();
                _reportDocument.Dispose();
                _reportDocument = null;
            }
        }
    }
}
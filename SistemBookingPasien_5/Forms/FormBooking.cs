using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using SistemBookingPasien_5.Helpers;

namespace SistemBookingPasien_5.Forms
{
    public partial class FormBooking : Form
    {
        public FormBooking()
        {
            InitializeComponent();
            LoadDokter();
            dtpTanggal.MinDate = DateTime.Today;
        }

        private void LoadDokter()
        {
            DataTable dt = DBHelper.ExecuteQuery(
                "SELECT id, nama_dokter + ' - ' + ISNULL(spesialisasi,'Umum') AS info FROM dokter WHERE status_aktif=1");
            cboDokter.DataSource    = dt;
            cboDokter.DisplayMember = "info";
            cboDokter.ValueMember   = "id";
        }

        private void cboDokter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadJadwal();
        }

        private void LoadJadwal()
        {
            if (cboDokter.SelectedValue == null) return;
            int dokterId = Convert.ToInt32(cboDokter.SelectedValue);
            string query = @"SELECT j.id,
                                    j.hari + '  ' + CONVERT(VARCHAR,j.jam_mulai,108) + ' - ' + CONVERT(VARCHAR,j.jam_selesai,108)
                                    + '  (Sisa: ' + CAST(kt.sisa_kuota AS VARCHAR) + ')' AS info,
                                    kt.sisa_kuota
                             FROM jadwal_dokter j
                             JOIN kuota_tersisa kt ON kt.jadwal_id = j.id
                             WHERE j.dokter_id = @did";
            DataTable dt = DBHelper.ExecuteQuery(query,
                new[] { new SqlParameter("@did", dokterId) });
            cboJadwal.DataSource    = dt;
            cboJadwal.DisplayMember = "info";
            cboJadwal.ValueMember   = "id";
        }

        private void btnBuat_Click(object sender, EventArgs e)
        {
            if (cboJadwal.SelectedValue == null)
            {
                MessageBox.Show("Pilih jadwal dokter!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int jadwalId = Convert.ToInt32(cboJadwal.SelectedValue);
            DataRow row  = ((DataTable)cboJadwal.DataSource).Rows[cboJadwal.SelectedIndex];
            int sisa     = Convert.ToInt32(row["sisa_kuota"]);

            if (sisa <= 0)
            {
                MessageBox.Show("Kuota jadwal ini sudah penuh. Pilih jadwal lain.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Cek sudah booking di jadwal+tanggal yang sama
            object cek = DBHelper.ExecuteScalar(
                @"SELECT COUNT(*) FROM booking WHERE pasien_id=@pid AND jadwal_id=@jid
                  AND tanggal_booking=@tgl AND status_booking NOT IN ('ditolak','batal')",
                new[] {
                    new SqlParameter("@pid", SessionHelper.PasienId),
                    new SqlParameter("@jid", jadwalId),
                    new SqlParameter("@tgl", dtpTanggal.Value.Date)
                });

            if (Convert.ToInt32(cek) > 0)
            {
                MessageBox.Show("Anda sudah memiliki booking di jadwal dan tanggal yang sama.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string query = @"INSERT INTO booking (pasien_id, jadwal_id, tanggal_booking, keluhan, status_booking)
                             VALUES (@pid, @jid, @tgl, @keluhan, 'menunggu')";
            SqlParameter[] parms = {
                new SqlParameter("@pid",    SessionHelper.PasienId),
                new SqlParameter("@jid",    jadwalId),
                new SqlParameter("@tgl",    dtpTanggal.Value.Date),
                new SqlParameter("@keluhan", txtKeluhan.Text.Trim())
            };

            DBHelper.ExecuteNonQuery(query, parms);
            MessageBox.Show("Booking berhasil dibuat! Menunggu konfirmasi admin.", "Sukses",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnBatal_Click(object sender, EventArgs e) => this.Close();
    }
}

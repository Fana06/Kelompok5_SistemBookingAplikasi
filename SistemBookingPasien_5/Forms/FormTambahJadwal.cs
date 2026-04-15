using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using SistemBookingPasien_5.Helpers;

namespace SistemBookingPasien_5.Forms
{
    public partial class FormTambahJadwal : Form
    {
        public FormTambahJadwal()
        {
            InitializeComponent();
            LoadDokter();
        }

        private void LoadDokter()
        {
            DataTable dt = DBHelper.ExecuteQuery(
                "SELECT id, nama_dokter FROM dokter WHERE status_aktif=1 ORDER BY nama_dokter");
            cboDokter.DataSource    = dt;
            cboDokter.DisplayMember = "nama_dokter";
            cboDokter.ValueMember   = "id";
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (cboDokter.SelectedValue == null)
            {
                MessageBox.Show("Pilih dokter!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int    dokterId  = Convert.ToInt32(cboDokter.SelectedValue);
            string hari      = cboHari.SelectedItem.ToString();
            string jamMulai  = dtpMulai.Value.ToString("HH:mm");
            string jamSelesai= dtpSelesai.Value.ToString("HH:mm");
            int    kuota     = (int)numKuota.Value;

            if (string.Compare(jamMulai, jamSelesai) >= 0)
            {
                MessageBox.Show("Jam selesai harus lebih besar dari jam mulai!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Cek jadwal ganda
            object cek = DBHelper.ExecuteScalar(
                "SELECT COUNT(*) FROM jadwal_dokter WHERE dokter_id=@did AND hari=@hari",
                new[] { new SqlParameter("@did", dokterId), new SqlParameter("@hari", hari) });
            if (Convert.ToInt32(cek) > 0)
            {
                var conf = MessageBox.Show("Dokter ini sudah punya jadwal di hari yang sama. Lanjutkan?",
                    "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (conf != DialogResult.Yes) return;
            }

            string query = @"INSERT INTO jadwal_dokter (dokter_id, hari, jam_mulai, jam_selesai, kuota)
                             VALUES (@did, @hari, @mulai, @selesai, @kuota)";
            DBHelper.ExecuteNonQuery(query, new[] {
                new SqlParameter("@did",    dokterId),
                new SqlParameter("@hari",   hari),
                new SqlParameter("@mulai",  jamMulai),
                new SqlParameter("@selesai",jamSelesai),
                new SqlParameter("@kuota",  kuota)
            });
            MessageBox.Show("Jadwal berhasil ditambahkan!", "Sukses",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnBatal_Click(object sender, EventArgs e) => this.Close();
    }
}

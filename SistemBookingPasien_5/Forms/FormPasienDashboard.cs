using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using SistemBookingPasien_5.Helpers;

namespace SistemBookingPasien_5.Forms
{
    public partial class FormPasienDashboard : Form
    {
        public FormPasienDashboard()
        {
            InitializeComponent();
            lblWelcome.Text = $"Selamat datang, {SessionHelper.NamaLengkap} 👋";
            LoadRiwayatBooking();
        }

        private void LoadRiwayatBooking()
        {
            string query = @"SELECT b.id, d.nama_dokter, d.spesialisasi,
                                    j.hari, j.jam_mulai, j.jam_selesai,
                                    b.tanggal_booking, b.keluhan, b.status_booking
                             FROM booking b
                             JOIN jadwal_dokter j ON b.jadwal_id = j.id
                             JOIN dokter d ON j.dokter_id = d.id
                             WHERE b.pasien_id = @pid
                             ORDER BY b.tanggal_dibuat DESC";
            DataTable dt = DBHelper.ExecuteQuery(query,
                new[] { new SqlParameter("@pid", SessionHelper.PasienId) });
            dgvBooking.DataSource = dt;
            dgvBooking.Columns["id"].HeaderText             = "ID";
            dgvBooking.Columns["nama_dokter"].HeaderText    = "Dokter";
            dgvBooking.Columns["spesialisasi"].HeaderText   = "Spesialis";
            dgvBooking.Columns["hari"].HeaderText           = "Hari";
            dgvBooking.Columns["jam_mulai"].HeaderText      = "Mulai";
            dgvBooking.Columns["jam_selesai"].HeaderText    = "Selesai";
            dgvBooking.Columns["tanggal_booking"].HeaderText= "Tgl Kontrol";
            dgvBooking.Columns["keluhan"].HeaderText        = "Keluhan";
            dgvBooking.Columns["status_booking"].HeaderText = "Status";
        }

        private void btnBookingBaru_Click(object sender, EventArgs e)
        {
            if (SessionHelper.PasienId == 0)
            {
                MessageBox.Show("Lengkapi profil terlebih dahulu!", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                new FormProfilPasien().ShowDialog();
                return;
            }
            new FormBooking().ShowDialog();
            LoadRiwayatBooking();
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            new FormProfilPasien().ShowDialog();
        }

        private void btnBatalBooking_Click(object sender, EventArgs e)
        {
            if (dgvBooking.CurrentRow == null) return;
            int bid    = Convert.ToInt32(dgvBooking.CurrentRow.Cells["id"].Value);
            string sts = dgvBooking.CurrentRow.Cells["status_booking"].Value.ToString();
            if (sts != "menunggu")
            {
                MessageBox.Show("Hanya booking berstatus 'menunggu' yang bisa dibatalkan.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var conf = MessageBox.Show("Batalkan booking ini?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (conf != DialogResult.Yes) return;
            DBHelper.ExecuteNonQuery(
                "UPDATE booking SET status_booking='batal' WHERE id=@id",
                new[] { new SqlParameter("@id", bid) });
            LoadRiwayatBooking();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            SessionHelper.Clear();
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e) => LoadRiwayatBooking();
    }
}

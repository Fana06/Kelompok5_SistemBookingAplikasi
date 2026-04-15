using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using SistemBookingPasien_5.Helpers;

namespace SistemBookingPasien_5.Forms
{
    public partial class FormAdminDashboard : Form
    {
        public FormAdminDashboard()
        {
            InitializeComponent();
            LoadBooking();
            LoadDokter();
            LoadJadwal();
            LoadPasien();
        }

        // ==================== BOOKING ====================
        private void LoadBooking()
        {
            string q = @"SELECT booking_id AS ID, nama_pasien AS Pasien, nama_dokter AS Dokter,
                                spesialisasi AS Spesialis, hari AS Hari,
                                CONVERT(VARCHAR,jam_mulai,108) + '-' + CONVERT(VARCHAR,jam_selesai,108) AS Jam,
                                tanggal_booking AS Tanggal, keluhan AS Keluhan, status_booking AS Status
                         FROM booking_detail ORDER BY tanggal_dibuat DESC";
            dgvBooking.DataSource = DBHelper.ExecuteQuery(q);
        }

        private void btnSetujui_Click(object sender, EventArgs e) => UpdateStatusBooking("disetujui");
        private void btnTolak_Click(object sender, EventArgs e)   => UpdateStatusBooking("ditolak");
        private void btnSelesai_Click(object sender, EventArgs e) => UpdateStatusBooking("selesai");

        private void UpdateStatusBooking(string status)
        {
            if (dgvBooking.CurrentRow == null) return;
            int bid = Convert.ToInt32(dgvBooking.CurrentRow.Cells["ID"].Value);
            DBHelper.ExecuteNonQuery(
                "UPDATE booking SET status_booking=@s WHERE id=@id",
                new[] { new SqlParameter("@s", status), new SqlParameter("@id", bid) });
            LoadBooking();
        }

        // ==================== DOKTER ====================
        private void LoadDokter()
        {
            dgvDokter.DataSource = DBHelper.ExecuteQuery(
                "SELECT id AS ID, nama_dokter AS Nama, spesialisasi AS Spesialis, no_hp AS HP, status_aktif AS Aktif FROM dokter");
        }

        private void btnTambahDokter_Click(object sender, EventArgs e)
        {
            new FormTambahDokter().ShowDialog();
            LoadDokter();
        }

        private void btnEditDokter_Click(object sender, EventArgs e)
        {
            if (dgvDokter.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvDokter.CurrentRow.Cells["ID"].Value);
            new FormTambahDokter(id).ShowDialog();
            LoadDokter();
        }

        private void btnHapusDokter_Click(object sender, EventArgs e)
        {
            if (dgvDokter.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvDokter.CurrentRow.Cells["ID"].Value);
            var conf = MessageBox.Show("Hapus dokter ini? (jadwal terkait juga terhapus)", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (conf != DialogResult.Yes) return;
            try
            {
                DBHelper.ExecuteNonQuery("DELETE FROM dokter WHERE id=@id",
                    new[] { new SqlParameter("@id", id) });
                LoadDokter(); LoadJadwal();
            }
            catch (Exception ex) { MessageBox.Show("Gagal hapus: " + ex.Message); }
        }

        private void btnToggleAktif_Click(object sender, EventArgs e)
        {
            if (dgvDokter.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvDokter.CurrentRow.Cells["ID"].Value);
            DBHelper.ExecuteNonQuery(
                "UPDATE dokter SET status_aktif = 1 - status_aktif WHERE id=@id",
                new[] { new SqlParameter("@id", id) });
            LoadDokter();
        }

        // ==================== JADWAL ====================
        private void LoadJadwal()
        {
            string q = @"SELECT j.id AS ID, d.nama_dokter AS Dokter, j.hari AS Hari,
                                CONVERT(VARCHAR,j.jam_mulai,108) AS Mulai,
                                CONVERT(VARCHAR,j.jam_selesai,108) AS Selesai,
                                j.kuota AS Kuota
                         FROM jadwal_dokter j JOIN dokter d ON j.dokter_id = d.id
                         ORDER BY d.nama_dokter, j.hari";
            dgvJadwal.DataSource = DBHelper.ExecuteQuery(q);
        }

        private void btnTambahJadwal_Click(object sender, EventArgs e)
        {
            new FormTambahJadwal().ShowDialog();
            LoadJadwal();
        }

        private void btnHapusJadwal_Click(object sender, EventArgs e)
        {
            if (dgvJadwal.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvJadwal.CurrentRow.Cells["ID"].Value);
            var conf = MessageBox.Show("Hapus jadwal ini?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (conf != DialogResult.Yes) return;
            try
            {
                DBHelper.ExecuteNonQuery("DELETE FROM jadwal_dokter WHERE id=@id",
                    new[] { new SqlParameter("@id", id) });
                LoadJadwal();
            }
            catch { MessageBox.Show("Gagal hapus: Ada booking terkait."); }
        }

        // ==================== PASIEN ====================
        private void LoadPasien()
        {
            string q = @"SELECT p.id AS ID, p.nik AS NIK, p.nama_lengkap AS Nama,
                                p.tanggal_lahir AS TglLahir, p.jenis_kelamin AS JK,
                                p.no_hp AS HP, u.email AS Email
                         FROM pasien p JOIN users u ON p.user_id = u.id";
            dgvPasien.DataSource = DBHelper.ExecuteQuery(q);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            SessionHelper.Clear();
            this.Close();
        }

        private void btnRefreshAll_Click(object sender, EventArgs e)
        {
            LoadBooking(); LoadDokter(); LoadJadwal(); LoadPasien();
        }
    }
}

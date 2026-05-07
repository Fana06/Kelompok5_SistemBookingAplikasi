using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using BookingKontrolPasien.Helpers;

namespace BookingKontrolPasien.Forms
{
    public partial class FormDashboardAdmin : Form
    {
        public FormDashboardAdmin()
        {
            InitializeComponent();

            SetupCard(this.cardPasien, this.lblCardPasien, "Total Pasien",
            this.lblTotalPasien, new System.Drawing.Point(20, 20), System.Drawing.Color.FromArgb(41, 128, 185));
            SetupCard(this.cardDokter, this.lblCardDokter, "Dokter Aktif",
            this.lblTotalDokter, new System.Drawing.Point(220, 20), System.Drawing.Color.FromArgb(39, 174, 96));
            SetupCard(this.cardMenunggu, this.lblCardMenunggu, "Booking Menunggu",
            this.lblMenunggu, new System.Drawing.Point(420, 20), System.Drawing.Color.FromArgb(230, 126, 34));

        }

        private void FormDashboardAdmin_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Selamat datang, Administrator";
            LoadSummary();
            LoadDokter();
            LoadBooking();
        }

        private void LoadSummary()
        {
            int totalPasien = Convert.ToInt32(DBHelper.ExecuteScalar("SELECT COUNT(*) FROM pasien"));
            int totalDokter = Convert.ToInt32(DBHelper.ExecuteScalar("SELECT COUNT(*) FROM dokter WHERE status_aktif=1"));
            int totalBooking = Convert.ToInt32(DBHelper.ExecuteScalar("SELECT COUNT(*) FROM booking WHERE status_booking='menunggu'"));

            lblTotalPasien.Text = totalPasien.ToString();
            lblTotalDokter.Text = totalDokter.ToString();
            lblMenunggu.Text = totalBooking.ToString();
        }

        private void LoadBooking(string filter = "")
        {
            // Kita ganti query-nya menggunakan JOIN manual agar kolom 'dokter_id' aman diambil dari tabel jadwal_dokter
            string query = @"SELECT 
                        b.id AS booking_id, 
                        p.nama_lengkap AS nama_pasien, 
                        p.nik, 
                        d.nama_dokter, 
                        j.hari, 
                        j.jam_mulai, 
                        b.tanggal_booking, 
                        b.keluhan, 
                        b.status_booking 
                     FROM booking b
                     JOIN pasien p ON b.pasien_id = p.id
                     JOIN jadwal_dokter j ON b.jadwal_id = j.id
                     JOIN dokter d ON j.dokter_id = d.id"; // Kolom dokter_id diambil lewat JOIN ini

            if (!string.IsNullOrEmpty(filter))
                query += " WHERE b.status_booking = @filter";

            query += " ORDER BY b.tanggal_dibuat DESC";

            SqlParameter[] param = null;
            if (!string.IsNullOrEmpty(filter))
                param = new[] { new SqlParameter("@filter", filter) };

            DataTable dt = DBHelper.ExecuteQuery(query, param);
            dgvBooking.DataSource = dt;
            FormatGrid();
        }

        private void LoadDokter()
        {
            DataTable dt = DBHelper.ExecuteQuery(
                "SELECT id AS ID, nama_dokter AS Nama, spesialisasi AS Spesialisasi, no_hp AS NoHP, " +
                "CASE WHEN status_aktif=1 THEN 'Aktif' ELSE 'Nonaktif' END AS Status FROM dokter ORDER BY id");
            dgvBooking.DataSource = dt;
        }

        private void LoadJadwal()
        {
            DataTable dt = DBHelper.ExecuteQuery(
                @"SELECT j.id AS ID, d.nama_dokter AS Dokter, j.hari AS Hari,
                    CONVERT(VARCHAR(5),j.jam_mulai,108) AS Mulai,
                    CONVERT(VARCHAR(5),j.jam_selesai,108) AS Selesai, j.kuota AS Kuota
                  FROM jadwal_dokter j JOIN dokter d ON j.dokter_id=d.id ORDER BY j.id");
            dgvBooking.DataSource = dt;
        }

        private void FormatGrid()
        {
            dgvBooking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooking.RowHeadersVisible = false;
            dgvBooking.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooking.AllowUserToAddRows = false;

            foreach (DataGridViewRow row in dgvBooking.Rows)
            {
                if (row.Cells["status_booking"] == null) continue;
                string status = row.Cells["status_booking"].Value?.ToString();
                switch (status)
                {
                    case "menunggu": row.DefaultCellStyle.BackColor = Color.FromArgb(255, 249, 196); break;
                    case "disetujui": row.DefaultCellStyle.BackColor = Color.FromArgb(200, 240, 200); break;
                    case "ditolak": row.DefaultCellStyle.BackColor = Color.FromArgb(255, 200, 200); break;
                    case "selesai": row.DefaultCellStyle.BackColor = Color.FromArgb(220, 220, 255); break;
                }
            }
        }

        private void SetupCard(Panel card, Label lblTitle, string titleText,
            Label lblValue, Point loc, Color color)
        {
            card.Location = loc;
            card.Size = new Size(180, 100);
            card.BackColor = color;

            lblTitle.Text = titleText;
            lblTitle.ForeColor = Color.FromArgb(200, 240, 255);
            lblTitle.Font = new Font("Segoe UI", 9F);
            lblTitle.Location = new Point(15, 14);
            lblTitle.Size = new Size(155, 18);

            lblValue.Text = "0";
            lblValue.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblValue.ForeColor = Color.White;
            lblValue.Location = new Point(15, 36);
            lblValue.Size = new Size(155, 50);

            card.Controls.Add(lblTitle);
            card.Controls.Add(lblValue);
        }

        private void SetupActionBtn(Button btn, string text, Color color,
            Point loc, EventHandler handler)
        {
            btn.Text = text;
            btn.BackColor = color;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Location = loc;
            btn.Size = new Size(120, 34);
            btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;
            btn.Click += handler;
        }

        private void btnSetujui_Click(object sender, EventArgs e)
        {
            UpdateBookingStatus("disetujui");
        }

        private void btnTolak_Click(object sender, EventArgs e)
        {
            UpdateBookingStatus("ditolak");
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            UpdateBookingStatus("selesai");
        }

        private void UpdateBookingStatus(string status)
        {
            if (dgvBooking.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih booking terlebih dahulu.", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dgvBooking.SelectedRows[0].Cells["booking_id"].Value);
            DBHelper.ExecuteNonQuery("UPDATE booking SET status_booking=@s WHERE id=@id",
                new SqlParameter[]
                {
                    new SqlParameter("@s",  status),
                    new SqlParameter("@id", id)
                });

            MessageBox.Show($"Status booking diubah menjadi '{status}'.", "Sukses",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadBooking(cmbFilter.SelectedItem?.ToString() == "Semua" ? "" : cmbFilter.SelectedItem?.ToString());
            LoadSummary();
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string val = cmbFilter.SelectedItem?.ToString();
            LoadBooking(val == "Semua" ? "" : val);
        }

        private void btnTambahDokter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNamaDokter.Text) || string.IsNullOrWhiteSpace(txtSpesialisasi.Text))
            {
                MessageBox.Show("Nama dan spesialisasi wajib diisi.", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DBHelper.ExecuteNonQuery(
                "INSERT INTO dokter (nama_dokter, spesialisasi, no_hp, status_aktif) VALUES (@n,@s,@hp,1)",
                new SqlParameter[]
                {
                    new SqlParameter("@n",  txtNamaDokter.Text.Trim()),
                    new SqlParameter("@s",  txtSpesialisasi.Text.Trim()),
                    new SqlParameter("@hp", txtNoHPDokter.Text.Trim())
                });
            MessageBox.Show("Dokter berhasil ditambahkan.", "Sukses",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtNamaDokter.Clear(); txtSpesialisasi.Clear(); txtNoHPDokter.Clear();
            LoadDokter();
        }

        private void btnNonaktifDokter_Click(object sender, EventArgs e)
        {
            if (dgvBooking.SelectedRows.Count == 0) return;
            int id = Convert.ToInt32(dgvBooking.SelectedRows[0].Cells["ID"].Value);
            DBHelper.ExecuteNonQuery(
                "UPDATE dokter SET status_aktif = CASE WHEN status_aktif=1 THEN 0 ELSE 1 END WHERE id=@id",
                new[] { new SqlParameter("@id", id) });
            LoadDokter();
        }

        private void btnTambahJadwal_Click(object sender, EventArgs e)
        {
            if (cmbDokterJadwal.SelectedValue == null)
            {
                MessageBox.Show("Pilih dokter.", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DBHelper.ExecuteNonQuery(
                "INSERT INTO jadwal_dokter (dokter_id, hari, jam_mulai, jam_selesai, kuota) VALUES (@did,@hari,@mulai,@selesai,@kuota)",
                new SqlParameter[]
                {
                    new SqlParameter("@did",    cmbDokterJadwal.SelectedValue),
                    new SqlParameter("@hari",   cmbHari.SelectedItem.ToString()),
                    new SqlParameter("@mulai",  dtpMulai.Value.TimeOfDay),
                    new SqlParameter("@selesai",dtpSelesai.Value.TimeOfDay),
                    new SqlParameter("@kuota",  (int)nudKuota.Value)
                });
            MessageBox.Show("Jadwal ditambahkan.", "Sukses",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadJadwal();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case 0: LoadSummary(); break;
                case 1: LoadBooking(); break;
                case 2: LoadDokter(); break;
                case 3:
                    LoadJadwal();
                    LoadDokterCombo();
                    break;
            }
        }

        private void LoadDokterCombo()
        {
            DataTable dt = DBHelper.ExecuteQuery(
                "SELECT id, nama_dokter FROM dokter WHERE status_aktif=1");
            cmbDokterJadwal.DataSource = dt;
            cmbDokterJadwal.DisplayMember = "nama_dokter";
            cmbDokterJadwal.ValueMember = "id";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            this.Hide();
            new FormLogin().Show();
        }

        private void FormDashboardAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void panelCards_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabDokter_Click(object sender, EventArgs e)
        {

        }
    }
}
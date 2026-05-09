using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using BookingKontrolPasien.Helpers;

namespace BookingKontrolPasien.Forms
{
    public partial class FormDashboardPasien : Form
    {
        public FormDashboardPasien()
        {
            InitializeComponent();

            int yStart = 70, gap = 52;
            SetupProfileRow(this.lblNikKey, "NIK", this.lblProfilNIK, yStart + gap * 0);
            SetupProfileRow(this.lblNamaKey, "Nama Lengkap", this.lblProfilNama, yStart + gap * 1);
            SetupProfileRow(this.lblTglKey, "Tanggal Lahir", this.lblProfilTgl, yStart + gap * 2);
            SetupProfileRow(this.lblJKKey, "Jenis Kelamin", this.lblProfilJK, yStart + gap * 3);
            SetupProfileRow(this.lblAlamatKey, "Alamat", this.lblProfilAlamat, yStart + gap * 4);
            SetupProfileRow(this.lblHPKey, "No. HP", this.lblProfilHP, yStart + gap * 5);
            SetupProfileRow(this.lblEmailKey, "Email", this.lblProfilEmail, yStart + gap * 6); 
        }

        private void FormDashboardPasien_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Selamat datang, {Session.NamaLengkap}";
            LoadRiwayatBooking();
            LoadJadwalTersedia();
        }

        private void LoadRiwayatBooking(string keyword = "")
        {
            string query = @"
    SELECT
        booking_id AS ID,
        nama_dokter AS Dokter,
        spesialisasi AS Spesialisasi,
        hari AS Hari,
        CONVERT(VARCHAR(5),jam_mulai,108) AS Mulai,
        tanggal_booking AS Tanggal,
        keluhan AS Keluhan,
        status_booking AS Status
    FROM booking_detail
    WHERE nik =
    (
        SELECT nik
        FROM pasien
        WHERE id=@pid
    )";

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                query += @"
        AND
        (
            nama_dokter LIKE @key
            OR spesialisasi LIKE @key
            OR hari LIKE @key
            OR keluhan LIKE @key
            OR status_booking LIKE @key
        )";
            }

            query += " ORDER BY tanggal_dibuat DESC";

            SqlParameter[] param;

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                param = new SqlParameter[]
                {
            new SqlParameter("@pid", Session.PasienId),
            new SqlParameter("@key", "%" + keyword + "%")
                };
            }
            else
            {
                param = new SqlParameter[]
                {
            new SqlParameter("@pid", Session.PasienId)
                };
            }

            DataTable dt =
                DBHelper.ExecuteQuery(query, param);

            dgvRiwayat.DataSource = dt;

            FormatGridStatus(dgvRiwayat, "Status");
        }

        private void txtCariRiwayat_TextChanged(
            object sender,
            EventArgs e)
                {
                    LoadRiwayatBooking(
                        txtCariRiwayat.Text.Trim());
                }

        private void LoadJadwalTersedia()
        {
            string query = @"SELECT 
                        j.id AS ID, 
                        d.nama_dokter AS Dokter, 
                        j.hari AS Hari,
                        CONVERT(VARCHAR(5),j.jam_mulai,108) AS Mulai,
                        CONVERT(VARCHAR(5),j.jam_selesai,108) AS Selesai,
                        j.kuota AS Kuota
                     FROM jadwal_dokter j
                     JOIN dokter d ON j.dokter_id = d.id
                     WHERE d.status_aktif = 1";

            DataTable dt = DBHelper.ExecuteQuery(query);
            dgvJadwal.DataSource = dt;
            dgvJadwal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvJadwal.RowHeadersVisible = false;
            dgvJadwal.ReadOnly = true;
            dgvJadwal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            if (dgvJadwal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih jadwal terlebih dahulu.", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtKeluhan.Text))
            {
                MessageBox.Show("Isi keluhan terlebih dahulu.", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int jadwalId = Convert.ToInt32(dgvJadwal.SelectedRows[0].Cells["ID"].Value);

            string cek = @"SELECT COUNT(*) FROM booking
                           WHERE pasien_id=@pid AND jadwal_id=@jid
                             AND status_booking NOT IN ('ditolak','batal')";
            int existing = Convert.ToInt32(DBHelper.ExecuteScalar(cek,
                new SqlParameter[]
                {
                    new SqlParameter("@pid", Session.PasienId),
                    new SqlParameter("@jid", jadwalId)
                }));

            if (existing > 0)
            {
                MessageBox.Show("Anda sudah memiliki booking aktif untuk jadwal ini.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DBHelper.ExecuteNonQuery(
                @"INSERT INTO booking (pasien_id, jadwal_id, tanggal_booking, keluhan, status_booking)
                  VALUES (@pid, @jid, CAST(GETDATE() AS DATE), @keluhan, 'menunggu')",
                new SqlParameter[]
                {
                    new SqlParameter("@pid",    Session.PasienId),
                    new SqlParameter("@jid",    jadwalId),
                    new SqlParameter("@keluhan",txtKeluhan.Text.Trim())
                });

            MessageBox.Show("Booking berhasil! Menunggu persetujuan admin.", "Sukses",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtKeluhan.Clear();
            LoadRiwayatBooking();
            LoadJadwalTersedia();
            tabControl.SelectedIndex = 0;
        }

        private void btnBatalBooking_Click(object sender, EventArgs e)
        {
            if (dgvRiwayat.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih booking untuk dibatalkan.", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string status = dgvRiwayat.SelectedRows[0].Cells["Status"].Value?.ToString();
            if (status != "menunggu")
            {
                MessageBox.Show("Hanya booking berstatus 'menunggu' yang dapat dibatalkan.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int bookingId = Convert.ToInt32(dgvRiwayat.SelectedRows[0].Cells["ID"].Value);
            var confirm = MessageBox.Show("Yakin ingin membatalkan booking ini?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                DBHelper.ExecuteNonQuery(
                    "UPDATE booking SET status_booking='batal' WHERE id=@id",
                    new[] { new SqlParameter("@id", bookingId) });
                MessageBox.Show("Booking berhasil dibatalkan.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRiwayatBooking();
                LoadJadwalTersedia();
            }
        }

        private void LoadProfilPasien()
        {
            DataTable dt = DBHelper.ExecuteQuery(
                @"SELECT p.nik, p.nama_lengkap, p.tanggal_lahir, p.jenis_kelamin, p.alamat, p.no_hp, u.email
                  FROM pasien p JOIN users u ON p.user_id=u.id
                  WHERE p.id=@pid",
                new[] { new SqlParameter("@pid", Session.PasienId) });

            if (dt.Rows.Count > 0)
            {
                DataRow r = dt.Rows[0];
                lblProfilNIK.Text = r["nik"].ToString();
                lblProfilNama.Text = r["nama_lengkap"].ToString();
                lblProfilTgl.Text = Convert.ToDateTime(r["tanggal_lahir"]).ToString("dd MMMM yyyy");
                lblProfilJK.Text = r["jenis_kelamin"].ToString() == "L" ? "Laki-laki" : "Perempuan";
                lblProfilAlamat.Text = r["alamat"].ToString();
                lblProfilHP.Text = r["no_hp"].ToString();
                lblProfilEmail.Text = r["email"].ToString();
            }
        }

        private void SetupProfileRow(Label lblKey, string keyText, Label lblVal, int y)
        {
            lblKey.Text = keyText;
            lblKey.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblKey.ForeColor = Color.FromArgb(100, 100, 100);
            lblKey.Location = new Point(20, y);
            lblKey.Size = new Size(140, 18);

            lblVal.Text = "-";
            lblVal.Font = new Font("Segoe UI", 10F);
            lblVal.ForeColor = Color.FromArgb(30, 30, 30);
            lblVal.Location = new Point(20, y + 20);
            lblVal.Size = new Size(550, 22);
        }

        private void FormatGridStatus(DataGridView dgv, string statusCol)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.RowHeadersVisible = false;
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AllowUserToAddRows = false;

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells[statusCol] == null) continue;
                string s = row.Cells[statusCol].Value?.ToString();
                switch (s)
                {
                    case "menunggu": row.DefaultCellStyle.BackColor = Color.FromArgb(255, 249, 196); break;
                    case "disetujui": row.DefaultCellStyle.BackColor = Color.FromArgb(200, 240, 200); break;
                    case "ditolak": row.DefaultCellStyle.BackColor = Color.FromArgb(255, 200, 200); break;
                    case "selesai": row.DefaultCellStyle.BackColor = Color.FromArgb(220, 220, 255); break;
                    case "batal": row.DefaultCellStyle.BackColor = Color.FromArgb(220, 220, 220); break;
                }
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case 0: LoadRiwayatBooking(); break;
                case 1: LoadJadwalTersedia(); break;
                case 2: LoadProfilPasien(); break;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            this.Hide();
            new FormLogin().Show();
        }

        private void FormDashboardPasien_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
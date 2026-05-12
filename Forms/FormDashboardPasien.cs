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

            int yStart = 70;
            int gap = 52;

            SetupProfileRow(lblNikKey, "NIK", lblProfilNIK, yStart + gap * 0);
            SetupProfileRow(lblNamaKey, "Nama Lengkap", lblProfilNama, yStart + gap * 1);
            SetupProfileRow(lblTglKey, "Tanggal Lahir", lblProfilTgl, yStart + gap * 2);
            SetupProfileRow(lblJKKey, "Jenis Kelamin", lblProfilJK, yStart + gap * 3);
            SetupProfileRow(lblAlamatKey, "Alamat", lblProfilAlamat, yStart + gap * 4);
            SetupProfileRow(lblHPKey, "No. HP", lblProfilHP, yStart + gap * 5);
            SetupProfileRow(lblEmailKey, "Email", lblProfilEmail, yStart + gap * 6);
        }

        private void FormDashboardPasien_Load(object sender, EventArgs e)
        {
            lblWelcome.Text =
                $"Selamat datang, {Session.NamaLengkap}";

            LoadRiwayatBooking();
            LoadJadwalTersedia();
            LoadProfilPasien();
        }

        private void LoadRiwayatBooking(string keyword = "")
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = DBHelper.GetConnection())
            {
                conn.Open();

                using (SqlCommand cmd =
                    new SqlCommand(
                        "sp_LoadRiwayatBooking",
                        conn))
                {
                    cmd.CommandType =
                        CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue(
                        "@pid",
                        Session.PasienId);

                    cmd.Parameters.AddWithValue(
                        "@keyword",
                        keyword);

                    using (SqlDataAdapter da =
                        new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            dgvRiwayat.DataSource = dt;

            FormatGridStatus(
                dgvRiwayat,
                "Status");
        }

        private void LoadJadwalTersedia()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = DBHelper.GetConnection())
            {
                conn.Open();

                using (SqlCommand cmd =
                    new SqlCommand(
                        "sp_LoadJadwalTersedia",
                        conn))
                {
                    cmd.CommandType =
                        CommandType.StoredProcedure;

                    using (SqlDataAdapter da =
                        new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            dgvJadwal.DataSource = dt;

            dgvJadwal.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvJadwal.RowHeadersVisible = false;

            dgvJadwal.ReadOnly = true;

            dgvJadwal.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadProfilPasien()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = DBHelper.GetConnection())
            {
                conn.Open();

                using (SqlCommand cmd =
                    new SqlCommand(
                        "sp_LoadProfilPasien",
                        conn))
                {
                    cmd.CommandType =
                        CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue(
                        "@pid",
                        Session.PasienId);

                    using (SqlDataAdapter da =
                        new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            if (dt.Rows.Count > 0)
            {
                DataRow r = dt.Rows[0];

                lblProfilNIK.Text =
                    r["nik"].ToString();

                lblProfilNama.Text =
                    r["nama_lengkap"].ToString();

                lblProfilTgl.Text =
                    Convert.ToDateTime(
                        r["tanggal_lahir"])
                    .ToString("dd MMMM yyyy");

                lblProfilJK.Text =
                    r["jenis_kelamin"].ToString() == "L"
                    ? "Laki-laki"
                    : "Perempuan";

                lblProfilAlamat.Text =
                    r["alamat"].ToString();

                lblProfilHP.Text =
                    r["no_hp"].ToString();

                lblProfilEmail.Text =
                    r["email"].ToString();
            }
        }

        private void BtnBooking_Click(object sender, EventArgs e)
        {
            if (dgvJadwal.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Pilih jadwal terlebih dahulu.",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (string.IsNullOrWhiteSpace(txtKeluhan.Text))
            {
                MessageBox.Show(
                    "Isi keluhan terlebih dahulu.",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int jadwalId =
                Convert.ToInt32(
                    dgvJadwal.SelectedRows[0]
                    .Cells["ID"]
                    .Value);

            int existing = 0;

            using (SqlConnection conn = DBHelper.GetConnection())
            {
                conn.Open();

                using (SqlCommand cmd =
                    new SqlCommand(
                        "sp_CekBookingAktif",
                        conn))
                {
                    cmd.CommandType =
                        CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue(
                        "@pid",
                        Session.PasienId);

                    cmd.Parameters.AddWithValue(
                        "@jid",
                        jadwalId);

                    existing =
                        Convert.ToInt32(
                            cmd.ExecuteScalar());
                }
            }

            if (existing > 0)
            {
                MessageBox.Show(
                    "Anda sudah memiliki booking aktif untuk jadwal ini.",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            using (SqlConnection conn = DBHelper.GetConnection())
            {
                conn.Open();

                using (SqlCommand cmd =
                    new SqlCommand(
                        "sp_InsertBooking",
                        conn))
                {
                    cmd.CommandType =
                        CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue(
                        "@pid",
                        Session.PasienId);

                    cmd.Parameters.AddWithValue(
                        "@jid",
                        jadwalId);

                    cmd.Parameters.AddWithValue(
                        "@keluhan",
                        txtKeluhan.Text.Trim());

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show(
                "Booking berhasil! Menunggu persetujuan admin.",
                "Sukses",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            txtKeluhan.Clear();

            LoadRiwayatBooking();
            LoadJadwalTersedia();

            tabControl.SelectedIndex = 0;
        }

        private void BtnBatalBooking_Click(object sender, EventArgs e)
        {
            if (dgvRiwayat.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Pilih booking untuk dibatalkan.",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string status =
                dgvRiwayat.SelectedRows[0]
                .Cells["Status"]
                .Value
                ?.ToString();

            if (status != "menunggu")
            {
                MessageBox.Show(
                    "Hanya booking berstatus 'menunggu' yang dapat dibatalkan.",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            int bookingId =
                Convert.ToInt32(
                    dgvRiwayat.SelectedRows[0]
                    .Cells["ID"]
                    .Value);

            DialogResult confirm =
                MessageBox.Show(
                    "Yakin ingin membatalkan booking ini?",
                    "Konfirmasi",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                using (SqlConnection conn = DBHelper.GetConnection())
                {
                    conn.Open();

                    using (SqlCommand cmd =
                        new SqlCommand(
                            "sp_BatalBooking",
                            conn))
                    {
                        cmd.CommandType =
                            CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue(
                            "@id",
                            bookingId);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Booking berhasil dibatalkan.",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadRiwayatBooking();
                LoadJadwalTersedia();
            }
        }

        private void TxtCariRiwayat_TextChanged(
            object sender,
            EventArgs e)
        {
            LoadRiwayatBooking(
                txtCariRiwayat.Text.Trim());
        }

        private void SetupProfileRow(
            Label lblKey,
            string keyText,
            Label lblVal,
            int y)
        {
            lblKey.Text = keyText;

            lblKey.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold);

            lblKey.ForeColor =
                Color.FromArgb(100, 100, 100);

            lblKey.Location =
                new Point(20, y);

            lblKey.Size =
                new Size(140, 18);

            lblVal.Text = "-";

            lblVal.Font =
                new Font("Segoe UI", 10F);

            lblVal.ForeColor =
                Color.FromArgb(30, 30, 30);

            lblVal.Location =
                new Point(20, y + 20);

            lblVal.Size =
                new Size(550, 22);
        }

        private void FormatGridStatus(
            DataGridView dgv,
            string statusCol)
        {
            dgv.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgv.RowHeadersVisible = false;

            dgv.ReadOnly = true;

            dgv.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgv.AllowUserToAddRows = false;

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells[statusCol] == null)
                    continue;

                string s =
                    row.Cells[statusCol]
                    .Value
                    ?.ToString();

                switch (s)
                {
                    case "menunggu":
                        row.DefaultCellStyle.BackColor =
                            Color.FromArgb(255, 249, 196);
                        break;

                    case "disetujui":
                        row.DefaultCellStyle.BackColor =
                            Color.FromArgb(200, 240, 200);
                        break;

                    case "ditolak":
                        row.DefaultCellStyle.BackColor =
                            Color.FromArgb(255, 200, 200);
                        break;

                    case "selesai":
                        row.DefaultCellStyle.BackColor =
                            Color.FromArgb(220, 220, 255);
                        break;

                    case "batal":
                        row.DefaultCellStyle.BackColor =
                            Color.FromArgb(220, 220, 220);
                        break;
                }
            }
        }

        private void TabControl_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    LoadRiwayatBooking();
                    break;

                case 1:
                    LoadJadwalTersedia();
                    break;

                case 2:
                    LoadProfilPasien();
                    break;
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();

            this.Hide();

            new FormLogin().Show();
        }

        private void FormDashboardPasien_FormClosed(
            object sender,
            FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}


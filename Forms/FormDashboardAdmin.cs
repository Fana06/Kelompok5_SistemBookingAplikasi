using BookingKontrolPasien.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BookingKontrolPasien.Forms
{
    public partial class FormDashboardAdmin : Form
    {
        public FormDashboardAdmin()
        {
            InitializeComponent();

            SetupCard(
                this.cardPasien,
                this.lblCardPasien,
                "Total Pasien",
                this.lblTotalPasien,
                new Point(20, 20),
                Color.FromArgb(41, 128, 185));

            SetupCard(
                this.cardDokter,
                this.lblCardDokter,
                "Dokter Aktif",
                this.lblTotalDokter,
                new Point(220, 20),
                Color.FromArgb(39, 174, 96));

            SetupCard(
                this.cardMenunggu,
                this.lblCardMenunggu,
                "Booking Menunggu",
                this.lblMenunggu,
                new Point(420, 20),
                Color.FromArgb(230, 126, 34)); 
        }


    private void FormDashboardAdmin_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Selamat datang, Administrator";

            UpdateExpiredBookings();

            cmbFilter.SelectedIndex = 0;

            LoadSummary();

            LoadDokterCombo();

            LoadBooking();

            LoadDokter();

            LoadJadwal();

            dgvBooking.BringToFront();
            dgvDokter.BringToFront();
            dgvJadwal.BringToFront();
        }

        private void UpdateExpiredBookings()
        {
            using (SqlConnection conn =
                DBHelper.GetConnection())
            {
                conn.Open();

                using (SqlCommand cmd =
                    new SqlCommand(
                        "sp_UpdateExpiredBookings",
                        conn))
                {
                    cmd.CommandType =
                        CommandType.StoredProcedure;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void LoadSummary()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn =
                DBHelper.GetConnection())
            {
                conn.Open();

                using (SqlCommand cmd =
                    new SqlCommand(
                        "sp_LoadSummary",
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

            if (dt.Rows.Count > 0)
            {
                lblTotalPasien.Text =
                    dt.Rows[0]["total_pasien"].ToString();

                lblTotalDokter.Text =
                    dt.Rows[0]["total_dokter"].ToString();

                lblMenunggu.Text =
                    dt.Rows[0]["total_booking"].ToString();
            }
        }

private void LoadBooking(string filter = "")
        {
            try
            {
                DataTable dt = new DataTable();

                using (SqlConnection conn =
                    DBHelper.GetConnection())
                {
                    conn.Open();

                    using (SqlCommand cmd =
                        new SqlCommand(
                            "sp_LoadBooking",
                            conn))
                    {
                        cmd.CommandType =
                            CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue(
                            "@filter",
                            filter);

                        using (SqlDataAdapter da =
                            new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }

                dgvBooking.DataSource = dt;

                FormatGridBooking();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat booking: "
                    + ex.Message);
            }
        }


private void LoadDokter(string keyword = "")
        {
            try
            {
                DataTable dt = new DataTable();

                using (SqlConnection conn =
                    DBHelper.GetConnection())
                {
                    conn.Open();

                    using (SqlCommand cmd =
                        new SqlCommand(
                            "sp_SearchDokter",
                            conn))
                    {
                        cmd.CommandType =
                            CommandType.StoredProcedure;

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

                dgvDokter.Columns.Clear();

                dgvDokter.DataSource = dt;

                dgvDokter.BringToFront();

                dgvDokter.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                dgvDokter.RowHeadersVisible = false;

                dgvDokter.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;

                dgvDokter.AllowUserToAddRows = false;

                dgvDokter.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error LoadDokter: "
                    + ex.Message);
            }
        }


private void LoadJadwal()
        {
            try
            {
                DataTable dt = new DataTable();

                using (SqlConnection conn =
                    DBHelper.GetConnection())
                {
                    conn.Open();

                    using (SqlCommand cmd =
                        new SqlCommand(
                            "sp_LoadJadwal",
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

                dgvJadwal.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;

                dgvJadwal.AllowUserToAddRows = false;

                dgvJadwal.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat jadwal: "
                    + ex.Message);
            }
        }


private void LoadDokterCombo()
        {
            try
            {
                DataTable dt = new DataTable();

                using (SqlConnection conn =
                    DBHelper.GetConnection())
                {
                    conn.Open();

                    using (SqlCommand cmd =
                        new SqlCommand(
                            "sp_LoadDokterCombo",
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

                cmbDokterJadwal.DataSource = dt;

                cmbDokterJadwal.DisplayMember =
                    "nama_dokter";

                cmbDokterJadwal.ValueMember =
                    "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat combo dokter: "
                    + ex.Message);
            }
        }


        private void FormatGridBooking()
        {
            if (!dgvBooking.Columns.Contains("status_booking"))
                return;

            dgvBooking.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvBooking.RowHeadersVisible = false;

            dgvBooking.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvBooking.MultiSelect = false;

            dgvBooking.ReadOnly = true;

            dgvBooking.AllowUserToAddRows = false;

            foreach (DataGridViewRow row in dgvBooking.Rows)
            {
                if (row.Cells["status_booking"] == null)
                    continue;

                string status =
                    row.Cells["status_booking"].Value?.ToString();

                switch (status)
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
                }
            }
        }

        private void SetupCard(
            Panel card,
            Label lblTitle,
            string titleText,
            Label lblValue,
            Point loc,
            Color color)
        {
            card.Location = loc;
            card.Size = new Size(180, 100);
            card.BackColor = color;

            lblTitle.Text = titleText;
            lblTitle.ForeColor =
                Color.FromArgb(200, 240, 255);

            lblTitle.Font =
                new Font("Segoe UI", 9F);

            lblTitle.Location =
                new Point(15, 14);

            lblTitle.Size =
                new Size(155, 18);

            lblValue.Text = "0";

            lblValue.Font =
                new Font(
                    "Segoe UI",
                    28F,
                    FontStyle.Bold);

            lblValue.ForeColor = Color.White;

            lblValue.Location =
                new Point(15, 36);

            lblValue.Size =
                new Size(155, 50);

            card.Controls.Add(lblTitle);
            card.Controls.Add(lblValue);
        }

        private void BtnSetujui_Click(object sender, EventArgs e)
        {
            UpdateBookingStatus("disetujui");
        }

        private void BtnTolak_Click(object sender, EventArgs e)
        {
            UpdateBookingStatus("ditolak");
        }

        private void BtnSelesai_Click(object sender, EventArgs e)
        {
            UpdateBookingStatus("selesai");
        }

        private void UpdateBookingStatus(string status)
        {
            try
            {
                if (dgvBooking.SelectedRows.Count == 0)
                {
                    MessageBox.Show(
                        "Pilih booking terlebih dahulu.");

                    return;
                }

                int id = Convert.ToInt32(
                    dgvBooking.SelectedRows[0]
                    .Cells["booking_id"].Value);

                using (SqlConnection conn =
    DBHelper.GetConnection())
                {
                    conn.Open();

                    using (SqlCommand cmd =
                        new SqlCommand(
                            "sp_UpdateBookingStatus",
                            conn))
                    {
                        cmd.CommandType =
                            CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue(
                            "@id",
                            id);

                        cmd.Parameters.AddWithValue(
                            "@status",
                            status);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    $"Status booking diubah menjadi '{status}'.");

                string filter =
                    cmbFilter.SelectedItem?.ToString();

                LoadBooking(
                    filter == "Semua" ? "" : filter);

                LoadSummary();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal update status: " + ex.Message); 
            }
        }

        private void CmbFilter_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            string val =
                cmbFilter.SelectedItem?.ToString();

            LoadBooking(
                val == "Semua" ? "" : val);
        }

        private void BtnTambahDokter_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (
                    string.IsNullOrWhiteSpace(txtNamaDokter.Text)
                    ||
                    string.IsNullOrWhiteSpace(txtSpesialisasi.Text)
                   )
                {
                    MessageBox.Show(
                        "Nama dan spesialisasi wajib diisi.");

                    return;
                }
                if (!Regex.IsMatch(
    txtNamaDokter.Text.Trim(),
    @"^[a-zA-Z ]+$"))
                {
                    MessageBox.Show(
                        "Nama dokter hanya boleh huruf dan spasi.");

                    return;
                }
                using (SqlConnection conn =
    DBHelper.GetConnection())
                {
                    conn.Open();

                    using (SqlCommand cmd =
                        new SqlCommand(
                            "sp_InsertDokter",
                            conn))
                    {
                        cmd.CommandType =
                            CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue(
                            "@nama",
                            txtNamaDokter.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@spesialisasi",
                            txtSpesialisasi.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@hp",
                            txtNoHPDokter.Text.Trim());

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Dokter berhasil ditambahkan.");

                txtNamaDokter.Clear();
                txtSpesialisasi.Clear();
                txtNoHPDokter.Clear();

                LoadDokter();
                LoadDokterCombo();
                LoadSummary();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal tambah dokter: " + ex.Message); 
            }
        }

        private void BtnNonaktifDokter_Click    (
            object sender,
            EventArgs e)
        {
            try
            {
                if (dgvDokter.SelectedRows.Count == 0)
                {
                    MessageBox.Show(
                        "Pilih dokter terlebih dahulu.");

                    return;
                }

                int id = Convert.ToInt32(
                    dgvDokter.SelectedRows[0]
                    .Cells["ID"].Value);

                using (SqlConnection conn =
     DBHelper.GetConnection())
                {
                    conn.Open();

                    using (SqlCommand cmd =
                        new SqlCommand(
                            "sp_ToggleDokterStatus",
                            conn))
                    {
                        cmd.CommandType =
                            CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue(
                            "@id",
                            id);

                        cmd.ExecuteNonQuery();
                    }
                }

                LoadDokter();
                LoadDokterCombo();
                LoadSummary();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal ubah status dokter: " + ex.Message); 
            }
        }

        private void BtnTambahJadwal_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (cmbDokterJadwal.SelectedValue == null)
                {
                    MessageBox.Show(
                        "Pilih dokter.");

                    return;
                }

                if (cmbHari.SelectedItem == null)
                {
                    MessageBox.Show(
                        "Pilih hari.");

                    return;
                }

                if (dtpMulai.Value >= dtpSelesai.Value)
                {
                    MessageBox.Show(
                        "Jam selesai harus lebih besar.");

                    return;
                }

                using (SqlConnection conn =
    DBHelper.GetConnection())
                {
                    conn.Open();

                    using (SqlCommand cmd =
                        new SqlCommand(
                            "sp_InsertJadwal",
                            conn))
                    {
                        cmd.CommandType =
                            CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue(
                            "@did",
                            cmbDokterJadwal.SelectedValue);

                        cmd.Parameters.AddWithValue(
                            "@hari",
                            cmbHari.SelectedItem.ToString());

                        cmd.Parameters.AddWithValue(
                            "@mulai",
                            dtpMulai.Value.TimeOfDay);

                        cmd.Parameters.AddWithValue(
                            "@selesai",
                            dtpSelesai.Value.TimeOfDay);

                        cmd.Parameters.AddWithValue(
                            "@kuota",
                            (int)nudKuota.Value);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Jadwal berhasil ditambahkan.");

                LoadJadwal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal tambah jadwal: " + ex.Message);
            }
        }

        private void BtnHapusJadwal_Click(
    object sender,
    EventArgs e)
        {
            try
            {
                if (dgvJadwal.SelectedRows.Count == 0)
                {
                    MessageBox.Show(
                        "Pilih jadwal terlebih dahulu.");

                    return;
                }

                int id = Convert.ToInt32(
                    dgvJadwal.SelectedRows[0]
                    .Cells["ID"].Value);

                DialogResult result = MessageBox.Show(
                    "Yakin ingin menghapus jadwal ini dari daftar?",
                    "Konfirmasi",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                    return;

                using (SqlConnection conn =
    DBHelper.GetConnection())
                {
                    conn.Open();

                    using (SqlCommand cmd =
                        new SqlCommand(
                            "sp_HapusJadwal",
                            conn))
                    {
                        cmd.CommandType =
                            CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue(
                            "@id",
                            id);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Jadwal berhasil dihapus dari daftar.");

                LoadJadwal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal menghapus jadwal: " + ex.Message);
            }
        }

        private void TabControl_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            try
            {
                if (tabControl.SelectedTab == tabBooking)
                {
                    UpdateExpiredBookings();

                    string filter =
                        cmbFilter.SelectedItem?.ToString();

                    LoadBooking(
                        filter == "Semua"
                        ? ""
                        : filter);
                }

                else if (tabControl.SelectedTab == tabDokter)
                {
                    LoadDokter();
                }

                else if (tabControl.SelectedTab == tabJadwal)
                {
                    LoadDokterCombo();
                    LoadJadwal();
                }

                else if (tabControl.SelectedTab == tabSummary)
                {
                    LoadSummary();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Terjadi error: " + ex.Message);
            }
        }

        private void CmbDokterJadwal_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            try
            {
                if (cmbDokterJadwal.SelectedValue == null)
                    return;

                if (!(cmbDokterJadwal.SelectedValue is int))
                    return;

                int dokterId =
                    Convert.ToInt32(
                        cmbDokterJadwal.SelectedValue);

                DataTable dt = new DataTable();

                using (SqlConnection conn =
                    DBHelper.GetConnection())
                {
                    conn.Open();

                    using (SqlCommand cmd =
                        new SqlCommand(
                            "sp_FilterJadwalDokter",
                            conn))
                    {
                        cmd.CommandType =
                            CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue(
                            "@id",
                            dokterId);

                        using (SqlDataAdapter da =
                            new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }

                dgvJadwal.DataSource = dt;

                dgvJadwal.DataSource = dt;
            }
            catch
            {

            }
        }

        private void BtnLogout_Click(
            object sender,
            EventArgs e)
        {
            Session.Clear();

            this.Hide();

            new FormLogin().Show();
        }

        private void FormDashboardAdmin_FormClosed(
            object sender,
            FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void PanelCards_Paint(
            object sender,
            PaintEventArgs e)
        {
            Panel pnl = sender as Panel;

            using (Pen pen =
                new Pen(Color.FromArgb(220, 220, 220), 1))
            {
                e.Graphics.DrawRectangle(
                    pen,
                    0,
                    0,
                    pnl.Width - 1,
                    pnl.Height - 1);
            }
        }

        private void PanelFormJadwal_Paint(
            object sender,
            PaintEventArgs e)
        {
            Panel pnl = sender as Panel;

            using (Pen pen =
                new Pen(Color.FromArgb(210, 210, 210), 1))
            {
                e.Graphics.DrawRectangle(
                    pen,
                    0,
                    0,
                    pnl.Width - 1,
                    pnl.Height - 1);
            }
        }

        private void TabDokter_Click(
            object sender,
            EventArgs e)
        {
            LoadDokter();
        }

        private void TxtCariDokter_TextChanged(
    object sender,
    EventArgs e)
        {
            LoadDokter(
                txtCariDokter.Text.Trim());
        }
    }
}
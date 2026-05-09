using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using BookingKontrolPasien.Helpers;
using System.Text.RegularExpressions;

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
            string query = @"
            UPDATE b
            SET b.status_booking = 'selesai'
            FROM booking b
            JOIN jadwal_dokter j ON b.jadwal_id = j.id
            WHERE 
                b.status_booking IN ('menunggu', 'disetujui')
                AND DATEADD(
                    SECOND,
                    DATEDIFF(SECOND, '00:00:00', j.jam_selesai),
                    CAST(b.tanggal_booking AS DATETIME)
                ) < GETDATE()
            ";

            DBHelper.ExecuteNonQuery(query); 
        }

        private void LoadSummary()
        {
            int totalPasien = Convert.ToInt32(
                DBHelper.ExecuteScalar("SELECT COUNT(*) FROM pasien"));

            int totalDokter = Convert.ToInt32(
                DBHelper.ExecuteScalar(
                    "SELECT COUNT(*) FROM dokter WHERE status_aktif=1"));

            int totalBooking = Convert.ToInt32(
                DBHelper.ExecuteScalar(
                    "SELECT COUNT(*) FROM booking WHERE status_booking='menunggu'"));

            lblTotalPasien.Text = totalPasien.ToString();
            lblTotalDokter.Text = totalDokter.ToString();
            lblMenunggu.Text = totalBooking.ToString();
        }

        private void LoadBooking(string filter = "")
        {
            try
            {
                string query = @"
                SELECT 
                    b.id AS booking_id,
                    p.nama_lengkap AS nama_pasien,
                    p.nik,
                    d.nama_dokter,
                    j.hari,
                    CONVERT(VARCHAR(5), j.jam_mulai, 108) AS jam_mulai,
                    b.tanggal_booking,
                    b.keluhan,
                    b.status_booking
                FROM booking b
                JOIN pasien p ON b.pasien_id = p.id
                JOIN jadwal_dokter j ON b.jadwal_id = j.id
                JOIN dokter d ON j.dokter_id = d.id";

                if (!string.IsNullOrEmpty(filter))
                {
                    query += " WHERE b.status_booking = @filter";
                }

                query += " ORDER BY b.tanggal_dibuat DESC";

                SqlParameter[] param = null;

                if (!string.IsNullOrEmpty(filter))
                {
                    param = new[]
                    {
                        new SqlParameter("@filter", filter)
                    };
                }

                DataTable dt = DBHelper.ExecuteQuery(query, param);

                dgvBooking.DataSource = dt;

                FormatGridBooking();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat booking: " + ex.Message); 
            }
        }

        private void LoadDokter()
        {
            try
            {
                string query = @"
        SELECT 
            id AS ID,
            nama_dokter AS Nama,
            spesialisasi AS Spesialisasi,
            no_hp AS NoHP,
            CASE
                WHEN status_aktif = 1 THEN 'Aktif'
                ELSE 'Nonaktif'
            END AS Status
        FROM dokter
        ORDER BY id";

                DataTable dt = DBHelper.ExecuteQuery(query);

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
                    "Error LoadDokter: " + ex.Message); 
            }
        }

        private void LoadJadwal()
        {
            try
            {
                string query = @"
                SELECT 
                    j.id AS ID,
                    d.nama_dokter AS Dokter,
                    j.hari AS Hari,
                    CONVERT(VARCHAR(5), j.jam_mulai, 108) AS Mulai,
                    CONVERT(VARCHAR(5), j.jam_selesai, 108) AS Selesai,
                    j.kuota AS Kuota
                FROM jadwal_dokter j
                JOIN dokter d ON j.dokter_id = d.id
                ORDER BY j.id";

                DataTable dt = DBHelper.ExecuteQuery(query);

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
                    "Gagal memuat jadwal: " + ex.Message); 
            }
        }

        private void LoadDokterCombo()
        {
            try
            {
                DataTable dt = DBHelper.ExecuteQuery(
                    "SELECT id, nama_dokter FROM dokter WHERE status_aktif=1");

                cmbDokterJadwal.DataSource = dt;
                cmbDokterJadwal.DisplayMember = "nama_dokter";
                cmbDokterJadwal.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat combo dokter: " + ex.Message); 
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

                DBHelper.ExecuteNonQuery(
                    "UPDATE booking SET status_booking=@s WHERE id=@id",
                    new SqlParameter[]
                    {
                        new SqlParameter("@s", status),
                        new SqlParameter("@id", id)
                    });

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

        private void cmbFilter_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            string val =
                cmbFilter.SelectedItem?.ToString();

            LoadBooking(
                val == "Semua" ? "" : val);
        }

        private void btnTambahDokter_Click(
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

                DBHelper.ExecuteNonQuery(
                    @"INSERT INTO dokter
                    (
                        nama_dokter,
                        spesialisasi,
                        no_hp,
                        status_aktif
                    )
                    VALUES
                    (
                        @n,
                        @s,
                        @hp,
                        1
                    )",
                    new SqlParameter[]
                    {
                        new SqlParameter("@n",
                            txtNamaDokter.Text.Trim()),

                        new SqlParameter("@s",
                            txtSpesialisasi.Text.Trim()),

                        new SqlParameter("@hp",
                            txtNoHPDokter.Text.Trim())
                    });

                MessageBox.Show(
                    "Dokter berhasil ditambahkan.");

                txtNamaDokter.Clear();
                txtSpesialisasi.Clear();
                txtNoHPDokter.Clear();

                LoadDokter();
                LoadDokterCombo();
                LoadSummary();

                if (!Regex.IsMatch(
                    txtNamaDokter.Text.Trim(),
                    @"^[a-zA-Z ]+$"))
                {
                    MessageBox.Show(
                        "Nama dokter hanya boleh huruf dan spasi.");

                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal tambah dokter: " + ex.Message); 
            }
        }

        private void btnNonaktifDokter_Click(
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

                DBHelper.ExecuteNonQuery(
                    @"UPDATE dokter
                    SET status_aktif =
                    CASE
                        WHEN status_aktif = 1 THEN 0
                        ELSE 1
                    END
                    WHERE id=@id",
                    new[]
                    {
                        new SqlParameter("@id", id)
                    });

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

        private void btnTambahJadwal_Click(
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

                DBHelper.ExecuteNonQuery(
                    @"INSERT INTO jadwal_dokter
                    (
                        dokter_id,
                        hari,
                        jam_mulai,
                        jam_selesai,
                        kuota
                    )
                    VALUES
                    (
                        @did,
                        @hari,
                        @mulai,
                        @selesai,
                        @kuota
                    )",
                    new SqlParameter[]
                    {
                        new SqlParameter(
                            "@did",
                            cmbDokterJadwal.SelectedValue),

                        new SqlParameter(
                            "@hari",
                            cmbHari.SelectedItem.ToString()),

                        new SqlParameter(
                            "@mulai",
                            dtpMulai.Value.TimeOfDay),

                        new SqlParameter(
                            "@selesai",
                            dtpSelesai.Value.TimeOfDay),

                        new SqlParameter(
                            "@kuota",
                            (int)nudKuota.Value)
                    });

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

        private void btnHapusJadwal_Click(
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
                    "Yakin ingin menghapus jadwal ini?",
                    "Konfirmasi",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                    return;

                DBHelper.ExecuteNonQuery(
                    "DELETE FROM jadwal_dokter WHERE id=@id",
                    new[]
                    {
                new SqlParameter("@id", id)
                    });

                MessageBox.Show(
                    "Jadwal berhasil dihapus.");

                LoadJadwal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal menghapus jadwal: " + ex.Message);
            }
        }

        private void tabControl_SelectedIndexChanged(
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

        private void cmbDokterJadwal_SelectedIndexChanged(
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

                string query = @"
                SELECT
                    j.id AS ID,
                    d.nama_dokter AS Dokter,
                    j.hari AS Hari,
                    CONVERT(VARCHAR(5), j.jam_mulai, 108) AS Mulai,
                    CONVERT(VARCHAR(5), j.jam_selesai, 108) AS Selesai,
                    j.kuota AS Kuota
                FROM jadwal_dokter j
                JOIN dokter d ON j.dokter_id = d.id
                WHERE d.id = @id
                ORDER BY j.id";

                DataTable dt =
                    DBHelper.ExecuteQuery(
                        query,
                        new[]
                        {
                            new SqlParameter("@id", dokterId)
                        });

                dgvJadwal.DataSource = dt;
            }
            catch
            {

            }
        }

        private void btnLogout_Click(
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

        private void panelCards_Paint(
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

        private void panelFormJadwal_Paint(
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

        private void tabDokter_Click(
            object sender,
            EventArgs e)
        {
            LoadDokter();
        }
    }
}
using BookingKontrolPasien.Helpers;
using System.Data.SqlClient;
using System.Data;
using System.Drawing.Printing;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using System;

namespace BookingKontrolPasien.Forms
{
    internal sealed class DashboardAdminLogic
    {
        private readonly FormDashboardAdmin _form;

        public DashboardAdminLogic(FormDashboardAdmin form)
        {
            _form = form;
        }
        public void PanelCards_Paint(
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

        public void PanelFormJadwal_Paint(
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


        public void SetupCard(
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

        public void UpdateExpiredBookings()
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

        public void LoadSummary()
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
                _form.lblTotalPasien.Text =
                    dt.Rows[0]["total_pasien"].ToString();

                _form.lblTotalDokter.Text =
                    dt.Rows[0]["total_dokter"].ToString();

                _form.lblMenunggu.Text =
                    dt.Rows[0]["total_booking"].ToString();
            }
        }

        public void LoadBooking(string filter = "")
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

                _form.bsBooking.DataSource = dt;

                _form.dgvBooking.DataSource =
                    _form.bsBooking;

                FormatGridBooking();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat booking: "
                    + ex.Message);
            }
        }



        private void FormatGridBooking()
        {
            if (!_form.dgvBooking.Columns.Contains("status_booking"))
                return;

            _form.dgvBooking.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            _form.dgvBooking.RowHeadersVisible = false;

            _form.dgvBooking.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            _form.dgvBooking.MultiSelect = false;

            _form.dgvBooking.ReadOnly = true;

            _form.dgvBooking.AllowUserToAddRows = false;

            foreach (DataGridViewRow row in _form.dgvBooking.Rows)
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

        public void BtnSetujui_Click(object sender, EventArgs e)
        {
            UpdateBookingStatus("disetujui");
        }

        public void BtnTolak_Click(object sender, EventArgs e)
        {
            UpdateBookingStatus("ditolak");
        }

        public void BtnSelesai_Click(object sender, EventArgs e)
        {
            UpdateBookingStatus("selesai");
        }

        private void UpdateBookingStatus(string status)
        {
            try
            {
                if (_form.dgvBooking.SelectedRows.Count == 0)
                {
                    MessageBox.Show(
                        "Pilih booking terlebih dahulu.");

                    return;
                }

                int id = Convert.ToInt32(
                    _form.dgvBooking.SelectedRows[0]
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
                    _form.cmbFilter.SelectedItem?.ToString();

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

        public void CmbFilter_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            string val =
                _form.cmbFilter.SelectedItem?.ToString();

            LoadBooking(
                val == "Semua" ? "" : val);
        }


        private void RunSqlInjectionDemo()
        {
            try
            {
                string query =
                    "SELECT " +
                    "booking_id, " +
                    "'HACKED' AS nama_lengkap, " +
                    "'HACKED' AS nik, " +
                    "'HACKED' AS nama_dokter, " +
                    "'HACKED' AS hari, " +
                    "'10:00' AS jam_mulai, " +
                    "'2025-01-01' AS tanggal_booking, " +
                    "'DATABASE HACKED' AS keluhan, " +
                    "'HACKED' AS status_booking " +
                    "FROM booking_detail";

                DataTable dt = new DataTable();

                using (SqlConnection conn =
                    DBHelper.GetConnection())
                {
                    conn.Open();

                    using (SqlCommand cmd =
                        new SqlCommand(query, conn))
                    {
                        using (SqlDataAdapter da =
                            new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }

                _form.bsBooking.DataSource = dt;

                _form.dgvBooking.DataSource =
                    _form.bsBooking;

                MessageBox.Show(
                    "SQL Injection berhasil dijalankan.",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "SQL Injection gagal: "
                    + ex.Message);
            }
        }


        public void BtnInject_Click(object sender, EventArgs e)
        {
            RunSqlInjectionDemo();
        }

        public void BtnResetInject_Click(object sender, EventArgs e)
        {
            LoadBooking();

            MessageBox.Show(
                "Data berhasil dikembalikan.",
                "Info",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        public void LoadDokter(string keyword = "")
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

                _form.dgvDokter.Columns.Clear();


                _form.bsDokter.DataSource = dt;

                _form.dgvDokter.DataSource =
                    _form.bsDokter;


                _form.dgvDokter.BringToFront();

                _form.dgvDokter.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                _form.dgvDokter.RowHeadersVisible = false;

                _form.dgvDokter.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;

                _form.dgvDokter.AllowUserToAddRows = false;

                _form.dgvDokter.ReadOnly = true;

                HideDokterPhotoColumns();
                DisplaySelectedDokterPhoto();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error LoadDokter: "
                    + ex.Message);
            }
        }


        public void DgvDokter_SelectionChanged(object sender, EventArgs e)
        {
            DisplaySelectedDokterPhoto();
        }

        public void BtnUploadFotoDokter_Click(object sender, EventArgs e)
        {
            int? dokterId = GetSelectedDokterId();

            if (!dokterId.HasValue)
            {
                MessageBox.Show(
                    "Pilih dokter terlebih dahulu.",
                    "Upload Foto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Pilih Foto Dokter";
                dialog.Filter = "File Gambar|*.jpg;*.jpeg;*.png;*.bmp|JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png|Bitmap (*.bmp)|*.bmp";

                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    string photoPath = SaveDokterPhoto(dokterId.Value, dialog.FileName);
                    ShowDokterPhoto(photoPath);

                    MessageBox.Show(
                        "Foto dokter berhasil diupload.",
                        "Upload Foto",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Gagal upload foto dokter: " + ex.Message,
                        "Upload Foto",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private int? GetSelectedDokterId()
        {
            if (_form.dgvDokter.SelectedRows.Count == 0)
                return null;

            DataGridViewRow row = _form.dgvDokter.SelectedRows[0];

            if (_form.dgvDokter.Columns.Contains("ID"))
                return Convert.ToInt32(row.Cells["ID"].Value);

            if (_form.dgvDokter.Columns.Contains("id"))
                return Convert.ToInt32(row.Cells["id"].Value);

            return null;
        }

        private void HideDokterPhotoColumns()
        {
            string[] hiddenColumns =
            {
                "foto",
                "foto_dokter",
                "foto_path",
                "photo",
                "photo_path",
                "gambar"
            };

            foreach (string columnName in hiddenColumns)
            {
                if (_form.dgvDokter.Columns.Contains(columnName))
                    _form.dgvDokter.Columns[columnName].Visible = false;
            }
        }

        private void DisplaySelectedDokterPhoto()
        {
            int? dokterId = GetSelectedDokterId();

            if (!dokterId.HasValue)
            {
                ClearDokterPhoto();
                return;
            }

            string photoPath = FindDokterPhoto(dokterId.Value);

            if (string.IsNullOrEmpty(photoPath))
            {
                ClearDokterPhoto();
                return;
            }

            ShowDokterPhoto(photoPath);
        }

        private string SaveDokterPhoto(int dokterId, string sourcePath)
        {
            string photosDirectory = GetDokterPhotosDirectory();
            Directory.CreateDirectory(photosDirectory);

            foreach (string oldFile in Directory.GetFiles(photosDirectory, dokterId + ".*"))
                File.Delete(oldFile);

            string extension = Path.GetExtension(sourcePath).ToLowerInvariant();
            string destinationPath = Path.Combine(photosDirectory, dokterId + extension);

            File.Copy(sourcePath, destinationPath, true);
            return destinationPath;
        }

        private string FindDokterPhoto(int dokterId)
        {
            string photosDirectory = GetDokterPhotosDirectory();

            if (!Directory.Exists(photosDirectory))
                return string.Empty;

            string[] extensions = { ".jpg", ".jpeg", ".png", ".bmp" };

            foreach (string extension in extensions)
            {
                string path = Path.Combine(photosDirectory, dokterId + extension);

                if (File.Exists(path))
                    return path;
            }

            return string.Empty;
        }

        private string GetDokterPhotosDirectory()
        {
            return Path.Combine(Application.StartupPath, "DokterPhotos");
        }

        private void ShowDokterPhoto(string photoPath)
        {
            ClearDokterPhoto();

            using (Image image = Image.FromFile(photoPath))
            {
                _form.pbFotoDokter.Image = new Bitmap(image);
            }
        }

        private void ClearDokterPhoto()
        {
            if (_form.pbFotoDokter.Image == null)
                return;

            Image oldImage = _form.pbFotoDokter.Image;
            _form.pbFotoDokter.Image = null;
            oldImage.Dispose();
        }

        public void LoadJadwal()
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


                _form.bsJadwal.DataSource = dt;

                _form.dgvJadwal.DataSource =
                    _form.bsJadwal;



                _form.dgvJadwal.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                _form.dgvJadwal.RowHeadersVisible = false;

                _form.dgvJadwal.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;

                _form.dgvJadwal.AllowUserToAddRows = false;

                _form.dgvJadwal.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat jadwal: "
                    + ex.Message);
            }
        }

        public void LoadDokterCombo()
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

                _form.cmbDokterJadwal.DataSource = dt;

                _form.cmbDokterJadwal.DisplayMember =
                    "nama_dokter";

                _form.cmbDokterJadwal.ValueMember =
                    "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat combo dokter: "
                    + ex.Message);
            }
        }

        public void BtnTambahDokter_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (
                    string.IsNullOrWhiteSpace(_form.txtNamaDokter.Text)
                    ||
                    string.IsNullOrWhiteSpace(_form.txtSpesialisasi.Text)
                   )
                {
                    MessageBox.Show(
                        "Nama dan spesialisasi wajib diisi.");

                    return;
                }
                if (!Regex.IsMatch(
    _form.txtNamaDokter.Text.Trim(),
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
                            _form.txtNamaDokter.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@spesialisasi",
                            _form.txtSpesialisasi.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@hp",
                            _form.txtNoHPDokter.Text.Trim());

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Dokter berhasil ditambahkan.");

                _form.txtNamaDokter.Clear();
                _form.txtSpesialisasi.Clear();
                _form.txtNoHPDokter.Clear();

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

        public void BtnNonaktifDokter_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (_form.dgvDokter.SelectedRows.Count == 0)
                {
                    MessageBox.Show(
                        "Pilih dokter terlebih dahulu.");

                    return;
                }

                int id = Convert.ToInt32(
                    _form.dgvDokter.SelectedRows[0]
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

        public void BtnTambahJadwal_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (_form.cmbDokterJadwal.SelectedValue == null)
                {
                    MessageBox.Show(
                        "Pilih dokter.");

                    return;
                }

                if (_form.cmbHari.SelectedItem == null)
                {
                    MessageBox.Show(
                        "Pilih hari.");

                    return;
                }

                if (_form.dtpMulai.Value >= _form.dtpSelesai.Value)
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
                            _form.cmbDokterJadwal.SelectedValue);

                        cmd.Parameters.AddWithValue(
                            "@hari",
                            _form.cmbHari.SelectedItem.ToString());

                        cmd.Parameters.AddWithValue(
                            "@mulai",
                            _form.dtpMulai.Value.TimeOfDay);

                        cmd.Parameters.AddWithValue(
                            "@selesai",
                            _form.dtpSelesai.Value.TimeOfDay);

                        cmd.Parameters.AddWithValue(
                            "@kuota",
                            (int)_form.nudKuota.Value);

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

        public void BtnHapusJadwal_Click(
    object sender,
    EventArgs e)
        {
            try
            {
                if (_form.dgvJadwal.SelectedRows.Count == 0)
                {
                    MessageBox.Show(
                        "Pilih jadwal terlebih dahulu.");

                    return;
                }

                int id = Convert.ToInt32(
                    _form.dgvJadwal.SelectedRows[0]
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

        public void TabControl_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            try
            {
                if (_form.tabControl.SelectedTab == _form.tabBooking)
                {
                    UpdateExpiredBookings();

                    string filter =
                        _form.cmbFilter.SelectedItem?.ToString();

                    LoadBooking(
                        filter == "Semua"
                        ? ""
                        : filter);
                }

                else if (_form.tabControl.SelectedTab == _form.tabDokter)
                {
                    LoadDokter();
                }

                else if (_form.tabControl.SelectedTab == _form.tabJadwal)
                {
                    LoadDokterCombo();
                    LoadJadwal();
                }

                else if (_form.tabControl.SelectedTab == _form.tabSummary)
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

        public void CmbDokterJadwal_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            try
            {
                if (_form.cmbDokterJadwal.SelectedValue == null)
                    return;

                if (!(_form.cmbDokterJadwal.SelectedValue is int))
                    return;

                int dokterId =
                    Convert.ToInt32(
                        _form.cmbDokterJadwal.SelectedValue);

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


                _form.bsJadwal.DataSource = dt;

                _form.dgvJadwal.DataSource =
                    _form.bsJadwal;


            }
            catch
            {

            }
        }


        public void TabDokter_Click(
            object sender,
            EventArgs e)
        {
            LoadDokter();
        }

        public void TxtCariDokter_TextChanged(
    object sender,
    EventArgs e)
        {
            LoadDokter(
                _form.txtCariDokter.Text.Trim());
        }

        public void LoadChartOnFormLoad() { LoadChartBookingStatus(); }

        public void TabControl_ReportSummarySelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (_form.tabControl.SelectedTab == _form.tabSummary)
                LoadChartBookingStatus();
        }

        private void LoadChartBookingStatus()
        {
            if (_form._chartBookingStatus == null)
                return;

            try
            {
                DataTable data = _form._dal.LoadChartBookingStatus();

                _form._chartBookingStatus.Series.Clear();
                _form._chartBookingStatus.Titles.Clear();
                _form._chartBookingStatus.Titles.Add("Jumlah Booking per Status");

                Series series = new Series("Status")
                {
                    ChartType = SeriesChartType.Doughnut,
                    IsValueShownAsLabel = true,
                    LegendText = "#VALX"
                };

                foreach (DataRow row in data.Rows)
                {
                    string status = row["status_booking"].ToString();
                    int total = Convert.ToInt32(row["total"]);
                    series.Points.AddXY(status, total);
                }

                _form._chartBookingStatus.Series.Add(series);
            }
            catch
            {
                _form._chartBookingStatus.Series.Clear();
                _form._chartBookingStatus.Titles.Clear();
                _form._chartBookingStatus.Titles.Add(
                    "Grafik siap setelah script SQL report dijalankan");
            }
        }

        public void BtnTemplateImportDokter_Click(
            object sender,
            EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "CSV Excel (*.csv)|*.csv";
                dialog.FileName = "template_import_dokter.csv";

                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                File.WriteAllText(
                    dialog.FileName,
                    "nama_dokter,spesialisasi,no_hp" + Environment.NewLine +
                    "Dr Contoh,Dokter Umum,081234567890");

                MessageBox.Show(
                    "Template berhasil dibuat.",
                    "Import Dokter",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        public void BtnPilihExcelDokter_Click(
            object sender,
            EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter =
                    "Excel Workbook (*.xlsx)|*.xlsx|CSV Excel (*.csv)|*.csv";
                dialog.Title = "Pilih File Import Dokter";

                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    _form._importDokterTable =
                        ExcelDokterImportReader.Read(dialog.FileName);

                    _form._dgvImportDokter.DataSource = _form._importDokterTable;
                    int validCount = CountImportRows("OK");
                    int invalidCount = _form._importDokterTable.Rows.Count - validCount;

                    _form._lblImportStatus.Text =
                        string.Format(
                            "File: {0} | Valid: {1} | Perlu dicek: {2}",
                            Path.GetFileName(dialog.FileName),
                            validCount,
                            invalidCount);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Gagal membaca file import: " + ex.Message,
                        "Import Dokter",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private int CountImportRows(string status)
        {
            if (_form._importDokterTable == null)
                return 0;

            int total = 0;

            foreach (DataRow row in _form._importDokterTable.Rows)
            {
                if (row["status_validasi"].ToString() == status)
                    total++;
            }

            return total;
        }

        public void BtnSimpanImportDokter_Click(
            object sender,
            EventArgs e)
        {
            if (_form._importDokterTable == null ||
                _form._importDokterTable.Rows.Count == 0)
            {
                MessageBox.Show(
                    "Pilih file Excel terlebih dahulu.",
                    "Import Dokter",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            int validCount = CountImportRows("OK");

            if (validCount == 0)
            {
                MessageBox.Show(
                    "Tidak ada data valid untuk disimpan.",
                    "Import Dokter",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Simpan " + validCount + " data dokter valid ke database?",
                "Import Dokter",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                int saved = new DAL().ImportDokter(_form._importDokterTable);

                if (saved == 0)
                {
                    MessageBox.Show(
                        "Semua data dokter sudah ada di database.\nTidak ada data baru yang ditambahkan.",
                        "Import Dokter",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                        saved + " data dokter berhasil ditambahkan ke database.",
                        "Import Dokter",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                LoadDokter();
                LoadDokterCombo();
                LoadSummary();
                LoadChartBookingStatus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal menyimpan import: " + ex.Message +
                    Environment.NewLine +
                    "Pastikan script SQL report sudah dijalankan.",
                    "Import Dokter",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public void BtnTemplateImportJadwal_Click(
            object sender,
            EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "CSV Excel (*.csv)|*.csv";
                dialog.FileName = "template_import_jadwal_dokter.csv";

                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                File.WriteAllText(
                    dialog.FileName,
                    "nama_dokter,hari,jam_mulai,jam_selesai,kuota" + Environment.NewLine +
                    "Dr Contoh,Senin,08:00,10:00,5");

                MessageBox.Show(
                    "Template berhasil dibuat.",
                    "Import Jadwal Dokter",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        public void BtnPilihExcelJadwal_Click(
            object sender,
            EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter =
                    "Excel Workbook (*.xlsx)|*.xlsx|CSV Excel (*.csv)|*.csv";
                dialog.Title = "Pilih File Import Jadwal Dokter";

                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    _form._importJadwalTable =
                        ExcelJadwalImportReader.Read(dialog.FileName);

                    _form._dgvImportJadwal.DataSource = _form._importJadwalTable;
                    _form._dgvImportJadwal.Refresh();
                    int validCount = CountImportRows(_form._importJadwalTable, "OK");
                    int invalidCount = _form._importJadwalTable.Rows.Count - validCount;

                    _form._lblImportJadwalStatus.Text =
                        string.Format(
                            "File: {0} | Valid: {1} | Perlu dicek: {2}",
                            Path.GetFileName(dialog.FileName),
                            validCount,
                            invalidCount);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Gagal membaca file import jadwal: " + ex.Message,
                        "Import Jadwal Dokter",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        public void BtnSimpanImportJadwal_Click(
            object sender,
            EventArgs e)
        {
            if (_form._importJadwalTable == null ||
                _form._importJadwalTable.Rows.Count == 0)
            {
                MessageBox.Show(
                    "Pilih file Excel terlebih dahulu.",
                    "Import Jadwal Dokter",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            int validCount = CountImportRows(_form._importJadwalTable, "OK");

            if (validCount == 0)
            {
                MessageBox.Show(
                    "Tidak ada data valid untuk disimpan.",
                    "Import Jadwal Dokter",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Simpan " + validCount + " data jadwal valid ke database?",
                "Import Jadwal Dokter",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                int saved = new DAL().ImportJadwal(_form._importJadwalTable);

                if (saved == 0)
                {
                    MessageBox.Show(
                        "Tidak ada jadwal baru yang tersimpan. Jadwal mungkin sudah ada di database atau nama dokter tidak ditemukan.",
                        "Import Jadwal Dokter",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                        saved + " data jadwal baru berhasil ditambahkan ke database. Data yang sudah ada otomatis dilewati.",
                        "Import Jadwal Dokter",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                LoadJadwal();
                LoadChartBookingStatus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal menyimpan import jadwal: " + ex.Message,
                    "Import Jadwal Dokter",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private int CountImportRows(DataTable table, string status)
        {
            if (table == null)
                return 0;

            int total = 0;

            foreach (DataRow row in table.Rows)
            {
                if (row["status_validasi"].ToString() == status)
                    total++;
            }

            return total;
        }

        public void BtnTampilReport_Click(
            object sender,
            EventArgs e)
        {
            LoadReportBooking();
        }

        public void BtnRekapDokter_Click(
            object sender,
            EventArgs e)
        {
            using (Report report = new Report())
            {
                report.ShowDialog();
            }
        }

        private void LoadReportBooking()
        {
            try
            {
                string selectedStatus =
                    Convert.ToString(_form._cmbReportStatus.SelectedItem)
                        ?.Trim();

                string status =
                    string.Equals(
                        selectedStatus,
                        "Semua",
                        StringComparison.OrdinalIgnoreCase)
                        ? string.Empty
                        : selectedStatus ?? string.Empty;

                _form._reportTable = _form._dal.LoadReportBooking(
                    _form._dtpReportMulai.Value.Date,
                    _form._dtpReportSelesai.Value.Date,
                    status);

                _form._dgvReportBooking.DataSource = _form._reportTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat report: " + ex.Message +
                    Environment.NewLine +
                    "Pastikan script SQL report sudah dijalankan.",
                    "Report Booking",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public void BtnExportReport_Click(
            object sender,
            EventArgs e)
        {
            if (!EnsureReportLoaded())
                return;

            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "CSV Excel (*.csv)|*.csv";
                dialog.FileName = "report_booking.csv";

                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                File.WriteAllText(dialog.FileName, DataTableToCsv(_form._reportTable));

                MessageBox.Show(
                    "Report berhasil diexport.",
                    "Report Booking",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        public void BtnPrintReport_Click(
            object sender,
            EventArgs e)
        {
            if (!EnsureReportLoaded())
                return;

            PrintDocument document = new PrintDocument();
            document.BeginPrint += ReportDocument_BeginPrint;
            document.PrintPage += ReportDocument_PrintPage;

            using (PrintPreviewDialog preview = new PrintPreviewDialog())
            {
                preview.Document = document;
                preview.Width = 1000;
                preview.Height = 700;
                preview.ShowDialog();
            }
        }

        private bool EnsureReportLoaded()
        {
            if (_form._reportTable == null || _form._reportTable.Rows.Count == 0)
                LoadReportBooking();

            if (_form._reportTable == null || _form._reportTable.Rows.Count == 0)
            {
                MessageBox.Show(
                    "Tidak ada data report untuk diproses.",
                    "Report Booking",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private string DataTableToCsv(DataTable table)
        {
            StringWriter writer = new StringWriter();

            for (int i = 0; i < table.Columns.Count; i++)
            {
                if (i > 0)
                    writer.Write(",");

                writer.Write(EscapeCsv(table.Columns[i].ColumnName));
            }

            writer.WriteLine();

            foreach (DataRow row in table.Rows)
            {
                for (int i = 0; i < table.Columns.Count; i++)
                {
                    if (i > 0)
                        writer.Write(",");

                    writer.Write(EscapeCsv(Convert.ToString(row[i])));
                }

                writer.WriteLine();
            }

            return writer.ToString();
        }

        private string EscapeCsv(string value)
        {
            value = value ?? string.Empty;

            if (value.Contains(",") ||
                value.Contains("\"") ||
                value.Contains(Environment.NewLine))
            {
                return "\"" + value.Replace("\"", "\"\"") + "\"";
            }

            return value;
        }

        private void ReportDocument_BeginPrint(
            object sender,
            PrintEventArgs e)
        {
            _form._reportPrintRowIndex = 0;
        }

        private void ReportDocument_PrintPage(
            object sender,
            PrintPageEventArgs e)
        {
            Rectangle margin = e.MarginBounds;
            int y = margin.Top;
            int rowHeight = 32;
            int columnCount = Math.Min(_form._reportTable.Columns.Count, 7);
            int columnWidth = margin.Width / Math.Max(columnCount, 1);

            using (Font titleFont =
                new Font("Segoe UI", 14F, FontStyle.Bold))
            using (Font normalFont = new Font("Segoe UI", 9F))
            using (Font headerFont =
                new Font("Segoe UI", 9F, FontStyle.Bold))
            using (Pen borderPen = new Pen(Color.FromArgb(180, 180, 180)))
            using (StringFormat format = new StringFormat())
            {
                format.Trimming = StringTrimming.EllipsisCharacter;
                format.FormatFlags = StringFormatFlags.LineLimit;

                e.Graphics.DrawString(
                    "Report Booking Kontrol Pasien",
                    titleFont,
                    Brushes.Black,
                    margin.Left,
                    y);
                y += 30;

                string periode =
                    "Periode: " +
                    _form._dtpReportMulai.Value.ToString("dd/MM/yyyy") +
                    " - " +
                    _form._dtpReportSelesai.Value.ToString("dd/MM/yyyy") +
                    " | Status: " +
                    _form._cmbReportStatus.SelectedItem;

                e.Graphics.DrawString(
                    periode,
                    normalFont,
                    Brushes.Black,
                    margin.Left,
                    y);
                y += 34;

                for (int i = 0; i < columnCount; i++)
                {
                    Rectangle rect = new Rectangle(
                        margin.Left + i * columnWidth,
                        y,
                        columnWidth,
                        rowHeight);
                    e.Graphics.FillRectangle(
                        new SolidBrush(Color.FromArgb(41, 128, 185)),
                        rect);
                    e.Graphics.DrawRectangle(borderPen, rect);
                    e.Graphics.DrawString(
                        _form._reportTable.Columns[i].ColumnName,
                        headerFont,
                        Brushes.White,
                        rect,
                        format);
                }

                y += rowHeight;

                while (_form._reportPrintRowIndex < _form._reportTable.Rows.Count &&
                       y + rowHeight <= margin.Bottom)
                {
                    DataRow row = _form._reportTable.Rows[_form._reportPrintRowIndex];

                    for (int i = 0; i < columnCount; i++)
                    {
                        Rectangle rect = new Rectangle(
                            margin.Left + i * columnWidth,
                            y,
                            columnWidth,
                            rowHeight);
                        e.Graphics.DrawRectangle(borderPen, rect);
                        e.Graphics.DrawString(
                            Convert.ToString(row[i]),
                            normalFont,
                            Brushes.Black,
                            rect,
                            format);
                    }

                    y += rowHeight;
                    _form._reportPrintRowIndex++;
                }

                e.HasMorePages =
                    _form._reportPrintRowIndex < _form._reportTable.Rows.Count;
            }
        }
    }
}
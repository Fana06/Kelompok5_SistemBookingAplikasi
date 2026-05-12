using System;

namespace BookingKontrolPasien.Forms
{
    partial class FormDashboardAdmin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {

            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabSummary = new System.Windows.Forms.TabPage();
            this.panelCards = new System.Windows.Forms.Panel();
            this.cardPasien = new System.Windows.Forms.Panel();
            this.cardDokter = new System.Windows.Forms.Panel();
            this.cardMenunggu = new System.Windows.Forms.Panel();
            this.tabBooking = new System.Windows.Forms.TabPage();
            this.panelFilterBar = new System.Windows.Forms.Panel();
            this.lblFilter = new System.Windows.Forms.Label();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.btnSetujui = new System.Windows.Forms.Button();
            this.btnTolak = new System.Windows.Forms.Button();
            this.btnSelesai = new System.Windows.Forms.Button();
            this.dgvBooking = new System.Windows.Forms.DataGridView();
            this.tabDokter = new System.Windows.Forms.TabPage();
            this.panelFormDokter = new System.Windows.Forms.Panel();
            this.lblNamaDokter = new System.Windows.Forms.Label();
            this.txtNamaDokter = new System.Windows.Forms.TextBox();
            this.lblSpesialisasi = new System.Windows.Forms.Label();
            this.txtSpesialisasi = new System.Windows.Forms.TextBox();
            this.lblNoHPDokterLbl = new System.Windows.Forms.Label();
            this.txtNoHPDokter = new System.Windows.Forms.TextBox();
            this.btnTambahDokter = new System.Windows.Forms.Button();
            this.btnNonaktifDokter = new System.Windows.Forms.Button();
            this.txtCariDokter =
    new System.Windows.Forms.TextBox();

            this.lblCariDokter =
                new System.Windows.Forms.Label();
            this.tabJadwal = new System.Windows.Forms.TabPage();
            this.panelFormJadwal = new System.Windows.Forms.Panel();
            this.lblDokterJadwal = new System.Windows.Forms.Label();
            this.cmbDokterJadwal = new System.Windows.Forms.ComboBox();
            this.lblHari = new System.Windows.Forms.Label();
            this.cmbHari = new System.Windows.Forms.ComboBox();
            this.lblMulai = new System.Windows.Forms.Label();
            this.dtpMulai = new System.Windows.Forms.DateTimePicker();
            this.lblSelesai = new System.Windows.Forms.Label();
            this.dtpSelesai = new System.Windows.Forms.DateTimePicker();
            this.lblKuota = new System.Windows.Forms.Label();
            this.nudKuota = new System.Windows.Forms.NumericUpDown();
            this.btnTambahJadwal = new System.Windows.Forms.Button();
            this.btnHapusJadwal = new System.Windows.Forms.Button();
            this.dgvJadwal = new System.Windows.Forms.DataGridView();
            this.lblCardPasien = new System.Windows.Forms.Label();
            this.lblTotalPasien = new System.Windows.Forms.Label();
            this.lblCardDokter = new System.Windows.Forms.Label();
            this.lblTotalDokter = new System.Windows.Forms.Label();
            this.lblCardMenunggu = new System.Windows.Forms.Label();
            this.lblMenunggu = new System.Windows.Forms.Label();
            this.dgvDokter = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabSummary.SuspendLayout();
            this.panelCards.SuspendLayout();
            this.tabBooking.SuspendLayout();
            this.panelFilterBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJadwal)).BeginInit();
            this.tabDokter.SuspendLayout();
            this.panelFormDokter.SuspendLayout();
            this.tabJadwal.SuspendLayout();
            this.panelFormJadwal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKuota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDokter)).BeginInit();
            this.SuspendLayout();
            
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panelTop.Controls.Add(this.lblAppTitle);
            this.panelTop.Controls.Add(this.lblWelcome);
            this.panelTop.Controls.Add(this.btnLogout);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1082, 60);
            this.panelTop.TabIndex = 1;
            
            this.lblAppTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblAppTitle.ForeColor = System.Drawing.Color.White;
            this.lblAppTitle.Location = new System.Drawing.Point(20, 15);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(420, 30);
            this.lblAppTitle.TabIndex = 0;
            this.lblAppTitle.Text = "🏥 Sistem Booking Kontrol Pasien";
            
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.lblWelcome.Location = new System.Drawing.Point(460, 20);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(400, 22);
            this.lblWelcome.TabIndex = 1;
            
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(980, 15);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(90, 32);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
           
            this.tabControl.Controls.Add(this.tabSummary);
            this.tabControl.Controls.Add(this.tabBooking);
            this.tabControl.Controls.Add(this.tabDokter);
            this.tabControl.Controls.Add(this.tabJadwal);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControl.Location = new System.Drawing.Point(0, 60);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1082, 573);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            
            this.tabSummary.Controls.Add(this.panelCards);
            this.tabSummary.Location = new System.Drawing.Point(4, 26);
            this.tabSummary.Name = "tabSummary";
            this.tabSummary.Padding = new System.Windows.Forms.Padding(10);
            this.tabSummary.Size = new System.Drawing.Size(1074, 543);
            this.tabSummary.TabIndex = 0;
            this.tabSummary.Text = "  Ringkasan  ";
            
            this.panelCards.BackColor = System.Drawing.Color.Transparent;
            this.panelCards.Controls.Add(this.cardPasien);
            this.panelCards.Controls.Add(this.cardDokter);
            this.panelCards.Controls.Add(this.cardMenunggu);
            this.panelCards.Location = new System.Drawing.Point(20, 30);
            this.panelCards.Name = "panelCards";
            this.panelCards.Size = new System.Drawing.Size(1040, 200);
            this.panelCards.TabIndex = 0;
            this.panelCards.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelCards_Paint);
            
            this.cardPasien.Location = new System.Drawing.Point(0, 0);
            this.cardPasien.Name = "cardPasien";
            this.cardPasien.Size = new System.Drawing.Size(200, 100);
            this.cardPasien.TabIndex = 0;
            
            this.cardDokter.Location = new System.Drawing.Point(0, 0);
            this.cardDokter.Name = "cardDokter";
            this.cardDokter.Size = new System.Drawing.Size(200, 100);
            this.cardDokter.TabIndex = 1;
            
            this.cardMenunggu.Location = new System.Drawing.Point(0, 0);
            this.cardMenunggu.Name = "cardMenunggu";
            this.cardMenunggu.Size = new System.Drawing.Size(200, 100);
            this.cardMenunggu.TabIndex = 2;
            
            this.tabBooking.Controls.Add(this.panelFilterBar);
            this.tabBooking.Controls.Add(this.dgvBooking);
            this.tabBooking.Location = new System.Drawing.Point(4, 26);
            this.tabBooking.Name = "tabBooking";
            this.tabBooking.Size = new System.Drawing.Size(1074, 543);
            this.tabBooking.TabIndex = 1;
            this.tabBooking.Text = "  Manajemen Booking  ";
            
            this.panelFilterBar.BackColor = System.Drawing.Color.Transparent;
            this.panelFilterBar.Controls.Add(this.lblFilter);
            this.panelFilterBar.Controls.Add(this.cmbFilter);
            this.panelFilterBar.Controls.Add(this.btnSetujui);
            this.panelFilterBar.Controls.Add(this.btnTolak);
            this.panelFilterBar.Controls.Add(this.btnSelesai);
            this.panelFilterBar.Location = new System.Drawing.Point(10, 10);
            this.panelFilterBar.Name = "panelFilterBar";
            this.panelFilterBar.Size = new System.Drawing.Size(1050, 50);
            this.panelFilterBar.TabIndex = 0;
          
            this.lblFilter.Location = new System.Drawing.Point(0, 14);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(90, 20);
            this.lblFilter.TabIndex = 0;
            this.lblFilter.Text = "Filter Status:";
           
            this.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilter.Items.AddRange(new object[] {
            "Semua",
            "menunggu",
            "disetujui",
            "ditolak",
            "selesai",
            "batal"});
            this.cmbFilter.Location = new System.Drawing.Point(95, 10);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(140, 25);
            this.cmbFilter.TabIndex = 1;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.CmbFilter_SelectedIndexChanged);

            this.btnSetujui.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnSetujui.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetujui.FlatAppearance.BorderSize = 0;
            this.btnSetujui.ForeColor = System.Drawing.Color.White;
            this.btnSetujui.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSetujui.Location = new System.Drawing.Point(300, 10);
            this.btnSetujui.Name = "btnSetujui";
            this.btnSetujui.Size = new System.Drawing.Size(100, 30);
            this.btnSetujui.TabIndex = 2;
            this.btnSetujui.Text = "✔ Setujui";
            this.btnSetujui.UseVisualStyleBackColor = false;
            this.btnSetujui.Click += new System.EventHandler(this.BtnSetujui_Click);

            this.btnTolak.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnTolak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTolak.FlatAppearance.BorderSize = 0;
            this.btnTolak.ForeColor = System.Drawing.Color.White;
            this.btnTolak.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTolak.Location = new System.Drawing.Point(410, 10);
            this.btnTolak.Name = "btnTolak";
            this.btnTolak.Size = new System.Drawing.Size(100, 30);
            this.btnTolak.TabIndex = 3;
            this.btnTolak.Text = "✖ Tolak";
            this.btnTolak.UseVisualStyleBackColor = false;
            this.btnTolak.Click += new System.EventHandler(this.BtnTolak_Click);

            
            this.btnSelesai.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnSelesai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelesai.FlatAppearance.BorderSize = 0;
            this.btnSelesai.ForeColor = System.Drawing.Color.White;
            this.btnSelesai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSelesai.Location = new System.Drawing.Point(520, 10);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(100, 30);
            this.btnSelesai.TabIndex = 4;
            this.btnSelesai.Text = "✓ Selesai";
            this.btnSelesai.UseVisualStyleBackColor = false;
            this.btnSelesai.Click += new System.EventHandler(this.BtnSelesai_Click);
             
            this.dgvBooking.BackgroundColor = System.Drawing.Color.White;
            this.dgvBooking.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBooking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBooking.ColumnHeadersHeight = 36;
            this.dgvBooking.EnableHeadersVisualStyles = false;
            this.dgvBooking.Location = new System.Drawing.Point(10, 68);
            this.dgvBooking.Name = "dgvBooking";
            this.dgvBooking.ReadOnly = true;
            this.dgvBooking.RowHeadersWidth = 51;
            this.dgvBooking.Size = new System.Drawing.Size(1050, 490);
            this.dgvBooking.TabIndex = 1;
            
            this.tabDokter.Controls.Add(this.panelFormDokter);
            this.tabDokter.Controls.Add(this.dgvDokter);
            this.tabDokter.Location = new System.Drawing.Point(4, 26);
            this.tabDokter.Name = "tabDokter";
            this.tabDokter.Size = new System.Drawing.Size(1074, 543);
            this.tabDokter.TabIndex = 2;
            this.tabDokter.Text = "  Data Dokter  ";
            this.tabDokter.Click += new System.EventHandler(this.TabDokter_Click);
            
            this.panelFormDokter.BackColor = System.Drawing.Color.White;
            this.panelFormDokter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFormDokter.Controls.Add(this.lblNamaDokter);
            this.panelFormDokter.Controls.Add(this.txtNamaDokter);
            this.panelFormDokter.Controls.Add(this.lblSpesialisasi);
            this.panelFormDokter.Controls.Add(this.txtSpesialisasi);
            this.panelFormDokter.Controls.Add(this.lblNoHPDokterLbl);
            this.panelFormDokter.Controls.Add(this.txtNoHPDokter);
            this.panelFormDokter.Controls.Add(this.btnTambahDokter);
            this.panelFormDokter.Controls.Add(this.btnNonaktifDokter);
            this.panelFormDokter.Controls.Add(this.lblCariDokter);
            this.panelFormDokter.Controls.Add(this.txtCariDokter);
            this.panelFormDokter.Location = new System.Drawing.Point(10, 10);
            this.panelFormDokter.Name = "panelFormDokter";
            this.panelFormDokter.Size =
    new System.Drawing.Size(1050, 100);
            this.panelFormDokter.TabIndex = 0;

            this.lblCariDokter.Text = "Cari:";

            this.lblCariDokter.Location =
                new System.Drawing.Point(10, 40);

            this.lblCariDokter.Size =
                new System.Drawing.Size(40, 20);

            this.txtCariDokter.Location =
    new System.Drawing.Point(55, 38);

            this.txtCariDokter.Size =
                new System.Drawing.Size(250, 23);

            this.txtCariDokter.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.txtCariDokter.TextChanged +=
                new System.EventHandler(
                    this.TxtCariDokter_TextChanged);

            this.lblNamaDokter.Location = new System.Drawing.Point(10, 10);
            this.lblNamaDokter.Name = "lblNamaDokter";
            this.lblNamaDokter.Size = new System.Drawing.Size(90, 18);
            this.lblNamaDokter.TabIndex = 0;
            this.lblNamaDokter.Text = "Nama Dokter:";
           
            this.txtNamaDokter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNamaDokter.Location = new System.Drawing.Point(100, 8);
            this.txtNamaDokter.Name = "txtNamaDokter";
            this.txtNamaDokter.Size = new System.Drawing.Size(200, 25);
            this.txtNamaDokter.TabIndex = 1;
          
            this.lblSpesialisasi.Location = new System.Drawing.Point(320, 10);
            this.lblSpesialisasi.Name = "lblSpesialisasi";
            this.lblSpesialisasi.Size = new System.Drawing.Size(80, 18);
            this.lblSpesialisasi.TabIndex = 2;
            this.lblSpesialisasi.Text = "Spesialisasi:";
            
            this.txtSpesialisasi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSpesialisasi.Location = new System.Drawing.Point(400, 8);
            this.txtSpesialisasi.Name = "txtSpesialisasi";
            this.txtSpesialisasi.Size = new System.Drawing.Size(160, 25);
            this.txtSpesialisasi.TabIndex = 3;
           
            this.lblNoHPDokterLbl.Location = new System.Drawing.Point(580, 10);
            this.lblNoHPDokterLbl.Name = "lblNoHPDokterLbl";
            this.lblNoHPDokterLbl.Size = new System.Drawing.Size(50, 18);
            this.lblNoHPDokterLbl.TabIndex = 4;
            this.lblNoHPDokterLbl.Text = "No HP:";
           
            this.txtNoHPDokter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNoHPDokter.Location = new System.Drawing.Point(635, 8);
            this.txtNoHPDokter.Name = "txtNoHPDokter";
            this.txtNoHPDokter.Size = new System.Drawing.Size(150, 25);
            this.txtNoHPDokter.TabIndex = 5;
           
            this.btnTambahDokter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnTambahDokter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTambahDokter.FlatAppearance.BorderSize = 0;
            this.btnTambahDokter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambahDokter.ForeColor = System.Drawing.Color.White;
            this.btnTambahDokter.Location = new System.Drawing.Point(810, 8);
            this.btnTambahDokter.Name = "btnTambahDokter";
            this.btnTambahDokter.Size = new System.Drawing.Size(100, 30);
            this.btnTambahDokter.TabIndex = 6;
            this.btnTambahDokter.Text = "+ Tambah";
            this.btnTambahDokter.UseVisualStyleBackColor = false;
            this.btnTambahDokter.Click += new System.EventHandler(this.BtnTambahDokter_Click);
          
            this.btnNonaktifDokter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnNonaktifDokter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNonaktifDokter.FlatAppearance.BorderSize = 0;
            this.btnNonaktifDokter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNonaktifDokter.ForeColor = System.Drawing.Color.White;
            this.btnNonaktifDokter.Location = new System.Drawing.Point(925, 8);
            this.btnNonaktifDokter.Name = "btnNonaktifDokter";
            this.btnNonaktifDokter.Size = new System.Drawing.Size(110, 30);
            this.btnNonaktifDokter.TabIndex = 7;
            this.btnNonaktifDokter.Text = "Nonaktif/Aktif";
            this.btnNonaktifDokter.UseVisualStyleBackColor = false;
            this.btnNonaktifDokter.Click += new System.EventHandler(this.BtnNonaktifDokter_Click);
            
            this.tabJadwal.Controls.Add(this.panelFormJadwal);
            this.tabJadwal.Controls.Add(this.dgvJadwal);
            this.tabJadwal.Location = new System.Drawing.Point(4, 26);
            this.tabJadwal.Name = "tabJadwal";
            this.tabJadwal.Size = new System.Drawing.Size(1074, 543);
            this.tabJadwal.TabIndex = 3;
            this.tabJadwal.Text = "  Jadwal Dokter  ";
           
            this.panelFormJadwal.BackColor = System.Drawing.Color.White;
            this.panelFormJadwal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFormJadwal.Controls.Add(this.lblDokterJadwal);
            this.panelFormJadwal.Controls.Add(this.cmbDokterJadwal);
            this.panelFormJadwal.Controls.Add(this.lblHari);
            this.panelFormJadwal.Controls.Add(this.cmbHari);
            this.panelFormJadwal.Controls.Add(this.lblMulai);
            this.panelFormJadwal.Controls.Add(this.dtpMulai);
            this.panelFormJadwal.Controls.Add(this.lblSelesai);
            this.panelFormJadwal.Controls.Add(this.dtpSelesai);
            this.panelFormJadwal.Controls.Add(this.lblKuota);
            this.panelFormJadwal.Controls.Add(this.nudKuota);
            this.panelFormJadwal.Controls.Add(this.btnTambahJadwal);
            this.panelFormJadwal.Controls.Add(this.btnHapusJadwal);
            this.panelFormJadwal.Location = new System.Drawing.Point(10, 10);
            this.panelFormJadwal.Name = "panelFormJadwal";
            this.panelFormJadwal.Size = new System.Drawing.Size(1050, 70);
            this.panelFormJadwal.TabIndex = 0;
            this.panelFormJadwal.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelFormJadwal_Paint);
          
            this.dgvJadwal.BackgroundColor = System.Drawing.Color.White;
            this.dgvJadwal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvJadwal.ColumnHeadersHeight = 36;
            this.dgvJadwal.EnableHeadersVisualStyles = false;
            this.dgvJadwal.Location = new System.Drawing.Point(10, 88);
            this.dgvJadwal.Name = "dgvJadwal";
            this.dgvJadwal.ReadOnly = true;
            this.dgvJadwal.RowHeadersWidth = 51;
            this.dgvJadwal.Size = new System.Drawing.Size(1050, 445);
            this.dgvJadwal.TabIndex = 1;
          
            this.lblDokterJadwal.Location = new System.Drawing.Point(10, 10);
            this.lblDokterJadwal.Name = "lblDokterJadwal";
            this.lblDokterJadwal.Size = new System.Drawing.Size(55, 18);
            this.lblDokterJadwal.TabIndex = 0;
            this.lblDokterJadwal.Text = "Dokter:";
                        this.cmbDokterJadwal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDokterJadwal.Location = new System.Drawing.Point(65, 8);
            this.cmbDokterJadwal.Name = "cmbDokterJadwal";
            this.cmbDokterJadwal.Size = new System.Drawing.Size(180, 25);
            this.cmbDokterJadwal.TabIndex = 1;
            this.cmbDokterJadwal.SelectedIndexChanged += new System.EventHandler(this.CmbDokterJadwal_SelectedIndexChanged);
           
            this.lblHari.Location = new System.Drawing.Point(260, 10);
            this.lblHari.Name = "lblHari";
            this.lblHari.Size = new System.Drawing.Size(35, 18);
            this.lblHari.TabIndex = 2;
            this.lblHari.Text = "Hari:";
           
            this.cmbHari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHari.Items.AddRange(new object[] {
            "Senin",
            "Selasa",
            "Rabu",
            "Kamis",
            "Jumat",
            "Sabtu",
            "Minggu"});
            this.cmbHari.Location = new System.Drawing.Point(295, 8);
            this.cmbHari.Name = "cmbHari";
            this.cmbHari.Size = new System.Drawing.Size(100, 25);
            this.cmbHari.TabIndex = 3;
            
            this.lblMulai.Location = new System.Drawing.Point(410, 10);
            this.lblMulai.Name = "lblMulai";
            this.lblMulai.Size = new System.Drawing.Size(70, 18);
            this.lblMulai.TabIndex = 4;
            this.lblMulai.Text = "Jam Mulai:";
           
            this.dtpMulai.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpMulai.Location = new System.Drawing.Point(485, 8);
            this.dtpMulai.Name = "dtpMulai";
            this.dtpMulai.ShowUpDown = true;
            this.dtpMulai.Size = new System.Drawing.Size(100, 25);
            this.dtpMulai.TabIndex = 5;
           
            this.lblSelesai.Location = new System.Drawing.Point(600, 10);
            this.lblSelesai.Name = "lblSelesai";
            this.lblSelesai.Size = new System.Drawing.Size(78, 18);
            this.lblSelesai.TabIndex = 6;
            this.lblSelesai.Text = "Jam Selesai:";
           
            this.dtpSelesai.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSelesai.Location = new System.Drawing.Point(680, 8);
            this.dtpSelesai.Name = "dtpSelesai";
            this.dtpSelesai.ShowUpDown = true;
            this.dtpSelesai.Size = new System.Drawing.Size(100, 25);
            this.dtpSelesai.TabIndex = 7;
          
            this.lblKuota.Location = new System.Drawing.Point(800, 10);
            this.lblKuota.Name = "lblKuota";
            this.lblKuota.Size = new System.Drawing.Size(45, 18);
            this.lblKuota.TabIndex = 8;
            this.lblKuota.Text = "Kuota:";
            
            this.nudKuota.Location = new System.Drawing.Point(848, 8);
            this.nudKuota.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudKuota.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudKuota.Name = "nudKuota";
            this.nudKuota.Size = new System.Drawing.Size(60, 25);
            this.nudKuota.TabIndex = 9;
            this.nudKuota.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
          
            this.btnTambahJadwal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnTambahJadwal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTambahJadwal.FlatAppearance.BorderSize = 0;
            this.btnTambahJadwal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambahJadwal.ForeColor = System.Drawing.Color.White;
            this.btnTambahJadwal.Location = new System.Drawing.Point(930, 8);
            this.btnTambahJadwal.Name = "btnTambahJadwal";
            this.btnTambahJadwal.Size = new System.Drawing.Size(100, 30);
            this.btnTambahJadwal.TabIndex = 10;
            this.btnTambahJadwal.Text = "+ Tambah";
            this.btnTambahJadwal.UseVisualStyleBackColor = false;
            this.btnTambahJadwal.Click += new System.EventHandler(this.BtnTambahJadwal_Click);
            this.btnHapusJadwal.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnHapusJadwal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHapusJadwal.FlatAppearance.BorderSize = 0;
            this.btnHapusJadwal.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btnHapusJadwal.ForeColor =
                System.Drawing.Color.White;
            this.btnHapusJadwal.Location =
                new System.Drawing.Point(930, 40);
            this.btnHapusJadwal.Name = "btnHapusJadwal";
            this.btnHapusJadwal.Size =
                new System.Drawing.Size(100, 25);
            this.btnHapusJadwal.Text = "Hapus";
            this.btnHapusJadwal.UseVisualStyleBackColor = false;
            this.btnHapusJadwal.Click +=
                new System.EventHandler(this.BtnHapusJadwal_Click);

            this.lblCardPasien.Location = new System.Drawing.Point(0, 0);
            this.lblCardPasien.Name = "lblCardPasien";
            this.lblCardPasien.Size = new System.Drawing.Size(100, 23);
            this.lblCardPasien.TabIndex = 0;
           
            this.lblTotalPasien.Location = new System.Drawing.Point(0, 0);
            this.lblTotalPasien.Name = "lblTotalPasien";
            this.lblTotalPasien.Size = new System.Drawing.Size(100, 23);
            this.lblTotalPasien.TabIndex = 0;
          
            this.lblCardDokter.Location = new System.Drawing.Point(0, 0);
            this.lblCardDokter.Name = "lblCardDokter";
            this.lblCardDokter.Size = new System.Drawing.Size(100, 23);
            this.lblCardDokter.TabIndex = 0;
         
            this.lblTotalDokter.Location = new System.Drawing.Point(0, 0);
            this.lblTotalDokter.Name = "lblTotalDokter";
            this.lblTotalDokter.Size = new System.Drawing.Size(100, 23);
            this.lblTotalDokter.TabIndex = 0;
           
            this.lblCardMenunggu.Location = new System.Drawing.Point(0, 0);
            this.lblCardMenunggu.Name = "lblCardMenunggu";
            this.lblCardMenunggu.Size = new System.Drawing.Size(100, 23);
            this.lblCardMenunggu.TabIndex = 0;
           
            this.lblMenunggu.Location = new System.Drawing.Point(0, 0);
            this.lblMenunggu.Name = "lblMenunggu";
            this.lblMenunggu.Size = new System.Drawing.Size(100, 23);
            this.lblMenunggu.TabIndex = 0;
        
           dataGridViewCellStyle2.Alignment =
                System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;

            dataGridViewCellStyle2.BackColor =
                System.Drawing.Color.FromArgb(41, 128, 185);

            dataGridViewCellStyle2.ForeColor =
                System.Drawing.Color.White;

            dataGridViewCellStyle2.Font =
                new System.Drawing.Font("Segoe UI", 10F);

            dataGridViewCellStyle2.WrapMode =
                System.Windows.Forms.DataGridViewTriState.True;

            this.dgvDokter.ColumnHeadersDefaultCellStyle =
                dataGridViewCellStyle2;

            this.dgvDokter.BackgroundColor = System.Drawing.Color.White;
            this.dgvDokter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDokter.ColumnHeadersHeight = 36;
            this.dgvDokter.EnableHeadersVisualStyles = false;
            this.dgvDokter.Location = new System.Drawing.Point(10, 90);
            this.dgvDokter.Name = "dgvDokter";
            this.dgvDokter.ReadOnly = true;
            this.dgvDokter.RowHeadersWidth = 51;
            this.dgvDokter.Size = new System.Drawing.Size(1050, 440);
            this.dgvDokter.TabIndex = 1;
          
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1082, 633);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FormDashboardAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard Admin - Sistem Booking Kontrol Pasien";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDashboardAdmin_FormClosed);
            this.Load += new System.EventHandler(this.FormDashboardAdmin_Load);
            this.panelTop.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabSummary.ResumeLayout(false);
            this.panelCards.ResumeLayout(false);
            this.tabBooking.ResumeLayout(false);
            this.panelFilterBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJadwal)).EndInit();
            this.tabDokter.ResumeLayout(false);
            this.panelFormDokter.ResumeLayout(false);
            this.panelFormDokter.PerformLayout();
            this.tabJadwal.ResumeLayout(false);
            this.panelFormJadwal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudKuota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDokter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabSummary;
        private System.Windows.Forms.Panel panelCards;
        private System.Windows.Forms.Panel cardPasien;
        private System.Windows.Forms.Label lblCardPasien;
        private System.Windows.Forms.Label lblTotalPasien;
        private System.Windows.Forms.Panel cardDokter;
        private System.Windows.Forms.Label lblCardDokter;
        private System.Windows.Forms.Label lblTotalDokter;
        private System.Windows.Forms.Panel cardMenunggu;
        private System.Windows.Forms.Label lblCardMenunggu;
        private System.Windows.Forms.Label lblMenunggu;
        private System.Windows.Forms.TabPage tabBooking;
        private System.Windows.Forms.Panel panelFilterBar;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Button btnSetujui;
        private System.Windows.Forms.Button btnTolak;
        private System.Windows.Forms.Button btnSelesai;
        private System.Windows.Forms.DataGridView dgvBooking;
        private System.Windows.Forms.TabPage tabDokter;
        private System.Windows.Forms.Panel panelFormDokter;
        private System.Windows.Forms.Label lblNamaDokter;
        private System.Windows.Forms.TextBox txtNamaDokter;
        private System.Windows.Forms.Label lblSpesialisasi;
        private System.Windows.Forms.TextBox txtSpesialisasi;
        private System.Windows.Forms.Label lblNoHPDokterLbl;
        private System.Windows.Forms.TextBox txtNoHPDokter;
        private System.Windows.Forms.Button btnTambahDokter;
        private System.Windows.Forms.Button btnNonaktifDokter;
        private System.Windows.Forms.TextBox txtCariDokter;
        private System.Windows.Forms.Label lblCariDokter;
        private System.Windows.Forms.TabPage tabJadwal;
        private System.Windows.Forms.Panel panelFormJadwal;
        private System.Windows.Forms.Label lblDokterJadwal;
        private System.Windows.Forms.ComboBox cmbDokterJadwal;
        private System.Windows.Forms.Label lblHari;
        private System.Windows.Forms.ComboBox cmbHari;
        private System.Windows.Forms.Label lblMulai;
        private System.Windows.Forms.DateTimePicker dtpMulai;
        private System.Windows.Forms.Label lblSelesai;
        private System.Windows.Forms.DateTimePicker dtpSelesai;
        private System.Windows.Forms.Label lblKuota;
        private System.Windows.Forms.NumericUpDown nudKuota;
        private System.Windows.Forms.DataGridView dgvJadwal;
        private System.Windows.Forms.DataGridView dgvDokter;
        private System.Windows.Forms.Button btnTambahJadwal;
        private System.Windows.Forms.Button btnHapusJadwal;
    }
}
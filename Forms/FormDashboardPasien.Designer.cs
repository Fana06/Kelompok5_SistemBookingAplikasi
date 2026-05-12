namespace BookingKontrolPasien.Forms
{
    partial class FormDashboardPasien
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboardPasien));
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabRiwayat = new System.Windows.Forms.TabPage();
            this.panelRiwayatBar = new System.Windows.Forms.Panel();
            this.lblCariRiwayat = new System.Windows.Forms.Label();
            this.txtCariRiwayat = new System.Windows.Forms.TextBox();
            this.btnBatalBooking = new System.Windows.Forms.Button();
            this.dgvRiwayat = new System.Windows.Forms.DataGridView();
            this.tabBookingBaru = new System.Windows.Forms.TabPage();
            this.panelJadwalTop = new System.Windows.Forms.Panel();
            this.lblPilihJadwal = new System.Windows.Forms.Label();
            this.dgvJadwal = new System.Windows.Forms.DataGridView();
            this.panelKeluhanBar = new System.Windows.Forms.Panel();
            this.lblKeluhan = new System.Windows.Forms.Label();
            this.txtKeluhan = new System.Windows.Forms.TextBox();
            this.btnBooking = new System.Windows.Forms.Button();
            this.tabProfil = new System.Windows.Forms.TabPage();
            this.panelProfil = new System.Windows.Forms.Panel();
            this.lblProfilTitle = new System.Windows.Forms.Label();
            this.lblNikKey = new System.Windows.Forms.Label();
            this.lblProfilNIK = new System.Windows.Forms.Label();
            this.lblNamaKey = new System.Windows.Forms.Label();
            this.lblProfilNama = new System.Windows.Forms.Label();
            this.lblTglKey = new System.Windows.Forms.Label();
            this.lblProfilTgl = new System.Windows.Forms.Label();
            this.lblJKKey = new System.Windows.Forms.Label();
            this.lblProfilJK = new System.Windows.Forms.Label();
            this.lblAlamatKey = new System.Windows.Forms.Label();
            this.lblProfilAlamat = new System.Windows.Forms.Label();
            this.lblHPKey = new System.Windows.Forms.Label();
            this.lblProfilHP = new System.Windows.Forms.Label();
            this.lblEmailKey = new System.Windows.Forms.Label();
            this.lblProfilEmail = new System.Windows.Forms.Label();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.panelTop.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabRiwayat.SuspendLayout();
            this.panelRiwayatBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRiwayat)).BeginInit();
            this.tabBookingBaru.SuspendLayout();
            this.panelJadwalTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJadwal)).BeginInit();
            this.panelKeluhanBar.SuspendLayout();
            this.tabProfil.SuspendLayout();
            this.panelProfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.panelTop.Controls.Add(this.bindingNavigator1);
            this.panelTop.Controls.Add(this.lblAppTitle);
            this.panelTop.Controls.Add(this.lblWelcome);
            this.panelTop.Controls.Add(this.btnLogout);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(984, 60);
            this.panelTop.TabIndex = 1;
            // 
            // lblAppTitle
            // 
            this.lblAppTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblAppTitle.ForeColor = System.Drawing.Color.White;
            this.lblAppTitle.Location = new System.Drawing.Point(20, 28);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(181, 30);
            this.lblAppTitle.TabIndex = 0;
            this.lblAppTitle.Text = "🏥 Portal Pasien";
            // 
            // lblWelcome
            // 
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(240)))), ((int)(((byte)(200)))));
            this.lblWelcome.Location = new System.Drawing.Point(264, 33);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(420, 22);
            this.lblWelcome.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(873, 31);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(99, 24);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabRiwayat);
            this.tabControl.Controls.Add(this.tabBookingBaru);
            this.tabControl.Controls.Add(this.tabProfil);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControl.Location = new System.Drawing.Point(0, 60);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(984, 541);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // tabRiwayat
            // 
            this.tabRiwayat.Controls.Add(this.panelRiwayatBar);
            this.tabRiwayat.Controls.Add(this.dgvRiwayat);
            this.tabRiwayat.Location = new System.Drawing.Point(4, 26);
            this.tabRiwayat.Name = "tabRiwayat";
            this.tabRiwayat.Size = new System.Drawing.Size(976, 511);
            this.tabRiwayat.TabIndex = 0;
            this.tabRiwayat.Text = "  Riwayat Booking  ";
            // 
            // panelRiwayatBar
            // 
            this.panelRiwayatBar.BackColor = System.Drawing.Color.Transparent;
            this.panelRiwayatBar.Controls.Add(this.lblCariRiwayat);
            this.panelRiwayatBar.Controls.Add(this.txtCariRiwayat);
            this.panelRiwayatBar.Controls.Add(this.btnBatalBooking);
            this.panelRiwayatBar.Location = new System.Drawing.Point(8, 0);
            this.panelRiwayatBar.Name = "panelRiwayatBar";
            this.panelRiwayatBar.Size = new System.Drawing.Size(950, 48);
            this.panelRiwayatBar.TabIndex = 0;
            // 
            // lblCariRiwayat
            // 
            this.lblCariRiwayat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCariRiwayat.Location = new System.Drawing.Point(10, 12);
            this.lblCariRiwayat.Name = "lblCariRiwayat";
            this.lblCariRiwayat.Size = new System.Drawing.Size(40, 20);
            this.lblCariRiwayat.TabIndex = 0;
            this.lblCariRiwayat.Text = "Cari:";
            // 
            // txtCariRiwayat
            // 
            this.txtCariRiwayat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCariRiwayat.Location = new System.Drawing.Point(55, 9);
            this.txtCariRiwayat.Name = "txtCariRiwayat";
            this.txtCariRiwayat.Size = new System.Drawing.Size(250, 25);
            this.txtCariRiwayat.TabIndex = 1;
            this.txtCariRiwayat.TextChanged += new System.EventHandler(this.TxtCariRiwayat_TextChanged);
            // 
            // btnBatalBooking
            // 
            this.btnBatalBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnBatalBooking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBatalBooking.FlatAppearance.BorderSize = 0;
            this.btnBatalBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatalBooking.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBatalBooking.ForeColor = System.Drawing.Color.White;
            this.btnBatalBooking.Location = new System.Drawing.Point(795, 7);
            this.btnBatalBooking.Name = "btnBatalBooking";
            this.btnBatalBooking.Size = new System.Drawing.Size(140, 34);
            this.btnBatalBooking.TabIndex = 2;
            this.btnBatalBooking.Text = "✖  Batalkan Booking";
            this.btnBatalBooking.UseVisualStyleBackColor = false;
            this.btnBatalBooking.Click += new System.EventHandler(this.BtnBatalBooking_Click);
            // 
            // dgvRiwayat
            // 
            this.dgvRiwayat.AllowUserToAddRows = false;
            this.dgvRiwayat.BackgroundColor = System.Drawing.Color.White;
            this.dgvRiwayat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRiwayat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRiwayat.ColumnHeadersHeight = 36;
            this.dgvRiwayat.EnableHeadersVisualStyles = false;
            this.dgvRiwayat.Location = new System.Drawing.Point(8, 47);
            this.dgvRiwayat.Name = "dgvRiwayat";
            this.dgvRiwayat.Size = new System.Drawing.Size(950, 470);
            this.dgvRiwayat.TabIndex = 1;
            // 
            // tabBookingBaru
            // 
            this.tabBookingBaru.Controls.Add(this.panelJadwalTop);
            this.tabBookingBaru.Controls.Add(this.dgvJadwal);
            this.tabBookingBaru.Controls.Add(this.panelKeluhanBar);
            this.tabBookingBaru.Location = new System.Drawing.Point(4, 26);
            this.tabBookingBaru.Name = "tabBookingBaru";
            this.tabBookingBaru.Size = new System.Drawing.Size(976, 511);
            this.tabBookingBaru.TabIndex = 1;
            this.tabBookingBaru.Text = "  Booking Jadwal  ";
            // 
            // panelJadwalTop
            // 
            this.panelJadwalTop.BackColor = System.Drawing.Color.Transparent;
            this.panelJadwalTop.Controls.Add(this.lblPilihJadwal);
            this.panelJadwalTop.Location = new System.Drawing.Point(10, 10);
            this.panelJadwalTop.Name = "panelJadwalTop";
            this.panelJadwalTop.Size = new System.Drawing.Size(950, 28);
            this.panelJadwalTop.TabIndex = 0;
            // 
            // lblPilihJadwal
            // 
            this.lblPilihJadwal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPilihJadwal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.lblPilihJadwal.Location = new System.Drawing.Point(0, 4);
            this.lblPilihJadwal.Name = "lblPilihJadwal";
            this.lblPilihJadwal.Size = new System.Drawing.Size(700, 22);
            this.lblPilihJadwal.TabIndex = 0;
            this.lblPilihJadwal.Text = "Jadwal Tersedia (pilih satu, lalu isi keluhan di bawah):";
            // 
            // dgvJadwal
            // 
            this.dgvJadwal.AllowUserToAddRows = false;
            this.dgvJadwal.BackgroundColor = System.Drawing.Color.White;
            this.dgvJadwal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJadwal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvJadwal.ColumnHeadersHeight = 36;
            this.dgvJadwal.EnableHeadersVisualStyles = false;
            this.dgvJadwal.Location = new System.Drawing.Point(10, 44);
            this.dgvJadwal.Name = "dgvJadwal";
            this.dgvJadwal.Size = new System.Drawing.Size(950, 330);
            this.dgvJadwal.TabIndex = 1;
            // 
            // panelKeluhanBar
            // 
            this.panelKeluhanBar.BackColor = System.Drawing.Color.White;
            this.panelKeluhanBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelKeluhanBar.Controls.Add(this.lblKeluhan);
            this.panelKeluhanBar.Controls.Add(this.txtKeluhan);
            this.panelKeluhanBar.Controls.Add(this.btnBooking);
            this.panelKeluhanBar.Location = new System.Drawing.Point(10, 385);
            this.panelKeluhanBar.Name = "panelKeluhanBar";
            this.panelKeluhanBar.Size = new System.Drawing.Size(950, 140);
            this.panelKeluhanBar.TabIndex = 2;
            // 
            // lblKeluhan
            // 
            this.lblKeluhan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblKeluhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblKeluhan.Location = new System.Drawing.Point(15, 12);
            this.lblKeluhan.Name = "lblKeluhan";
            this.lblKeluhan.Size = new System.Drawing.Size(200, 18);
            this.lblKeluhan.TabIndex = 0;
            this.lblKeluhan.Text = "Keluhan / Alasan Kontrol:";
            // 
            // txtKeluhan
            // 
            this.txtKeluhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtKeluhan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKeluhan.Location = new System.Drawing.Point(15, 34);
            this.txtKeluhan.Multiline = true;
            this.txtKeluhan.Name = "txtKeluhan";
            this.txtKeluhan.Size = new System.Drawing.Size(780, 80);
            this.txtKeluhan.TabIndex = 1;
            // 
            // btnBooking
            // 
            this.btnBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnBooking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBooking.FlatAppearance.BorderSize = 0;
            this.btnBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooking.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBooking.ForeColor = System.Drawing.Color.White;
            this.btnBooking.Location = new System.Drawing.Point(810, 34);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(125, 80);
            this.btnBooking.TabIndex = 2;
            this.btnBooking.Text = "✔  Booking Sekarang";
            this.btnBooking.UseVisualStyleBackColor = false;
            this.btnBooking.Click += new System.EventHandler(this.BtnBooking_Click);
            // 
            // tabProfil
            // 
            this.tabProfil.Controls.Add(this.panelProfil);
            this.tabProfil.Location = new System.Drawing.Point(4, 26);
            this.tabProfil.Name = "tabProfil";
            this.tabProfil.Size = new System.Drawing.Size(976, 511);
            this.tabProfil.TabIndex = 2;
            this.tabProfil.Text = "  Profil Saya  ";
            // 
            // panelProfil
            // 
            this.panelProfil.BackColor = System.Drawing.Color.White;
            this.panelProfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProfil.Controls.Add(this.lblProfilTitle);
            this.panelProfil.Controls.Add(this.lblNikKey);
            this.panelProfil.Controls.Add(this.lblProfilNIK);
            this.panelProfil.Controls.Add(this.lblNamaKey);
            this.panelProfil.Controls.Add(this.lblProfilNama);
            this.panelProfil.Controls.Add(this.lblTglKey);
            this.panelProfil.Controls.Add(this.lblProfilTgl);
            this.panelProfil.Controls.Add(this.lblJKKey);
            this.panelProfil.Controls.Add(this.lblProfilJK);
            this.panelProfil.Controls.Add(this.lblAlamatKey);
            this.panelProfil.Controls.Add(this.lblProfilAlamat);
            this.panelProfil.Controls.Add(this.lblHPKey);
            this.panelProfil.Controls.Add(this.lblProfilHP);
            this.panelProfil.Controls.Add(this.lblEmailKey);
            this.panelProfil.Controls.Add(this.lblProfilEmail);
            this.panelProfil.Location = new System.Drawing.Point(30, 20);
            this.panelProfil.Name = "panelProfil";
            this.panelProfil.Size = new System.Drawing.Size(600, 450);
            this.panelProfil.TabIndex = 0;
            // 
            // lblProfilTitle
            // 
            this.lblProfilTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblProfilTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.lblProfilTitle.Location = new System.Drawing.Point(20, 20);
            this.lblProfilTitle.Name = "lblProfilTitle";
            this.lblProfilTitle.Size = new System.Drawing.Size(400, 30);
            this.lblProfilTitle.TabIndex = 0;
            this.lblProfilTitle.Text = "Data Diri Pasien";
            // 
            // lblNikKey
            // 
            this.lblNikKey.Location = new System.Drawing.Point(0, 0);
            this.lblNikKey.Name = "lblNikKey";
            this.lblNikKey.Size = new System.Drawing.Size(100, 23);
            this.lblNikKey.TabIndex = 1;
            // 
            // lblProfilNIK
            // 
            this.lblProfilNIK.Location = new System.Drawing.Point(0, 0);
            this.lblProfilNIK.Name = "lblProfilNIK";
            this.lblProfilNIK.Size = new System.Drawing.Size(100, 23);
            this.lblProfilNIK.TabIndex = 2;
            // 
            // lblNamaKey
            // 
            this.lblNamaKey.Location = new System.Drawing.Point(0, 0);
            this.lblNamaKey.Name = "lblNamaKey";
            this.lblNamaKey.Size = new System.Drawing.Size(100, 23);
            this.lblNamaKey.TabIndex = 3;
            // 
            // lblProfilNama
            // 
            this.lblProfilNama.Location = new System.Drawing.Point(0, 0);
            this.lblProfilNama.Name = "lblProfilNama";
            this.lblProfilNama.Size = new System.Drawing.Size(100, 23);
            this.lblProfilNama.TabIndex = 4;
            // 
            // lblTglKey
            // 
            this.lblTglKey.Location = new System.Drawing.Point(0, 0);
            this.lblTglKey.Name = "lblTglKey";
            this.lblTglKey.Size = new System.Drawing.Size(100, 23);
            this.lblTglKey.TabIndex = 5;
            // 
            // lblProfilTgl
            // 
            this.lblProfilTgl.Location = new System.Drawing.Point(0, 0);
            this.lblProfilTgl.Name = "lblProfilTgl";
            this.lblProfilTgl.Size = new System.Drawing.Size(100, 23);
            this.lblProfilTgl.TabIndex = 6;
            // 
            // lblJKKey
            // 
            this.lblJKKey.Location = new System.Drawing.Point(0, 0);
            this.lblJKKey.Name = "lblJKKey";
            this.lblJKKey.Size = new System.Drawing.Size(100, 23);
            this.lblJKKey.TabIndex = 7;
            // 
            // lblProfilJK
            // 
            this.lblProfilJK.Location = new System.Drawing.Point(0, 0);
            this.lblProfilJK.Name = "lblProfilJK";
            this.lblProfilJK.Size = new System.Drawing.Size(100, 23);
            this.lblProfilJK.TabIndex = 8;
            // 
            // lblAlamatKey
            // 
            this.lblAlamatKey.Location = new System.Drawing.Point(0, 0);
            this.lblAlamatKey.Name = "lblAlamatKey";
            this.lblAlamatKey.Size = new System.Drawing.Size(100, 23);
            this.lblAlamatKey.TabIndex = 9;
            // 
            // lblProfilAlamat
            // 
            this.lblProfilAlamat.Location = new System.Drawing.Point(0, 0);
            this.lblProfilAlamat.Name = "lblProfilAlamat";
            this.lblProfilAlamat.Size = new System.Drawing.Size(100, 23);
            this.lblProfilAlamat.TabIndex = 10;
            // 
            // lblHPKey
            // 
            this.lblHPKey.Location = new System.Drawing.Point(0, 0);
            this.lblHPKey.Name = "lblHPKey";
            this.lblHPKey.Size = new System.Drawing.Size(100, 23);
            this.lblHPKey.TabIndex = 11;
            // 
            // lblProfilHP
            // 
            this.lblProfilHP.Location = new System.Drawing.Point(0, 0);
            this.lblProfilHP.Name = "lblProfilHP";
            this.lblProfilHP.Size = new System.Drawing.Size(100, 23);
            this.lblProfilHP.TabIndex = 12;
            // 
            // lblEmailKey
            // 
            this.lblEmailKey.Location = new System.Drawing.Point(0, 0);
            this.lblEmailKey.Name = "lblEmailKey";
            this.lblEmailKey.Size = new System.Drawing.Size(100, 23);
            this.lblEmailKey.TabIndex = 13;
            // 
            // lblProfilEmail
            // 
            this.lblProfilEmail.Location = new System.Drawing.Point(0, 0);
            this.lblProfilEmail.Name = "lblProfilEmail";
            this.lblProfilEmail.Size = new System.Drawing.Size(100, 23);
            this.lblProfilEmail.TabIndex = 14;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(984, 25);
            this.bindingNavigator1.TabIndex = 3;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // FormDashboardPasien
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(984, 601);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FormDashboardPasien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard Pasien - Sistem Booking Kontrol Pasien";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDashboardPasien_FormClosed);
            this.Load += new System.EventHandler(this.FormDashboardPasien_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabRiwayat.ResumeLayout(false);
            this.panelRiwayatBar.ResumeLayout(false);
            this.panelRiwayatBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRiwayat)).EndInit();
            this.tabBookingBaru.ResumeLayout(false);
            this.panelJadwalTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJadwal)).EndInit();
            this.panelKeluhanBar.ResumeLayout(false);
            this.panelKeluhanBar.PerformLayout();
            this.tabProfil.ResumeLayout(false);
            this.panelProfil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabRiwayat;
        private System.Windows.Forms.Panel panelRiwayatBar;
        private System.Windows.Forms.Button btnBatalBooking;
        private System.Windows.Forms.TextBox txtCariRiwayat;
        private System.Windows.Forms.Label lblCariRiwayat;
        private System.Windows.Forms.DataGridView dgvRiwayat;
        private System.Windows.Forms.TabPage tabBookingBaru;
        private System.Windows.Forms.Panel panelJadwalTop;
        private System.Windows.Forms.Label lblPilihJadwal;
        private System.Windows.Forms.DataGridView dgvJadwal;
        private System.Windows.Forms.Panel panelKeluhanBar;
        private System.Windows.Forms.Label lblKeluhan;
        private System.Windows.Forms.TextBox txtKeluhan;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.TabPage tabProfil;
        private System.Windows.Forms.Panel panelProfil;
        private System.Windows.Forms.Label lblProfilTitle;
        private System.Windows.Forms.Label lblNikKey;
        private System.Windows.Forms.Label lblProfilNIK;
        private System.Windows.Forms.Label lblNamaKey;
        private System.Windows.Forms.Label lblProfilNama;
        private System.Windows.Forms.Label lblTglKey;
        private System.Windows.Forms.Label lblProfilTgl;
        private System.Windows.Forms.Label lblJKKey;
        private System.Windows.Forms.Label lblProfilJK;
        private System.Windows.Forms.Label lblAlamatKey;
        private System.Windows.Forms.Label lblProfilAlamat;
        private System.Windows.Forms.Label lblHPKey;
        private System.Windows.Forms.Label lblProfilHP;
        private System.Windows.Forms.Label lblEmailKey;
        private System.Windows.Forms.Label lblProfilEmail;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
    }
}
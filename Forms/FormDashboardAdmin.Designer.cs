using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BookingKontrolPasien.Forms
{
    partial class FormDashboardAdmin
    {
        internal System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
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
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lblFilter = new System.Windows.Forms.Label();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.btnSetujui = new System.Windows.Forms.Button();
            this.btnTolak = new System.Windows.Forms.Button();
            this.btnSelesai = new System.Windows.Forms.Button();
            this.dgvBooking = new System.Windows.Forms.DataGridView();
            this.tabDokter = new System.Windows.Forms.TabPage();
            this.panelFormDokter = new System.Windows.Forms.Panel();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.lblNamaDokter = new System.Windows.Forms.Label();
            this.txtNamaDokter = new System.Windows.Forms.TextBox();
            this.lblSpesialisasi = new System.Windows.Forms.Label();
            this.txtSpesialisasi = new System.Windows.Forms.TextBox();
            this.lblNoHPDokterLbl = new System.Windows.Forms.Label();
            this.txtNoHPDokter = new System.Windows.Forms.TextBox();
            this.btnTambahDokter = new System.Windows.Forms.Button();
            this.btnNonaktifDokter = new System.Windows.Forms.Button();
            this.lblCariDokter = new System.Windows.Forms.Label();
            this.txtCariDokter = new System.Windows.Forms.TextBox();
            this.dgvDokter = new System.Windows.Forms.DataGridView();
            this.tabJadwal = new System.Windows.Forms.TabPage();
            this.panelFormJadwal = new System.Windows.Forms.Panel();
            this.bindingNavigator3 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem2 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem2 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator8 = new System.Windows.Forms.ToolStripSeparator();
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
            this.tabReport = new System.Windows.Forms.TabPage();
            this.tabImport = new System.Windows.Forms.TabPage();
            this.lblCardPasien = new System.Windows.Forms.Label();
            this.lblTotalPasien = new System.Windows.Forms.Label();
            this.lblCardDokter = new System.Windows.Forms.Label();
            this.lblTotalDokter = new System.Windows.Forms.Label();
            this.lblCardMenunggu = new System.Windows.Forms.Label();
            this.lblMenunggu = new System.Windows.Forms.Label();
            this.BtnInject = new System.Windows.Forms.Button();
            this.BtnResetInject = new System.Windows.Forms.Button();
            this.lblChartBookingTitle = new System.Windows.Forms.Label();
            this._chartBookingStatus = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelReportFilter = new System.Windows.Forms.Panel();
            this.lblReportMulai = new System.Windows.Forms.Label();
            this._dtpReportMulai = new System.Windows.Forms.DateTimePicker();
            this.lblReportSelesai = new System.Windows.Forms.Label();
            this._dtpReportSelesai = new System.Windows.Forms.DateTimePicker();
            this.lblReportStatus = new System.Windows.Forms.Label();
            this._cmbReportStatus = new System.Windows.Forms.ComboBox();
            this.btnTampilReport = new System.Windows.Forms.Button();
            this.btnRekapDokter = new System.Windows.Forms.Button();
            this.btnUploadFotoDokter = new System.Windows.Forms.Button();
            this.pbFotoDokter = new System.Windows.Forms.PictureBox();
            this.btnPrintReport = new System.Windows.Forms.Button();
            this.btnExportReport = new System.Windows.Forms.Button();
            this._dgvReportBooking = new System.Windows.Forms.DataGridView();
            this.panelImport = new System.Windows.Forms.Panel();
            this.btnTemplateImportDokter = new System.Windows.Forms.Button();
            this.btnPilihExcelDokter = new System.Windows.Forms.Button();
            this.btnSimpanImportDokter = new System.Windows.Forms.Button();
            this._lblImportStatus = new System.Windows.Forms.Label();
            this._dgvImportDokter = new System.Windows.Forms.DataGridView();
            this.tabImportJadwal = new System.Windows.Forms.TabPage();
            this.panelImportJadwal = new System.Windows.Forms.Panel();
            this.btnTemplateImportJadwal = new System.Windows.Forms.Button();
            this.btnPilihExcelJadwal = new System.Windows.Forms.Button();
            this.btnSimpanImportJadwal = new System.Windows.Forms.Button();
            this._lblImportJadwalStatus = new System.Windows.Forms.Label();
            this._dgvImportJadwal = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabSummary.SuspendLayout();
            this.panelCards.SuspendLayout();
            this.tabBooking.SuspendLayout();
            this.panelFilterBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).BeginInit();
            this.tabDokter.SuspendLayout();
            this.panelFormDokter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDokter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoDokter)).BeginInit();
            this.tabJadwal.SuspendLayout();
            this.panelFormJadwal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).BeginInit();
            this.bindingNavigator3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKuota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJadwal)).BeginInit();
            this.tabReport.SuspendLayout();
            this.panelReportFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgvReportBooking)).BeginInit();
            this.tabImport.SuspendLayout();
            this.panelImport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgvImportDokter)).BeginInit();
            this.tabImportJadwal.SuspendLayout();
            this.panelImportJadwal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgvImportJadwal)).BeginInit();
            this.SuspendLayout();
            //
            // panelTop
            //
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panelTop.Controls.Add(this.BtnResetInject);
            this.panelTop.Controls.Add(this.BtnInject);
            this.panelTop.Controls.Add(this.lblAppTitle);
            this.panelTop.Controls.Add(this.lblWelcome);
            this.panelTop.Controls.Add(this.btnLogout);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1082, 60);
            this.panelTop.TabIndex = 1;
            //
            // lblAppTitle
            //
            this.lblAppTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblAppTitle.ForeColor = System.Drawing.Color.White;
            this.lblAppTitle.Location = new System.Drawing.Point(20, 15);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(420, 30);
            this.lblAppTitle.TabIndex = 0;
            this.lblAppTitle.Text = "🏥 Sistem Booking Kontrol Pasien";
            //
            // lblWelcome
            //
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.lblWelcome.Location = new System.Drawing.Point(460, 20);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(400, 22);
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
            this.btnLogout.Location = new System.Drawing.Point(980, 15);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(90, 32);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            //
            // tabControl
            //
            this.tabControl.Controls.Add(this.tabSummary);
            this.tabControl.Controls.Add(this.tabBooking);
            this.tabControl.Controls.Add(this.tabDokter);
            this.tabControl.Controls.Add(this.tabJadwal);
            this.tabControl.Controls.Add(this.tabReport);
            this.tabControl.Controls.Add(this.tabImport);
            this.tabControl.Controls.Add(this.tabImportJadwal);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControl.Location = new System.Drawing.Point(0, 60);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1082, 573);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_ReportSummarySelectedIndexChanged);
            //
            // tabSummary
            //
            this.tabSummary.Controls.Add(this.lblChartBookingTitle);
            this.tabSummary.Controls.Add(this._chartBookingStatus);
            this.tabSummary.Controls.Add(this.panelCards);
            this.tabSummary.Location = new System.Drawing.Point(4, 26);
            this.tabSummary.Name = "tabSummary";
            this.tabSummary.Padding = new System.Windows.Forms.Padding(10);
            this.tabSummary.Size = new System.Drawing.Size(1074, 543);
            this.tabSummary.TabIndex = 0;
            this.tabSummary.Text = "  Ringkasan  ";
            //
            // panelCards
            //
            this.panelCards.BackColor = System.Drawing.Color.Transparent;
            this.panelCards.Controls.Add(this.cardPasien);
            this.panelCards.Controls.Add(this.cardDokter);
            this.panelCards.Controls.Add(this.cardMenunggu);
            this.panelCards.Location = new System.Drawing.Point(20, 30);
            this.panelCards.Name = "panelCards";
            this.panelCards.Size = new System.Drawing.Size(1040, 200);
            this.panelCards.TabIndex = 0;
            this.panelCards.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelCards_Paint);
            //
            // cardPasien
            //
            this.cardPasien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.cardPasien.Controls.Add(this.lblCardPasien);
            this.cardPasien.Controls.Add(this.lblTotalPasien);
            this.cardPasien.Location = new System.Drawing.Point(20, 20);
            this.cardPasien.Name = "cardPasien";
            this.cardPasien.Size = new System.Drawing.Size(200, 100);
            this.cardPasien.TabIndex = 0;
            //
            // cardDokter
            //
            this.cardDokter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.cardDokter.Controls.Add(this.lblCardDokter);
            this.cardDokter.Controls.Add(this.lblTotalDokter);
            this.cardDokter.Location = new System.Drawing.Point(220, 20);
            this.cardDokter.Name = "cardDokter";
            this.cardDokter.Size = new System.Drawing.Size(200, 100);
            this.cardDokter.TabIndex = 1;
            //
            // cardMenunggu
            //
            this.cardMenunggu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.cardMenunggu.Controls.Add(this.lblCardMenunggu);
            this.cardMenunggu.Controls.Add(this.lblMenunggu);
            this.cardMenunggu.Location = new System.Drawing.Point(420, 20);
            this.cardMenunggu.Name = "cardMenunggu";
            this.cardMenunggu.Size = new System.Drawing.Size(200, 100);
            this.cardMenunggu.TabIndex = 2;
            //
            // tabBooking
            //
            this.tabBooking.Controls.Add(this.panelFilterBar);
            this.tabBooking.Controls.Add(this.dgvBooking);
            this.tabBooking.Location = new System.Drawing.Point(4, 26);
            this.tabBooking.Name = "tabBooking";
            this.tabBooking.Size = new System.Drawing.Size(1074, 543);
            this.tabBooking.TabIndex = 1;
            this.tabBooking.Text = "  Manajemen Booking  ";
            //
            // panelFilterBar
            //
            this.panelFilterBar.BackColor = System.Drawing.Color.Transparent;
            this.panelFilterBar.Controls.Add(this.bindingNavigator1);
            this.panelFilterBar.Controls.Add(this.lblFilter);
            this.panelFilterBar.Controls.Add(this.cmbFilter);
            this.panelFilterBar.Controls.Add(this.btnSetujui);
            this.panelFilterBar.Controls.Add(this.btnTolak);
            this.panelFilterBar.Controls.Add(this.btnSelesai);
            this.panelFilterBar.Location = new System.Drawing.Point(10, 10);
            this.panelFilterBar.Name = "panelFilterBar";
            this.panelFilterBar.Size = new System.Drawing.Size(1050, 50);
            this.panelFilterBar.TabIndex = 0;
            //
            // bindingNavigator1
            //
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
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
            this.bindingNavigator1.Location = new System.Drawing.Point(735, 10);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(255, 25);
            this.bindingNavigator1.TabIndex = 3;
            this.bindingNavigator1.Text = "bindingNavigator1";
            //
            // bindingNavigatorAddNewItem
            //
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            //
            // bindingNavigatorCountItem
            //
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            //
            // bindingNavigatorDeleteItem
            //
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            //
            // bindingNavigatorMoveFirstItem
            //
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            //
            // bindingNavigatorMovePreviousItem
            //
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
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
            // bindingNavigatorSeparator1
            //
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            //
            // bindingNavigatorMoveNextItem
            //
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            //
            // bindingNavigatorMoveLastItem
            //
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            //
            // bindingNavigatorSeparator2
            //
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            //
            // lblFilter
            //
            this.lblFilter.Location = new System.Drawing.Point(0, 14);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(90, 20);
            this.lblFilter.TabIndex = 0;
            this.lblFilter.Text = "Filter Status:";
            //
            // cmbFilter
            //
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
            //
            // btnSetujui
            //
            this.btnSetujui.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnSetujui.FlatAppearance.BorderSize = 0;
            this.btnSetujui.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetujui.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSetujui.ForeColor = System.Drawing.Color.White;
            this.btnSetujui.Location = new System.Drawing.Point(300, 10);
            this.btnSetujui.Name = "btnSetujui";
            this.btnSetujui.Size = new System.Drawing.Size(100, 30);
            this.btnSetujui.TabIndex = 2;
            this.btnSetujui.Text = "✔ Setujui";
            this.btnSetujui.UseVisualStyleBackColor = false;
            this.btnSetujui.Click += new System.EventHandler(this.BtnSetujui_Click);
            //
            // btnTolak
            //
            this.btnTolak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnTolak.FlatAppearance.BorderSize = 0;
            this.btnTolak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTolak.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTolak.ForeColor = System.Drawing.Color.White;
            this.btnTolak.Location = new System.Drawing.Point(410, 10);
            this.btnTolak.Name = "btnTolak";
            this.btnTolak.Size = new System.Drawing.Size(100, 30);
            this.btnTolak.TabIndex = 3;
            this.btnTolak.Text = "✖ Tolak";
            this.btnTolak.UseVisualStyleBackColor = false;
            this.btnTolak.Click += new System.EventHandler(this.BtnTolak_Click);
            //
            // btnSelesai
            //
            this.btnSelesai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSelesai.FlatAppearance.BorderSize = 0;
            this.btnSelesai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelesai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSelesai.ForeColor = System.Drawing.Color.White;
            this.btnSelesai.Location = new System.Drawing.Point(520, 10);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(100, 30);
            this.btnSelesai.TabIndex = 4;
            this.btnSelesai.Text = "✓ Selesai";
            this.btnSelesai.UseVisualStyleBackColor = false;
            this.btnSelesai.Click += new System.EventHandler(this.BtnSelesai_Click);
            //
            // dgvBooking
            //
            this.dgvBooking.BackgroundColor = System.Drawing.Color.White;
            this.dgvBooking.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBooking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvBooking.ColumnHeadersHeight = 36;
            this.dgvBooking.EnableHeadersVisualStyles = false;
            this.dgvBooking.Location = new System.Drawing.Point(10, 68);
            this.dgvBooking.Name = "dgvBooking";
            this.dgvBooking.ReadOnly = true;
            this.dgvBooking.RowHeadersWidth = 51;
            this.dgvBooking.Size = new System.Drawing.Size(1050, 490);
            this.dgvBooking.TabIndex = 1;
            //
            // tabDokter
            //
            this.tabDokter.Controls.Add(this.panelFormDokter);
            this.tabDokter.Controls.Add(this.dgvDokter);
            this.tabDokter.Location = new System.Drawing.Point(4, 26);
            this.tabDokter.Name = "tabDokter";
            this.tabDokter.Size = new System.Drawing.Size(1074, 543);
            this.tabDokter.TabIndex = 2;
            this.tabDokter.Text = "  Data Dokter  ";
            this.tabDokter.Click += new System.EventHandler(this.TabDokter_Click);
            //
            // panelFormDokter
            //
            this.panelFormDokter.BackColor = System.Drawing.Color.White;
            this.panelFormDokter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFormDokter.Controls.Add(this.bindingNavigator2);
            this.panelFormDokter.Controls.Add(this.lblNamaDokter);
            this.panelFormDokter.Controls.Add(this.txtNamaDokter);
            this.panelFormDokter.Controls.Add(this.lblSpesialisasi);
            this.panelFormDokter.Controls.Add(this.txtSpesialisasi);
            this.panelFormDokter.Controls.Add(this.lblNoHPDokterLbl);
            this.panelFormDokter.Controls.Add(this.txtNoHPDokter);
            this.panelFormDokter.Controls.Add(this.btnTambahDokter);
            this.panelFormDokter.Controls.Add(this.btnNonaktifDokter);
            this.panelFormDokter.Controls.Add(this.btnRekapDokter);
            this.panelFormDokter.Controls.Add(this.btnUploadFotoDokter);
            this.panelFormDokter.Controls.Add(this.pbFotoDokter);
            this.panelFormDokter.Controls.Add(this.lblCariDokter);
            this.panelFormDokter.Controls.Add(this.txtCariDokter);
            this.panelFormDokter.Location = new System.Drawing.Point(10, 10);
            this.panelFormDokter.Name = "panelFormDokter";
            this.panelFormDokter.Size = new System.Drawing.Size(1050, 150);
            this.panelFormDokter.TabIndex = 0;
            //
            // bindingNavigator2
            //
            this.bindingNavigator2.AddNewItem = this.bindingNavigatorAddNewItem1;
            this.bindingNavigator2.CountItem = this.bindingNavigatorCountItem1;
            this.bindingNavigator2.DeleteItem = this.bindingNavigatorDeleteItem1;
            this.bindingNavigator2.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem1,
            this.bindingNavigatorDeleteItem1});
            this.bindingNavigator2.Location = new System.Drawing.Point(55, 105);
            this.bindingNavigator2.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bindingNavigator2.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bindingNavigator2.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bindingNavigator2.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = this.bindingNavigatorPositionItem1;
            this.bindingNavigator2.Size = new System.Drawing.Size(255, 25);
            this.bindingNavigator2.TabIndex = 10;
            this.bindingNavigator2.Text = "bindingNavigator2";
            //
            // bindingNavigatorAddNewItem1
            //
            this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem1";
            this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem1.Text = "Add new";
            //
            // bindingNavigatorCountItem1
            //
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem1.Text = "of {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
            //
            // bindingNavigatorDeleteItem1
            //
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem1";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem1.Text = "Delete";
            //
            // bindingNavigatorMoveFirstItem1
            //
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "Move first";
            //
            // bindingNavigatorMovePreviousItem1
            //
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "Move previous";
            //
            // bindingNavigatorSeparator3
            //
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            //
            // bindingNavigatorPositionItem1
            //
            this.bindingNavigatorPositionItem1.AccessibleName = "Position";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Current position";
            //
            // bindingNavigatorSeparator4
            //
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            //
            // bindingNavigatorMoveNextItem1
            //
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "Move next";
            //
            // bindingNavigatorMoveLastItem1
            //
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "Move last";
            //
            // bindingNavigatorSeparator5
            //
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
            //
            // lblNamaDokter
            //
            this.lblNamaDokter.Location = new System.Drawing.Point(10, 10);
            this.lblNamaDokter.Name = "lblNamaDokter";
            this.lblNamaDokter.Size = new System.Drawing.Size(90, 18);
            this.lblNamaDokter.TabIndex = 0;
            this.lblNamaDokter.Text = "Nama Dokter:";
            //
            // txtNamaDokter
            //
            this.txtNamaDokter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNamaDokter.Location = new System.Drawing.Point(100, 8);
            this.txtNamaDokter.Name = "txtNamaDokter";
            this.txtNamaDokter.Size = new System.Drawing.Size(200, 25);
            this.txtNamaDokter.TabIndex = 1;
            //
            // lblSpesialisasi
            //
            this.lblSpesialisasi.Location = new System.Drawing.Point(320, 10);
            this.lblSpesialisasi.Name = "lblSpesialisasi";
            this.lblSpesialisasi.Size = new System.Drawing.Size(80, 18);
            this.lblSpesialisasi.TabIndex = 2;
            this.lblSpesialisasi.Text = "Spesialisasi:";
            //
            // txtSpesialisasi
            //
            this.txtSpesialisasi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSpesialisasi.Location = new System.Drawing.Point(400, 8);
            this.txtSpesialisasi.Name = "txtSpesialisasi";
            this.txtSpesialisasi.Size = new System.Drawing.Size(160, 25);
            this.txtSpesialisasi.TabIndex = 3;
            //
            // lblNoHPDokterLbl
            //
            this.lblNoHPDokterLbl.Location = new System.Drawing.Point(580, 10);
            this.lblNoHPDokterLbl.Name = "lblNoHPDokterLbl";
            this.lblNoHPDokterLbl.Size = new System.Drawing.Size(50, 18);
            this.lblNoHPDokterLbl.TabIndex = 4;
            this.lblNoHPDokterLbl.Text = "No HP:";
            //
            // txtNoHPDokter
            //
            this.txtNoHPDokter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNoHPDokter.Location = new System.Drawing.Point(635, 8);
            this.txtNoHPDokter.Name = "txtNoHPDokter";
            this.txtNoHPDokter.Size = new System.Drawing.Size(150, 25);
            this.txtNoHPDokter.TabIndex = 5;
            //
            // btnTambahDokter
            //
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
            //
            // btnNonaktifDokter
            //
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
            //
            // lblCariDokter
            //
            this.lblCariDokter.Location = new System.Drawing.Point(10, 40);
            this.lblCariDokter.Name = "lblCariDokter";
            this.lblCariDokter.Size = new System.Drawing.Size(40, 20);
            this.lblCariDokter.TabIndex = 8;
            this.lblCariDokter.Text = "Cari:";
            //
            // txtCariDokter
            //
            this.txtCariDokter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCariDokter.Location = new System.Drawing.Point(55, 38);
            this.txtCariDokter.Name = "txtCariDokter";
            this.txtCariDokter.Size = new System.Drawing.Size(250, 25);
            this.txtCariDokter.TabIndex = 9;
            this.txtCariDokter.TextChanged += new System.EventHandler(this.TxtCariDokter_TextChanged);
            //
            // btnUploadFotoDokter
            //
            this.btnUploadFotoDokter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnUploadFotoDokter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUploadFotoDokter.FlatAppearance.BorderSize = 0;
            this.btnUploadFotoDokter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadFotoDokter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnUploadFotoDokter.ForeColor = System.Drawing.Color.White;
            this.btnUploadFotoDokter.Location = new System.Drawing.Point(315, 38);
            this.btnUploadFotoDokter.Name = "btnUploadFotoDokter";
            this.btnUploadFotoDokter.Size = new System.Drawing.Size(120, 30);
            this.btnUploadFotoDokter.TabIndex = 12;
            this.btnUploadFotoDokter.Text = "Upload Foto";
            this.btnUploadFotoDokter.UseVisualStyleBackColor = false;
            this.btnUploadFotoDokter.Click += new System.EventHandler(this.BtnUploadFotoDokter_Click);
            //
            // pbFotoDokter
            //
            this.pbFotoDokter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pbFotoDokter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFotoDokter.Location = new System.Drawing.Point(925, 44);
            this.pbFotoDokter.Name = "pbFotoDokter";
            this.pbFotoDokter.Size = new System.Drawing.Size(110, 95);
            this.pbFotoDokter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFotoDokter.TabIndex = 13;
            this.pbFotoDokter.TabStop = false;
            //
            // dgvDokter
            //
            this.dgvDokter.BackgroundColor = System.Drawing.Color.White;
            this.dgvDokter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDokter.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDokter.ColumnHeadersHeight = 36;
            this.dgvDokter.EnableHeadersVisualStyles = false;
            this.dgvDokter.Location = new System.Drawing.Point(10, 170);
            this.dgvDokter.Name = "dgvDokter";
            this.dgvDokter.ReadOnly = true;
            this.dgvDokter.RowHeadersWidth = 51;
            this.dgvDokter.Size = new System.Drawing.Size(1050, 360);
            this.dgvDokter.TabIndex = 1;
            this.dgvDokter.SelectionChanged += new System.EventHandler(this.DgvDokter_SelectionChanged);
            //
            // tabJadwal
            //
            this.tabJadwal.Controls.Add(this.panelFormJadwal);
            this.tabJadwal.Controls.Add(this.dgvJadwal);
            this.tabJadwal.Location = new System.Drawing.Point(4, 26);
            this.tabJadwal.Name = "tabJadwal";
            this.tabJadwal.Size = new System.Drawing.Size(1074, 543);
            this.tabJadwal.TabIndex = 3;
            this.tabJadwal.Text = "  Jadwal Dokter  ";
            //
            // panelFormJadwal
            //
            this.panelFormJadwal.BackColor = System.Drawing.Color.White;
            this.panelFormJadwal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFormJadwal.Controls.Add(this.bindingNavigator3);
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
            //
            // bindingNavigator3
            //
            this.bindingNavigator3.AddNewItem = this.bindingNavigatorAddNewItem2;
            this.bindingNavigator3.CountItem = this.bindingNavigatorCountItem2;
            this.bindingNavigator3.DeleteItem = this.bindingNavigatorDeleteItem2;
            this.bindingNavigator3.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem2,
            this.bindingNavigatorMovePreviousItem2,
            this.bindingNavigatorSeparator6,
            this.bindingNavigatorPositionItem2,
            this.bindingNavigatorCountItem2,
            this.bindingNavigatorSeparator7,
            this.bindingNavigatorMoveNextItem2,
            this.bindingNavigatorMoveLastItem2,
            this.bindingNavigatorSeparator8,
            this.bindingNavigatorAddNewItem2,
            this.bindingNavigatorDeleteItem2});
            this.bindingNavigator3.Location = new System.Drawing.Point(622, 40);
            this.bindingNavigator3.MoveFirstItem = this.bindingNavigatorMoveFirstItem2;
            this.bindingNavigator3.MoveLastItem = this.bindingNavigatorMoveLastItem2;
            this.bindingNavigator3.MoveNextItem = this.bindingNavigatorMoveNextItem2;
            this.bindingNavigator3.MovePreviousItem = this.bindingNavigatorMovePreviousItem2;
            this.bindingNavigator3.Name = "bindingNavigator3";
            this.bindingNavigator3.PositionItem = this.bindingNavigatorPositionItem2;
            this.bindingNavigator3.Size = new System.Drawing.Size(255, 25);
            this.bindingNavigator3.TabIndex = 12;
            this.bindingNavigator3.Text = "bindingNavigator3";
            //
            // bindingNavigatorAddNewItem2
            //
            this.bindingNavigatorAddNewItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem2.Name = "bindingNavigatorAddNewItem2";
            this.bindingNavigatorAddNewItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem2.Text = "Add new";
            //
            // bindingNavigatorCountItem2
            //
            this.bindingNavigatorCountItem2.Name = "bindingNavigatorCountItem2";
            this.bindingNavigatorCountItem2.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem2.Text = "of {0}";
            this.bindingNavigatorCountItem2.ToolTipText = "Total number of items";
            //
            // bindingNavigatorDeleteItem2
            //
            this.bindingNavigatorDeleteItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem2.Name = "bindingNavigatorDeleteItem2";
            this.bindingNavigatorDeleteItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem2.Text = "Delete";
            //
            // bindingNavigatorMoveFirstItem2
            //
            this.bindingNavigatorMoveFirstItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem2.Name = "bindingNavigatorMoveFirstItem2";
            this.bindingNavigatorMoveFirstItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem2.Text = "Move first";
            //
            // bindingNavigatorMovePreviousItem2
            //
            this.bindingNavigatorMovePreviousItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem2.Name = "bindingNavigatorMovePreviousItem2";
            this.bindingNavigatorMovePreviousItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem2.Text = "Move previous";
            //
            // bindingNavigatorSeparator6
            //
            this.bindingNavigatorSeparator6.Name = "bindingNavigatorSeparator6";
            this.bindingNavigatorSeparator6.Size = new System.Drawing.Size(6, 25);
            //
            // bindingNavigatorPositionItem2
            //
            this.bindingNavigatorPositionItem2.AccessibleName = "Position";
            this.bindingNavigatorPositionItem2.AutoSize = false;
            this.bindingNavigatorPositionItem2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem2.Name = "bindingNavigatorPositionItem2";
            this.bindingNavigatorPositionItem2.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem2.Text = "0";
            this.bindingNavigatorPositionItem2.ToolTipText = "Current position";
            //
            // bindingNavigatorSeparator7
            //
            this.bindingNavigatorSeparator7.Name = "bindingNavigatorSeparator7";
            this.bindingNavigatorSeparator7.Size = new System.Drawing.Size(6, 25);
            //
            // bindingNavigatorMoveNextItem2
            //
            this.bindingNavigatorMoveNextItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem2.Name = "bindingNavigatorMoveNextItem2";
            this.bindingNavigatorMoveNextItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem2.Text = "Move next";
            //
            // bindingNavigatorMoveLastItem2
            //
            this.bindingNavigatorMoveLastItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem2.Name = "bindingNavigatorMoveLastItem2";
            this.bindingNavigatorMoveLastItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem2.Text = "Move last";
            //
            // bindingNavigatorSeparator8
            //
            this.bindingNavigatorSeparator8.Name = "bindingNavigatorSeparator8";
            this.bindingNavigatorSeparator8.Size = new System.Drawing.Size(6, 25);
            //
            // lblDokterJadwal
            //
            this.lblDokterJadwal.Location = new System.Drawing.Point(10, 10);
            this.lblDokterJadwal.Name = "lblDokterJadwal";
            this.lblDokterJadwal.Size = new System.Drawing.Size(55, 18);
            this.lblDokterJadwal.TabIndex = 0;
            this.lblDokterJadwal.Text = "Dokter:";
            //
            // cmbDokterJadwal
            //
            this.cmbDokterJadwal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDokterJadwal.Location = new System.Drawing.Point(65, 8);
            this.cmbDokterJadwal.Name = "cmbDokterJadwal";
            this.cmbDokterJadwal.Size = new System.Drawing.Size(180, 25);
            this.cmbDokterJadwal.TabIndex = 1;
            this.cmbDokterJadwal.SelectedIndexChanged += new System.EventHandler(this.CmbDokterJadwal_SelectedIndexChanged);
            //
            // lblHari
            //
            this.lblHari.Location = new System.Drawing.Point(260, 10);
            this.lblHari.Name = "lblHari";
            this.lblHari.Size = new System.Drawing.Size(35, 18);
            this.lblHari.TabIndex = 2;
            this.lblHari.Text = "Hari:";
            //
            // cmbHari
            //
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
            //
            // lblMulai
            //
            this.lblMulai.Location = new System.Drawing.Point(410, 10);
            this.lblMulai.Name = "lblMulai";
            this.lblMulai.Size = new System.Drawing.Size(70, 18);
            this.lblMulai.TabIndex = 4;
            this.lblMulai.Text = "Jam Mulai:";
            //
            // dtpMulai
            //
            this.dtpMulai.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpMulai.Location = new System.Drawing.Point(485, 8);
            this.dtpMulai.Name = "dtpMulai";
            this.dtpMulai.ShowUpDown = true;
            this.dtpMulai.Size = new System.Drawing.Size(100, 25);
            this.dtpMulai.TabIndex = 5;
            //
            // lblSelesai
            //
            this.lblSelesai.Location = new System.Drawing.Point(600, 10);
            this.lblSelesai.Name = "lblSelesai";
            this.lblSelesai.Size = new System.Drawing.Size(78, 18);
            this.lblSelesai.TabIndex = 6;
            this.lblSelesai.Text = "Jam Selesai:";
            //
            // dtpSelesai
            //
            this.dtpSelesai.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSelesai.Location = new System.Drawing.Point(680, 8);
            this.dtpSelesai.Name = "dtpSelesai";
            this.dtpSelesai.ShowUpDown = true;
            this.dtpSelesai.Size = new System.Drawing.Size(100, 25);
            this.dtpSelesai.TabIndex = 11;
            //
            // lblKuota
            //
            this.lblKuota.Location = new System.Drawing.Point(800, 10);
            this.lblKuota.Name = "lblKuota";
            this.lblKuota.Size = new System.Drawing.Size(45, 18);
            this.lblKuota.TabIndex = 8;
            this.lblKuota.Text = "Kuota:";
            //
            // nudKuota
            //
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
            //
            // btnTambahJadwal
            //
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
            //
            // btnHapusJadwal
            //
            this.btnHapusJadwal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnHapusJadwal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHapusJadwal.FlatAppearance.BorderSize = 0;
            this.btnHapusJadwal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapusJadwal.ForeColor = System.Drawing.Color.White;
            this.btnHapusJadwal.Location = new System.Drawing.Point(930, 40);
            this.btnHapusJadwal.Name = "btnHapusJadwal";
            this.btnHapusJadwal.Size = new System.Drawing.Size(100, 25);
            this.btnHapusJadwal.TabIndex = 11;
            this.btnHapusJadwal.Text = "Hapus";
            this.btnHapusJadwal.UseVisualStyleBackColor = false;
            this.btnHapusJadwal.Click += new System.EventHandler(this.BtnHapusJadwal_Click);
            //
            // dgvJadwal
            //
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
            //
            // tabReport
            //
            this.tabReport.BackColor = System.Drawing.Color.White;
            this.tabReport.Controls.Add(this._dgvReportBooking);
            this.tabReport.Controls.Add(this.panelReportFilter);
            this.tabReport.Location = new System.Drawing.Point(4, 26);
            this.tabReport.Name = "tabReport";
            this.tabReport.Size = new System.Drawing.Size(1074, 543);
            this.tabReport.TabIndex = 4;
            this.tabReport.Text = "  Report Booking  ";
            //
            // tabImport
            //
            this.tabImport.BackColor = System.Drawing.Color.White;
            this.tabImport.Controls.Add(this._dgvImportDokter);
            this.tabImport.Controls.Add(this.panelImport);
            this.tabImport.Location = new System.Drawing.Point(4, 26);
            this.tabImport.Name = "tabImport";
            this.tabImport.Size = new System.Drawing.Size(1074, 543);
            this.tabImport.TabIndex = 5;
            this.tabImport.Text = "  Import Dokter  ";
            //
            //
            // tabImportJadwal
            //
            this.tabImportJadwal.BackColor = System.Drawing.Color.White;
            this.tabImportJadwal.Controls.Add(this._dgvImportJadwal);
            this.tabImportJadwal.Controls.Add(this.panelImportJadwal);
            this.tabImportJadwal.Location = new System.Drawing.Point(4, 26);
            this.tabImportJadwal.Name = "tabImportJadwal";
            this.tabImportJadwal.Size = new System.Drawing.Size(1074, 543);
            this.tabImportJadwal.TabIndex = 6;
            this.tabImportJadwal.Text = "  Import Jadwal Dokter  ";
            //            //
            // lblChartBookingTitle
            //
            this.lblChartBookingTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblChartBookingTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblChartBookingTitle.Location = new System.Drawing.Point(20, 250);
            this.lblChartBookingTitle.Name = "lblChartBookingTitle";
            this.lblChartBookingTitle.Size = new System.Drawing.Size(300, 28);
            this.lblChartBookingTitle.TabIndex = 1;
            this.lblChartBookingTitle.Text = "Grafik Status Booking";
            //
            // _chartBookingStatus
            //
            this._chartBookingStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this._chartBookingStatus.BackColor = System.Drawing.Color.White;
            this._chartBookingStatus.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this._chartBookingStatus.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.Name = "MainArea";
            this._chartBookingStatus.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend";
            this._chartBookingStatus.Legends.Add(legend1);
            this._chartBookingStatus.Location = new System.Drawing.Point(20, 285);
            this._chartBookingStatus.Name = "_chartBookingStatus";
            this._chartBookingStatus.Size = new System.Drawing.Size(1040, 235);
            this._chartBookingStatus.TabIndex = 2;
            this._chartBookingStatus.Text = "chartBookingStatus";
            //
            // panelReportFilter
            //
            this.panelReportFilter.BackColor = System.Drawing.Color.White;
            this.panelReportFilter.Controls.Add(this.lblReportMulai);
            this.panelReportFilter.Controls.Add(this._dtpReportMulai);
            this.panelReportFilter.Controls.Add(this.lblReportSelesai);
            this.panelReportFilter.Controls.Add(this._dtpReportSelesai);
            this.panelReportFilter.Controls.Add(this.lblReportStatus);
            this.panelReportFilter.Controls.Add(this._cmbReportStatus);
            this.panelReportFilter.Controls.Add(this.btnTampilReport);
            this.panelReportFilter.Controls.Add(this.btnPrintReport);
            this.panelReportFilter.Controls.Add(this.btnExportReport);
            this.panelReportFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelReportFilter.Location = new System.Drawing.Point(0, 0);
            this.panelReportFilter.Name = "panelReportFilter";
            this.panelReportFilter.Size = new System.Drawing.Size(1074, 76);
            this.panelReportFilter.TabIndex = 0;
            //
            // lblReportMulai
            //
            this.lblReportMulai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblReportMulai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblReportMulai.Location = new System.Drawing.Point(25, 26);
            this.lblReportMulai.Name = "lblReportMulai";
            this.lblReportMulai.Size = new System.Drawing.Size(70, 20);
            this.lblReportMulai.TabIndex = 0;
            this.lblReportMulai.Text = "Mulai:";
            //
            // _dtpReportMulai
            //
            this._dtpReportMulai.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this._dtpReportMulai.Location = new System.Drawing.Point(95, 23);
            this._dtpReportMulai.Name = "_dtpReportMulai";
            this._dtpReportMulai.Size = new System.Drawing.Size(120, 25);
            this._dtpReportMulai.TabIndex = 1;
            //
            // lblReportSelesai
            //
            this.lblReportSelesai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblReportSelesai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblReportSelesai.Location = new System.Drawing.Point(235, 26);
            this.lblReportSelesai.Name = "lblReportSelesai";
            this.lblReportSelesai.Size = new System.Drawing.Size(70, 20);
            this.lblReportSelesai.TabIndex = 2;
            this.lblReportSelesai.Text = "Selesai:";
            //
            // _dtpReportSelesai
            //
            this._dtpReportSelesai.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this._dtpReportSelesai.Location = new System.Drawing.Point(305, 23);
            this._dtpReportSelesai.Name = "_dtpReportSelesai";
            this._dtpReportSelesai.Size = new System.Drawing.Size(120, 25);
            this._dtpReportSelesai.TabIndex = 3;
            //
            // lblReportStatus
            //
            this.lblReportStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblReportStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblReportStatus.Location = new System.Drawing.Point(445, 26);
            this.lblReportStatus.Name = "lblReportStatus";
            this.lblReportStatus.Size = new System.Drawing.Size(55, 20);
            this.lblReportStatus.TabIndex = 4;
            this.lblReportStatus.Text = "Status:";
            //
            // _cmbReportStatus
            //
            this._cmbReportStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbReportStatus.Items.AddRange(new object[] {
            "Semua",
            "menunggu",
            "disetujui",
            "ditolak",
            "selesai",
            "batal"});
            this._cmbReportStatus.Location = new System.Drawing.Point(500, 23);
            this._cmbReportStatus.Name = "_cmbReportStatus";
            this._cmbReportStatus.Size = new System.Drawing.Size(140, 25);
            this._cmbReportStatus.TabIndex = 5;
            //
            // btnTampilReport
            //
            this.btnTampilReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnTampilReport.FlatAppearance.BorderSize = 0;
            this.btnTampilReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTampilReport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTampilReport.ForeColor = System.Drawing.Color.White;
            this.btnTampilReport.Location = new System.Drawing.Point(640, 20);
            this.btnTampilReport.Name = "btnTampilReport";
            this.btnTampilReport.Size = new System.Drawing.Size(95, 32);
            this.btnTampilReport.TabIndex = 6;
            this.btnTampilReport.Text = "Tampilkan";
            this.btnTampilReport.UseVisualStyleBackColor = false;
            this.btnTampilReport.Click += new System.EventHandler(this.BtnTampilReport_Click);
            //
            // btnRekapDokter
            //
            this.btnRekapDokter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.btnRekapDokter.FlatAppearance.BorderSize = 0;
            this.btnRekapDokter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRekapDokter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRekapDokter.ForeColor = System.Drawing.Color.White;
            this.btnRekapDokter.Location = new System.Drawing.Point(445, 38);
            this.btnRekapDokter.Name = "btnRekapDokter";
            this.btnRekapDokter.Size = new System.Drawing.Size(120, 30);
            this.btnRekapDokter.TabIndex = 11;
            this.btnRekapDokter.Text = "Rekap Dokter";
            this.btnRekapDokter.UseVisualStyleBackColor = false;
            this.btnRekapDokter.Click += new System.EventHandler(this.BtnRekapDokter_Click);
            //
            // btnPrintReport
            //
            this.btnPrintReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnPrintReport.FlatAppearance.BorderSize = 0;
            this.btnPrintReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintReport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrintReport.ForeColor = System.Drawing.Color.White;
            this.btnPrintReport.Location = new System.Drawing.Point(745, 20);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(105, 32);
            this.btnPrintReport.TabIndex = 8;
            this.btnPrintReport.Text = "Print Preview";
            this.btnPrintReport.UseVisualStyleBackColor = false;
            this.btnPrintReport.Click += new System.EventHandler(this.BtnPrintReport_Click);
            //
            // btnExportReport
            //
            this.btnExportReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnExportReport.FlatAppearance.BorderSize = 0;
            this.btnExportReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportReport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnExportReport.ForeColor = System.Drawing.Color.White;
            this.btnExportReport.Location = new System.Drawing.Point(855, 20);
            this.btnExportReport.Name = "btnExportReport";
            this.btnExportReport.Size = new System.Drawing.Size(100, 32);
            this.btnExportReport.TabIndex = 9;
            this.btnExportReport.Text = "Export CSV";
            this.btnExportReport.UseVisualStyleBackColor = false;
            this.btnExportReport.Click += new System.EventHandler(this.BtnExportReport_Click);
            //
            // _dgvReportBooking
            //
            this._dgvReportBooking.AllowUserToAddRows = false;
            this._dgvReportBooking.AllowUserToDeleteRows = false;
            this._dgvReportBooking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._dgvReportBooking.BackgroundColor = System.Drawing.Color.White;
            this._dgvReportBooking.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._dgvReportBooking.ColumnHeadersHeight = 34;
            this._dgvReportBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this._dgvReportBooking.EnableHeadersVisualStyles = false;
            this._dgvReportBooking.Location = new System.Drawing.Point(0, 76);
            this._dgvReportBooking.Name = "_dgvReportBooking";
            this._dgvReportBooking.ReadOnly = true;
            this._dgvReportBooking.RowHeadersVisible = false;
            this._dgvReportBooking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dgvReportBooking.Size = new System.Drawing.Size(1074, 467);
            this._dgvReportBooking.TabIndex = 1;
            //
            // panelImport
            //
            this.panelImport.BackColor = System.Drawing.Color.White;
            this.panelImport.Controls.Add(this.btnTemplateImportDokter);
            this.panelImport.Controls.Add(this.btnPilihExcelDokter);
            this.panelImport.Controls.Add(this.btnSimpanImportDokter);
            this.panelImport.Controls.Add(this._lblImportStatus);
            this.panelImport.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelImport.Location = new System.Drawing.Point(0, 0);
            this.panelImport.Name = "panelImport";
            this.panelImport.Size = new System.Drawing.Size(1074, 86);
            this.panelImport.TabIndex = 0;
            //
            // btnTemplateImportDokter
            //
            this.btnTemplateImportDokter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnTemplateImportDokter.FlatAppearance.BorderSize = 0;
            this.btnTemplateImportDokter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemplateImportDokter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTemplateImportDokter.ForeColor = System.Drawing.Color.White;
            this.btnTemplateImportDokter.Location = new System.Drawing.Point(20, 18);
            this.btnTemplateImportDokter.Name = "btnTemplateImportDokter";
            this.btnTemplateImportDokter.Size = new System.Drawing.Size(115, 32);
            this.btnTemplateImportDokter.TabIndex = 0;
            this.btnTemplateImportDokter.Text = "Template";
            this.btnTemplateImportDokter.UseVisualStyleBackColor = false;
            this.btnTemplateImportDokter.Click += new System.EventHandler(this.BtnTemplateImportDokter_Click);
            //
            // btnPilihExcelDokter
            //
            this.btnPilihExcelDokter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnPilihExcelDokter.FlatAppearance.BorderSize = 0;
            this.btnPilihExcelDokter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPilihExcelDokter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPilihExcelDokter.ForeColor = System.Drawing.Color.White;
            this.btnPilihExcelDokter.Location = new System.Drawing.Point(145, 18);
            this.btnPilihExcelDokter.Name = "btnPilihExcelDokter";
            this.btnPilihExcelDokter.Size = new System.Drawing.Size(115, 32);
            this.btnPilihExcelDokter.TabIndex = 1;
            this.btnPilihExcelDokter.Text = "Pilih Excel";
            this.btnPilihExcelDokter.UseVisualStyleBackColor = false;
            this.btnPilihExcelDokter.Click += new System.EventHandler(this.BtnPilihExcelDokter_Click);
            //
            // btnSimpanImportDokter
            //
            this.btnSimpanImportDokter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnSimpanImportDokter.FlatAppearance.BorderSize = 0;
            this.btnSimpanImportDokter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpanImportDokter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSimpanImportDokter.ForeColor = System.Drawing.Color.White;
            this.btnSimpanImportDokter.Location = new System.Drawing.Point(280, 18);
            this.btnSimpanImportDokter.Name = "btnSimpanImportDokter";
            this.btnSimpanImportDokter.Size = new System.Drawing.Size(115, 32);
            this.btnSimpanImportDokter.TabIndex = 2;
            this.btnSimpanImportDokter.Text = "Simpan DB";
            this.btnSimpanImportDokter.UseVisualStyleBackColor = false;
            this.btnSimpanImportDokter.Click += new System.EventHandler(this.BtnSimpanImportDokter_Click);
            //
            // _lblImportStatus
            //
            this._lblImportStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this._lblImportStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this._lblImportStatus.Location = new System.Drawing.Point(20, 54);
            this._lblImportStatus.Name = "_lblImportStatus";
            this._lblImportStatus.Size = new System.Drawing.Size(780, 22);
            this._lblImportStatus.TabIndex = 3;
            this._lblImportStatus.Text = "Belum ada file dipilih.";
            //
            // _dgvImportDokter
            //
            this._dgvImportDokter.AllowUserToAddRows = false;
            this._dgvImportDokter.AllowUserToDeleteRows = false;
            this._dgvImportDokter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._dgvImportDokter.BackgroundColor = System.Drawing.Color.White;
            this._dgvImportDokter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._dgvImportDokter.ColumnHeadersHeight = 34;
            this._dgvImportDokter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this._dgvImportDokter.EnableHeadersVisualStyles = false;
            this._dgvImportDokter.Location = new System.Drawing.Point(0, 86);
            this._dgvImportDokter.Name = "_dgvImportDokter";
            this._dgvImportDokter.ReadOnly = true;
            this._dgvImportDokter.RowHeadersVisible = false;
            this._dgvImportDokter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dgvImportDokter.Size = new System.Drawing.Size(1074, 457);
            this._dgvImportDokter.TabIndex = 1;
            //
            // panelImportJadwal
            //
            this.panelImportJadwal.BackColor = System.Drawing.Color.White;
            this.panelImportJadwal.Controls.Add(this.btnTemplateImportJadwal);
            this.panelImportJadwal.Controls.Add(this.btnPilihExcelJadwal);
            this.panelImportJadwal.Controls.Add(this.btnSimpanImportJadwal);
            this.panelImportJadwal.Controls.Add(this._lblImportJadwalStatus);
            this.panelImportJadwal.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelImportJadwal.Location = new System.Drawing.Point(0, 0);
            this.panelImportJadwal.Name = "panelImportJadwal";
            this.panelImportJadwal.Size = new System.Drawing.Size(1074, 86);
            this.panelImportJadwal.TabIndex = 0;
            //
            // btnTemplateImportJadwal
            //
            this.btnTemplateImportJadwal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnTemplateImportJadwal.FlatAppearance.BorderSize = 0;
            this.btnTemplateImportJadwal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemplateImportJadwal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTemplateImportJadwal.ForeColor = System.Drawing.Color.White;
            this.btnTemplateImportJadwal.Location = new System.Drawing.Point(20, 18);
            this.btnTemplateImportJadwal.Name = "btnTemplateImportJadwal";
            this.btnTemplateImportJadwal.Size = new System.Drawing.Size(115, 32);
            this.btnTemplateImportJadwal.TabIndex = 0;
            this.btnTemplateImportJadwal.Text = "Template";
            this.btnTemplateImportJadwal.UseVisualStyleBackColor = false;
            this.btnTemplateImportJadwal.Click += new System.EventHandler(this.BtnTemplateImportJadwal_Click);
            //
            // btnPilihExcelJadwal
            //
            this.btnPilihExcelJadwal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnPilihExcelJadwal.FlatAppearance.BorderSize = 0;
            this.btnPilihExcelJadwal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPilihExcelJadwal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPilihExcelJadwal.ForeColor = System.Drawing.Color.White;
            this.btnPilihExcelJadwal.Location = new System.Drawing.Point(145, 18);
            this.btnPilihExcelJadwal.Name = "btnPilihExcelJadwal";
            this.btnPilihExcelJadwal.Size = new System.Drawing.Size(115, 32);
            this.btnPilihExcelJadwal.TabIndex = 1;
            this.btnPilihExcelJadwal.Text = "Pilih Excel";
            this.btnPilihExcelJadwal.UseVisualStyleBackColor = false;
            this.btnPilihExcelJadwal.Click += new System.EventHandler(this.BtnPilihExcelJadwal_Click);
            //
            // btnSimpanImportJadwal
            //
            this.btnSimpanImportJadwal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnSimpanImportJadwal.FlatAppearance.BorderSize = 0;
            this.btnSimpanImportJadwal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpanImportJadwal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSimpanImportJadwal.ForeColor = System.Drawing.Color.White;
            this.btnSimpanImportJadwal.Location = new System.Drawing.Point(280, 18);
            this.btnSimpanImportJadwal.Name = "btnSimpanImportJadwal";
            this.btnSimpanImportJadwal.Size = new System.Drawing.Size(115, 32);
            this.btnSimpanImportJadwal.TabIndex = 2;
            this.btnSimpanImportJadwal.Text = "Simpan DB";
            this.btnSimpanImportJadwal.UseVisualStyleBackColor = false;
            this.btnSimpanImportJadwal.Click += new System.EventHandler(this.BtnSimpanImportJadwal_Click);
            //
            // _lblImportJadwalStatus
            //
            this._lblImportJadwalStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this._lblImportJadwalStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this._lblImportJadwalStatus.Location = new System.Drawing.Point(20, 54);
            this._lblImportJadwalStatus.Name = "_lblImportJadwalStatus";
            this._lblImportJadwalStatus.Size = new System.Drawing.Size(780, 22);
            this._lblImportJadwalStatus.TabIndex = 3;
            this._lblImportJadwalStatus.Text = "Belum ada file dipilih.";
            //
            // _dgvImportJadwal
            //
            this._dgvImportJadwal.AllowUserToAddRows = false;
            this._dgvImportJadwal.AllowUserToDeleteRows = false;
            this._dgvImportJadwal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._dgvImportJadwal.BackgroundColor = System.Drawing.Color.White;
            this._dgvImportJadwal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._dgvImportJadwal.ColumnHeadersHeight = 34;
            this._dgvImportJadwal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this._dgvImportJadwal.EnableHeadersVisualStyles = false;
            this._dgvImportJadwal.Location = new System.Drawing.Point(0, 86);
            this._dgvImportJadwal.Name = "_dgvImportJadwal";
            this._dgvImportJadwal.ReadOnly = true;
            this._dgvImportJadwal.RowHeadersVisible = false;
            this._dgvImportJadwal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dgvImportJadwal.Size = new System.Drawing.Size(1074, 457);
            this._dgvImportJadwal.TabIndex = 1;
            //
            // lblCardPasien
            //
            this.lblCardPasien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCardPasien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.lblCardPasien.Location = new System.Drawing.Point(15, 14);
            this.lblCardPasien.Name = "lblCardPasien";
            this.lblCardPasien.Size = new System.Drawing.Size(155, 18);
            this.lblCardPasien.TabIndex = 0;
            this.lblCardPasien.Text = "Total Pasien";
            //
            // lblTotalPasien
            //
            this.lblTotalPasien.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblTotalPasien.ForeColor = System.Drawing.Color.White;
            this.lblTotalPasien.Location = new System.Drawing.Point(15, 36);
            this.lblTotalPasien.Name = "lblTotalPasien";
            this.lblTotalPasien.Size = new System.Drawing.Size(155, 50);
            this.lblTotalPasien.TabIndex = 1;
            this.lblTotalPasien.Text = "0";
            //
            // lblCardDokter
            //
            this.lblCardDokter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCardDokter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.lblCardDokter.Location = new System.Drawing.Point(15, 14);
            this.lblCardDokter.Name = "lblCardDokter";
            this.lblCardDokter.Size = new System.Drawing.Size(155, 18);
            this.lblCardDokter.TabIndex = 0;
            this.lblCardDokter.Text = "Dokter Aktif";
            //
            // lblTotalDokter
            //
            this.lblTotalDokter.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblTotalDokter.ForeColor = System.Drawing.Color.White;
            this.lblTotalDokter.Location = new System.Drawing.Point(15, 36);
            this.lblTotalDokter.Name = "lblTotalDokter";
            this.lblTotalDokter.Size = new System.Drawing.Size(155, 50);
            this.lblTotalDokter.TabIndex = 1;
            this.lblTotalDokter.Text = "0";
            //
            // lblCardMenunggu
            //
            this.lblCardMenunggu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCardMenunggu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.lblCardMenunggu.Location = new System.Drawing.Point(15, 14);
            this.lblCardMenunggu.Name = "lblCardMenunggu";
            this.lblCardMenunggu.Size = new System.Drawing.Size(155, 18);
            this.lblCardMenunggu.TabIndex = 0;
            this.lblCardMenunggu.Text = "Booking Menunggu";
            //
            // lblMenunggu
            //
            this.lblMenunggu.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblMenunggu.ForeColor = System.Drawing.Color.White;
            this.lblMenunggu.Location = new System.Drawing.Point(15, 36);
            this.lblMenunggu.Name = "lblMenunggu";
            this.lblMenunggu.Size = new System.Drawing.Size(155, 50);
            this.lblMenunggu.TabIndex = 1;
            this.lblMenunggu.Text = "0";
            //
            // BtnInject
            //
            this.BtnInject.Location = new System.Drawing.Point(878, 2);
            this.BtnInject.Name = "BtnInject";
            this.BtnInject.Size = new System.Drawing.Size(75, 23);
            this.BtnInject.TabIndex = 3;
            this.BtnInject.Text = "Inject";
            this.BtnInject.UseVisualStyleBackColor = true;
            this.BtnInject.Click += new System.EventHandler(this.BtnInject_Click);
            //
            // BtnResetInject
            //
            this.BtnResetInject.Location = new System.Drawing.Point(878, 31);
            this.BtnResetInject.Name = "BtnResetInject";
            this.BtnResetInject.Size = new System.Drawing.Size(75, 23);
            this.BtnResetInject.TabIndex = 4;
            this.BtnResetInject.Text = "Reset";
            this.BtnResetInject.UseVisualStyleBackColor = true;
            this.BtnResetInject.Click += new System.EventHandler(this.BtnResetInject_Click);
            //
            // FormDashboardAdmin
            //
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
            this.panelFilterBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).EndInit();
            this.tabDokter.ResumeLayout(false);
            this.panelFormDokter.ResumeLayout(false);
            this.panelFormDokter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDokter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoDokter)).EndInit();
            this.tabJadwal.ResumeLayout(false);
            this.panelFormJadwal.ResumeLayout(false);
            this.panelFormJadwal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).EndInit();
            this.bindingNavigator3.ResumeLayout(false);
            this.bindingNavigator3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKuota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJadwal)).EndInit();
            this.tabReport.ResumeLayout(false);
            this.panelReportFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dgvReportBooking)).EndInit();
            this.tabImport.ResumeLayout(false);
            this.panelImport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dgvImportDokter)).EndInit();
            this.tabImportJadwal.ResumeLayout(false);
            this.panelImportJadwal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dgvImportJadwal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Panel panelTop;
        internal System.Windows.Forms.Label lblAppTitle;
        internal System.Windows.Forms.Label lblWelcome;
        internal System.Windows.Forms.Button btnLogout;
        internal System.Windows.Forms.TabControl tabControl;
        internal System.Windows.Forms.TabPage tabSummary;
        internal System.Windows.Forms.Panel panelCards;
        internal System.Windows.Forms.Panel cardPasien;
        internal System.Windows.Forms.Label lblCardPasien;
        internal System.Windows.Forms.Label lblTotalPasien;
        internal System.Windows.Forms.Panel cardDokter;
        internal System.Windows.Forms.Label lblCardDokter;
        internal System.Windows.Forms.Label lblTotalDokter;
        internal System.Windows.Forms.Panel cardMenunggu;
        internal System.Windows.Forms.Label lblCardMenunggu;
        internal System.Windows.Forms.Label lblMenunggu;
        internal System.Windows.Forms.TabPage tabBooking;
        internal System.Windows.Forms.Panel panelFilterBar;
        internal System.Windows.Forms.Label lblFilter;
        internal System.Windows.Forms.ComboBox cmbFilter;
        internal System.Windows.Forms.Button btnSetujui;
        internal System.Windows.Forms.Button btnTolak;
        internal System.Windows.Forms.Button btnSelesai;
        internal System.Windows.Forms.DataGridView dgvBooking;
        internal System.Windows.Forms.TabPage tabDokter;
        internal System.Windows.Forms.Panel panelFormDokter;
        internal System.Windows.Forms.Label lblNamaDokter;
        internal System.Windows.Forms.TextBox txtNamaDokter;
        internal System.Windows.Forms.Label lblSpesialisasi;
        internal System.Windows.Forms.TextBox txtSpesialisasi;
        internal System.Windows.Forms.Label lblNoHPDokterLbl;
        internal System.Windows.Forms.TextBox txtNoHPDokter;
        internal System.Windows.Forms.Button btnTambahDokter;
        internal System.Windows.Forms.Button btnNonaktifDokter;
        internal System.Windows.Forms.TextBox txtCariDokter;
        internal System.Windows.Forms.Label lblCariDokter;
        internal System.Windows.Forms.TabPage tabJadwal;
        internal System.Windows.Forms.TabPage tabReport;
        internal System.Windows.Forms.TabPage tabImport;
        internal System.Windows.Forms.Panel panelFormJadwal;
        internal System.Windows.Forms.Label lblDokterJadwal;
        internal System.Windows.Forms.ComboBox cmbDokterJadwal;
        internal System.Windows.Forms.Label lblHari;
        internal System.Windows.Forms.ComboBox cmbHari;
        internal System.Windows.Forms.Label lblMulai;
        internal System.Windows.Forms.DateTimePicker dtpMulai;
        internal System.Windows.Forms.Label lblSelesai;
        internal System.Windows.Forms.DateTimePicker dtpSelesai;
        internal System.Windows.Forms.Label lblKuota;
        internal System.Windows.Forms.NumericUpDown nudKuota;
        internal System.Windows.Forms.DataGridView dgvJadwal;
        internal System.Windows.Forms.DataGridView dgvDokter;
        internal System.Windows.Forms.Button btnTambahJadwal;
        internal System.Windows.Forms.Button btnHapusJadwal;
        internal System.Windows.Forms.BindingNavigator bindingNavigator1;
        internal System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        internal System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        internal System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        internal System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        internal System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        internal System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        internal System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        internal System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        internal System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        internal System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        internal System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        internal System.Windows.Forms.BindingNavigator bindingNavigator2;
        internal System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
        internal System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        internal System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
        internal System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        internal System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        internal System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        internal System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        internal System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        internal System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        internal System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        internal System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        internal System.Windows.Forms.BindingNavigator bindingNavigator3;
        internal System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem2;
        internal System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem2;
        internal System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem2;
        internal System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem2;
        internal System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem2;
        internal System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator6;
        internal System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem2;
        internal System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator7;
        internal System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem2;
        internal System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem2;
        internal System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator8;
        internal System.Windows.Forms.Button BtnResetInject;
        internal System.Windows.Forms.Button BtnInject;
        internal System.Windows.Forms.Label lblChartBookingTitle;
        internal System.Windows.Forms.DataVisualization.Charting.Chart _chartBookingStatus;
        internal System.Windows.Forms.Panel panelReportFilter;
        internal System.Windows.Forms.Label lblReportMulai;
        internal System.Windows.Forms.DateTimePicker _dtpReportMulai;
        internal System.Windows.Forms.Label lblReportSelesai;
        internal System.Windows.Forms.DateTimePicker _dtpReportSelesai;
        internal System.Windows.Forms.Label lblReportStatus;
        internal System.Windows.Forms.ComboBox _cmbReportStatus;
        internal System.Windows.Forms.Button btnTampilReport;
        internal System.Windows.Forms.Button btnRekapDokter;
        internal System.Windows.Forms.Button btnUploadFotoDokter;
        internal System.Windows.Forms.PictureBox pbFotoDokter;
        internal System.Windows.Forms.Button btnPrintReport;
        internal System.Windows.Forms.Button btnExportReport;
        internal System.Windows.Forms.DataGridView _dgvReportBooking;
        internal System.Windows.Forms.Panel panelImport;
        internal System.Windows.Forms.Button btnTemplateImportDokter;
        internal System.Windows.Forms.Button btnPilihExcelDokter;
        internal System.Windows.Forms.Button btnSimpanImportDokter;
        internal System.Windows.Forms.Label _lblImportStatus;
        internal System.Windows.Forms.DataGridView _dgvImportDokter;
        internal System.Windows.Forms.TabPage tabImportJadwal;
        internal System.Windows.Forms.Panel panelImportJadwal;
        internal System.Windows.Forms.Button btnTemplateImportJadwal;
        internal System.Windows.Forms.Button btnPilihExcelJadwal;
        internal System.Windows.Forms.Button btnSimpanImportJadwal;
        internal System.Windows.Forms.Label _lblImportJadwalStatus;
        internal System.Windows.Forms.DataGridView _dgvImportJadwal;
    }
}

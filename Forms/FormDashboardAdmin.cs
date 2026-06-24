using BookingKontrolPasien.Helpers;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace BookingKontrolPasien.Forms
{
    public partial class FormDashboardAdmin : Form
    {
        internal readonly BindingSource bsBooking = new BindingSource();
        internal readonly BindingSource bsDokter = new BindingSource();
        internal readonly BindingSource bsJadwal = new BindingSource();
        internal readonly DAL _dal = new DAL();
        internal DataTable _importDokterTable;
        internal DataTable _importJadwalTable;
        internal DataTable _reportTable;
        internal int _reportPrintRowIndex;

        private readonly DashboardAdminLogic _logic;

        private bool IsInDesigner =>
            DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime;

        private bool CanRunLogic =>
            !IsInDesigner && _logic != null;

        public FormDashboardAdmin()
        {
            InitializeComponent();
            RestoreTabContentLayout();
            ApplyResponsiveLayout();
            UpdateDashboardLayout();
            BindingNavigatorIconHelper.ApplyTo(this);
            _logic = new DashboardAdminLogic(this);

            bindingNavigator1.BindingSource = bsBooking;
            bindingNavigator2.BindingSource = bsDokter;
            bindingNavigator3.BindingSource = bsJadwal;

            if (IsInDesigner)
                return;

            _logic.SetupCard(cardPasien, lblCardPasien, "Total Pasien", lblTotalPasien, new Point(20, 20), Color.FromArgb(41, 128, 185));
            _logic.SetupCard(cardDokter, lblCardDokter, "Dokter Aktif", lblTotalDokter, new Point(220, 20), Color.FromArgb(39, 174, 96));
            _logic.SetupCard(cardMenunggu, lblCardMenunggu, "Booking Menunggu", lblMenunggu, new Point(420, 20), Color.FromArgb(230, 126, 34));
        }

        private void ApplyResponsiveLayout()
        {
            MinimumSize = new Size(980, 600);

            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnInject.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnResetInject.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            tabSummary.AutoScroll = true;
            tabBooking.AutoScroll = true;
            tabDokter.AutoScroll = true;
            tabJadwal.AutoScroll = true;
            tabReport.AutoScroll = true;
            tabImport.AutoScroll = true;
            tabImportJadwal.AutoScroll = true;

            panelCards.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _chartBookingStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            panelFilterBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            bindingNavigator1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dgvBooking.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            panelFormDokter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            bindingNavigator2.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnTambahDokter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNonaktifDokter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbFotoDokter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dgvDokter.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            panelFormJadwal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            bindingNavigator3.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnTambahJadwal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnHapusJadwal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dgvJadwal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            _dgvReportBooking.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            _lblImportStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _dgvImportDokter.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            _lblImportJadwalStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _dgvImportJadwal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            Resize += FormDashboardAdmin_Resize;
            tabControl.Resize += TabControl_Resize;
        }

        private void FormDashboardAdmin_Resize(object sender, EventArgs e)
        {
            UpdateDashboardLayout();
        }

        private void TabControl_Resize(object sender, EventArgs e)
        {
            UpdateDashboardLayout();
        }

        private void UpdateDashboardLayout()
        {
            ResizeGridBelowPanel(tabBooking, panelFilterBar, dgvBooking, 8);
            ResizeGridBelowPanel(tabDokter, panelFormDokter, dgvDokter, 8);
            ResizeGridBelowPanel(tabJadwal, panelFormJadwal, dgvJadwal, 8);
            ResizeGridBelowPanel(tabReport, panelReportFilter, _dgvReportBooking, 8);
            ResizeGridBelowPanel(tabImport, panelImport, _dgvImportDokter, 8);
            ResizeGridBelowPanel(tabImportJadwal, panelImportJadwal, _dgvImportJadwal, 8);
        }

        private static void ResizeGridBelowPanel(
            Control page,
            Control topPanel,
            DataGridView grid,
            int gap)
        {
            if (page == null || topPanel == null || grid == null)
                return;

            int margin = 10;
            int top = Math.Max(topPanel.Bottom + gap, margin);
            int width = Math.Max(page.ClientSize.Width - (margin * 2), 100);
            int height = Math.Max(page.ClientSize.Height - top - margin, 120);

            grid.SetBounds(margin, top, width, height);
            grid.ScrollBars = ScrollBars.Both;
            grid.ColumnHeadersVisible = true;
        }

        private void RestoreTabContentLayout()
        {
            EnsureChild(tabSummary, panelCards);
            EnsureChild(tabSummary, lblChartBookingTitle);
            EnsureChild(tabSummary, _chartBookingStatus);

            EnsureChild(tabBooking, panelFilterBar);
            EnsureChild(tabBooking, dgvBooking);

            EnsureChild(tabDokter, panelFormDokter);
            EnsureChild(tabDokter, dgvDokter);

            EnsureChild(tabJadwal, panelFormJadwal);
            EnsureChild(tabJadwal, dgvJadwal);

            EnsureChild(tabReport, _dgvReportBooking);
            EnsureChild(tabReport, panelReportFilter);

            EnsureChild(tabImport, _dgvImportDokter);
            EnsureChild(tabImport, panelImport);
            EnsureChild(tabImportJadwal, _dgvImportJadwal);
            EnsureChild(tabImportJadwal, panelImportJadwal);

            panelCards.Visible = true;
            panelFilterBar.Visible = true;
            panelFormDokter.Visible = true;
            panelFormJadwal.Visible = true;
            panelReportFilter.Visible = true;
            panelImport.Visible = true;
            if (panelImportJadwal != null) panelImportJadwal.Visible = true;

            dgvBooking.Visible = true;
            dgvDokter.Visible = true;
            dgvJadwal.Visible = true;
            _dgvReportBooking.Visible = true;
            _dgvImportDokter.Visible = true;
            if (_dgvImportJadwal != null) _dgvImportJadwal.Visible = true;

            panelCards.BringToFront();
            panelFilterBar.BringToFront();
            panelFormDokter.BringToFront();
            panelFormJadwal.BringToFront();
            panelReportFilter.BringToFront();
            panelImport.BringToFront();
            panelImportJadwal?.BringToFront();
        }

        private static void EnsureChild(Control parent, Control child)
        {
            if (parent == null || child == null)
                return;

            if (child.Parent != parent)
            {
                child.Parent?.Controls.Remove(child);
                parent.Controls.Add(child);
            }
        }

        private void FormDashboardAdmin_Load(object sender, EventArgs e)
        {
            if (IsInDesigner)
                return;

            lblWelcome.Text = "Selamat datang, Administrator";

            _logic.UpdateExpiredBookings();
            cmbFilter.SelectedIndex = 0;
            _dtpReportMulai.Value = DateTime.Today.AddMonths(-1);
            _dtpReportSelesai.Value = DateTime.Today;
            _cmbReportStatus.SelectedIndex = 0;

            _logic.LoadSummary();
            _logic.LoadDokterCombo();
            _logic.LoadBooking();
            _logic.LoadDokter();
            _logic.LoadJadwal();

            dgvBooking.BringToFront();
            dgvDokter.BringToFront();
            dgvJadwal.BringToFront();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (!CanRunLogic)
                return;

            _logic.LoadChartOnFormLoad();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Hide();
            new FormLogin().Show();
        }

        private void FormDashboardAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void PanelCards_Paint(object sender, PaintEventArgs e) => _logic?.PanelCards_Paint(sender, e);
        private void PanelFormJadwal_Paint(object sender, PaintEventArgs e) => _logic?.PanelFormJadwal_Paint(sender, e);
        private void BtnSetujui_Click(object sender, EventArgs e) { if (CanRunLogic) _logic.BtnSetujui_Click(sender, e); }
        private void BtnTolak_Click(object sender, EventArgs e) { if (CanRunLogic) _logic.BtnTolak_Click(sender, e); }
        private void BtnSelesai_Click(object sender, EventArgs e) { if (CanRunLogic) _logic.BtnSelesai_Click(sender, e); }
        private void CmbFilter_SelectedIndexChanged(object sender, EventArgs e) { if (CanRunLogic) _logic.CmbFilter_SelectedIndexChanged(sender, e); }
        private void BtnInject_Click(object sender, EventArgs e) { if (CanRunLogic) _logic.BtnInject_Click(sender, e); }
        private void BtnResetInject_Click(object sender, EventArgs e) { if (CanRunLogic) _logic.BtnResetInject_Click(sender, e); }
        private void DgvDokter_SelectionChanged(object sender, EventArgs e) { if (CanRunLogic) _logic.DgvDokter_SelectionChanged(sender, e); }
        private void BtnUploadFotoDokter_Click(object sender, EventArgs e) { if (CanRunLogic) _logic.BtnUploadFotoDokter_Click(sender, e); }
        private void BtnTambahDokter_Click(object sender, EventArgs e) { if (CanRunLogic) _logic.BtnTambahDokter_Click(sender, e); }
        private void BtnNonaktifDokter_Click(object sender, EventArgs e) { if (CanRunLogic) _logic.BtnNonaktifDokter_Click(sender, e); }
        private void BtnTambahJadwal_Click(object sender, EventArgs e) { if (CanRunLogic) _logic.BtnTambahJadwal_Click(sender, e); }
        private void BtnHapusJadwal_Click(object sender, EventArgs e) { if (CanRunLogic) _logic.BtnHapusJadwal_Click(sender, e); }
        private void TabControl_SelectedIndexChanged(object sender, EventArgs e) { if (CanRunLogic) _logic.TabControl_SelectedIndexChanged(sender, e); }
        private void CmbDokterJadwal_SelectedIndexChanged(object sender, EventArgs e) { if (CanRunLogic) _logic.CmbDokterJadwal_SelectedIndexChanged(sender, e); }
        private void TabDokter_Click(object sender, EventArgs e) { if (CanRunLogic) _logic.TabDokter_Click(sender, e); }
        private void TxtCariDokter_TextChanged(object sender, EventArgs e) { if (CanRunLogic) _logic.TxtCariDokter_TextChanged(sender, e); }
        private void TabControl_ReportSummarySelectedIndexChanged(object sender, EventArgs e) { if (CanRunLogic) _logic.TabControl_ReportSummarySelectedIndexChanged(sender, e); }
        private void BtnTemplateImportDokter_Click(object sender, EventArgs e) { if (CanRunLogic) _logic.BtnTemplateImportDokter_Click(sender, e); }
        private void BtnPilihExcelDokter_Click(object sender, EventArgs e) { if (CanRunLogic) _logic.BtnPilihExcelDokter_Click(sender, e); }
        private void BtnSimpanImportDokter_Click(object sender, EventArgs e) { if (CanRunLogic) _logic.BtnSimpanImportDokter_Click(sender, e); }
        private void BtnTemplateImportJadwal_Click(object sender, EventArgs e) { if (CanRunLogic) _logic.BtnTemplateImportJadwal_Click(sender, e); }
        private void BtnPilihExcelJadwal_Click(object sender, EventArgs e) { if (CanRunLogic) _logic.BtnPilihExcelJadwal_Click(sender, e); }
        private void BtnSimpanImportJadwal_Click(object sender, EventArgs e) { if (CanRunLogic) _logic.BtnSimpanImportJadwal_Click(sender, e); }
        private void BtnTampilReport_Click(object sender, EventArgs e) { if (CanRunLogic) _logic.BtnTampilReport_Click(sender, e); }
        private void BtnRekapDokter_Click(object sender, EventArgs e) { if (CanRunLogic) _logic.BtnRekapDokter_Click(sender, e); }
        private void BtnPrintReport_Click(object sender, EventArgs e) { if (CanRunLogic) _logic.BtnPrintReport_Click(sender, e); }
        private void BtnExportReport_Click(object sender, EventArgs e) { if (CanRunLogic) _logic.BtnExportReport_Click(sender, e); }
    }
}

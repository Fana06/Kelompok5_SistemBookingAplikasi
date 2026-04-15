namespace SistemBookingPasien_5.Forms
{
    partial class FormAdminDashboard
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnRefreshAll;
        private System.Windows.Forms.TabControl tabMain;

        private System.Windows.Forms.TabPage tabBooking;
        private System.Windows.Forms.DataGridView dgvBooking;
        private System.Windows.Forms.Button btnSetujui, btnTolak, btnSelesai;

        private System.Windows.Forms.TabPage tabDokter;
        private System.Windows.Forms.DataGridView dgvDokter;
        private System.Windows.Forms.Button btnTambahDokter, btnEditDokter, btnHapusDokter, btnToggleAktif;

        private System.Windows.Forms.TabPage tabJadwal;
        private System.Windows.Forms.DataGridView dgvJadwal;
        private System.Windows.Forms.Button btnTambahJadwal, btnHapusJadwal;

        private System.Windows.Forms.TabPage tabPasien;
        private System.Windows.Forms.DataGridView dgvPasien;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private System.Windows.Forms.DataGridView CreateDGV()
        {
            var dgv = new System.Windows.Forms.DataGridView();
            dgv.BackgroundColor     = System.Drawing.Color.White;
            dgv.BorderStyle         = System.Windows.Forms.BorderStyle.None;
            dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgv.ReadOnly            = true;
            dgv.SelectionMode       = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgv.AllowUserToAddRows  = false;
            dgv.RowHeadersVisible   = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(0, 102, 204);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dgv.EnableHeadersVisualStyles = false;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(240, 245, 255);
            return dgv;
        }

        private System.Windows.Forms.Button CreateBtn(string text, System.Drawing.Color color)
        {
            var btn = new System.Windows.Forms.Button();
            btn.Text      = text;
            btn.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btn.BackColor = color;
            btn.ForeColor = System.Drawing.Color.White;
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Size      = new System.Drawing.Size(140, 36);
            btn.Cursor    = System.Windows.Forms.Cursors.Hand;
            return btn;
        }

        private void InitializeComponent()
        {
            this.panelTop    = new System.Windows.Forms.Panel();
            this.lblTitle    = new System.Windows.Forms.Label();
            this.btnLogout   = new System.Windows.Forms.Button();
            this.btnRefreshAll = new System.Windows.Forms.Button();
            this.tabMain     = new System.Windows.Forms.TabControl();
            this.tabBooking  = new System.Windows.Forms.TabPage();
            this.tabDokter   = new System.Windows.Forms.TabPage();
            this.tabJadwal   = new System.Windows.Forms.TabPage();
            this.tabPasien   = new System.Windows.Forms.TabPage();
            this.dgvBooking  = CreateDGV();
            this.dgvDokter   = CreateDGV();
            this.dgvJadwal   = CreateDGV();
            this.dgvPasien   = CreateDGV();


            this.btnSetujui = CreateBtn("✅ Setujui",  System.Drawing.Color.FromArgb(0, 153, 76));
            this.btnTolak   = CreateBtn("❌ Tolak",    System.Drawing.Color.FromArgb(220, 53, 69));
            this.btnSelesai = CreateBtn("🏁 Selesai",  System.Drawing.Color.FromArgb(0, 102, 153));
            this.btnSetujui.Click += new System.EventHandler(this.btnSetujui_Click);
            this.btnTolak.Click   += new System.EventHandler(this.btnTolak_Click);
            this.btnSelesai.Click += new System.EventHandler(this.btnSelesai_Click);


            this.btnTambahDokter = CreateBtn("➕ Tambah",   System.Drawing.Color.FromArgb(0, 153, 76));
            this.btnEditDokter   = CreateBtn("✏️ Edit",      System.Drawing.Color.FromArgb(255, 153, 0));
            this.btnHapusDokter  = CreateBtn("🗑 Hapus",    System.Drawing.Color.FromArgb(220, 53, 69));
            this.btnToggleAktif  = CreateBtn("🔄 Aktif/Non", System.Drawing.Color.FromArgb(100, 60, 150));
            this.btnTambahDokter.Click += new System.EventHandler(this.btnTambahDokter_Click);
            this.btnEditDokter.Click   += new System.EventHandler(this.btnEditDokter_Click);
            this.btnHapusDokter.Click  += new System.EventHandler(this.btnHapusDokter_Click);
            this.btnToggleAktif.Click  += new System.EventHandler(this.btnToggleAktif_Click);


            this.btnTambahJadwal = CreateBtn("➕ Tambah Jadwal", System.Drawing.Color.FromArgb(0, 153, 76));
            this.btnHapusJadwal  = CreateBtn("🗑 Hapus Jadwal",  System.Drawing.Color.FromArgb(220, 53, 69));
            this.btnTambahJadwal.Click += new System.EventHandler(this.btnTambahJadwal_Click);
            this.btnHapusJadwal.Click  += new System.EventHandler(this.btnHapusJadwal_Click);


            this.Text            = "Dashboard Admin - Sistem Booking Kontrol Pasien";
            this.Size            = new System.Drawing.Size(1100, 720);
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor       = System.Drawing.Color.FromArgb(245, 247, 250);


            this.panelTop.BackColor = System.Drawing.Color.FromArgb(20, 30, 50);
            this.panelTop.Dock      = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Height    = 65;

            this.lblTitle.Text      = "⚙️  ADMIN — Sistem Booking Kontrol Pasien";
            this.lblTitle.Font      = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location  = new System.Drawing.Point(20, 15);
            this.lblTitle.Size      = new System.Drawing.Size(600, 35);

            this.btnRefreshAll.Text      = "🔄 Refresh";
            this.btnRefreshAll.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefreshAll.BackColor = System.Drawing.Color.FromArgb(60, 80, 120);
            this.btnRefreshAll.ForeColor = System.Drawing.Color.White;
            this.btnRefreshAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshAll.FlatAppearance.BorderSize = 0;
            this.btnRefreshAll.Location  = new System.Drawing.Point(850, 15);
            this.btnRefreshAll.Size      = new System.Drawing.Size(100, 35);
            this.btnRefreshAll.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshAll.Click    += new System.EventHandler(this.btnRefreshAll_Click);

            this.btnLogout.Text      = "🚪 Logout";
            this.btnLogout.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(180, 40, 40);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.Location  = new System.Drawing.Point(965, 15);
            this.btnLogout.Size      = new System.Drawing.Size(100, 35);
            this.btnLogout.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Click    += new System.EventHandler(this.btnLogout_Click);

            this.panelTop.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblTitle, this.btnRefreshAll, this.btnLogout });


            this.tabMain.Location    = new System.Drawing.Point(10, 75);
            this.tabMain.Size        = new System.Drawing.Size(1070, 600);
            this.tabMain.Font        = new System.Drawing.Font("Segoe UI", 10F);
            this.tabMain.TabPages.AddRange(new[] { tabBooking, tabDokter, tabJadwal, tabPasien });

            this.tabBooking.Text    = " 📋 Booking ";
            this.tabBooking.Padding = new System.Windows.Forms.Padding(5);
            var panelBtnBooking = new System.Windows.Forms.FlowLayoutPanel();
            panelBtnBooking.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelBtnBooking.Height = 50;
            panelBtnBooking.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            panelBtnBooking.Controls.AddRange(new System.Windows.Forms.Control[] { btnSetujui, btnTolak, btnSelesai });
            panelBtnBooking.Padding = new System.Windows.Forms.Padding(5);
            this.dgvBooking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabBooking.Controls.AddRange(new System.Windows.Forms.Control[] { this.dgvBooking, panelBtnBooking });


            this.tabDokter.Text    = " 👨‍⚕️ Dokter ";
            var panelBtnDokter = new System.Windows.Forms.FlowLayoutPanel();
            panelBtnDokter.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelBtnDokter.Height = 50;
            panelBtnDokter.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            panelBtnDokter.Controls.AddRange(new System.Windows.Forms.Control[] { btnTambahDokter, btnEditDokter, btnHapusDokter, btnToggleAktif });
            panelBtnDokter.Padding = new System.Windows.Forms.Padding(5);
            this.dgvDokter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDokter.Controls.AddRange(new System.Windows.Forms.Control[] { this.dgvDokter, panelBtnDokter });


            this.tabJadwal.Text    = " 🗓 Jadwal ";
            var panelBtnJadwal = new System.Windows.Forms.FlowLayoutPanel();
            panelBtnJadwal.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelBtnJadwal.Height = 50;
            panelBtnJadwal.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            panelBtnJadwal.Controls.AddRange(new System.Windows.Forms.Control[] { btnTambahJadwal, btnHapusJadwal });
            panelBtnJadwal.Padding = new System.Windows.Forms.Padding(5);
            this.dgvJadwal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabJadwal.Controls.AddRange(new System.Windows.Forms.Control[] { this.dgvJadwal, panelBtnJadwal });

            this.tabPasien.Text = " 🧑‍🤝‍🧑 Pasien ";
            this.dgvPasien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPasien.Controls.Add(this.dgvPasien);

            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.panelTop, this.tabMain });
            this.ResumeLayout(false);
        }
    }
}

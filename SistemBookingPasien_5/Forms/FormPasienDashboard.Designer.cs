namespace SistemBookingPasien_5.Forms
{
    partial class FormPasienDashboard
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Button btnBookingBaru;
        private System.Windows.Forms.Button btnProfil;
        private System.Windows.Forms.Button btnBatalBooking;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataGridView dgvBooking;
        private System.Windows.Forms.Label lblRiwayat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelTop       = new System.Windows.Forms.Panel();
            this.lblTitle       = new System.Windows.Forms.Label();
            this.lblWelcome     = new System.Windows.Forms.Label();
            this.panelSide      = new System.Windows.Forms.Panel();
            this.btnBookingBaru = new System.Windows.Forms.Button();
            this.btnProfil      = new System.Windows.Forms.Button();
            this.btnBatalBooking= new System.Windows.Forms.Button();
            this.btnRefresh     = new System.Windows.Forms.Button();
            this.btnLogout      = new System.Windows.Forms.Button();
            this.dgvBooking     = new System.Windows.Forms.DataGridView();
            this.lblRiwayat     = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).BeginInit();
            this.SuspendLayout();

            this.Text            = "Dashboard Pasien - Sistem Booking Kontrol Pasien";
            this.Size            = new System.Drawing.Size(1000, 680);
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor       = System.Drawing.Color.FromArgb(245, 247, 250);

            this.panelTop.BackColor = System.Drawing.Color.FromArgb(0, 102, 204);
            this.panelTop.Dock      = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Height    = 70;

            this.lblTitle.Text      = "🏥 Sistem Booking Kontrol Pasien";
            this.lblTitle.Font      = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location  = new System.Drawing.Point(20, 15);
            this.lblTitle.Size      = new System.Drawing.Size(500, 40);

            this.lblWelcome.Text      = "";
            this.lblWelcome.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.lblWelcome.ForeColor = System.Drawing.Color.LightCyan;
            this.lblWelcome.Location  = new System.Drawing.Point(530, 25);
            this.lblWelcome.Size      = new System.Drawing.Size(430, 25);
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.panelTop.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblTitle, this.lblWelcome });
            this.panelSide.BackColor = System.Drawing.Color.FromArgb(30, 40, 60);
            this.panelSide.Dock      = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Width     = 200;

            System.Action<System.Windows.Forms.Button, string, int, System.Drawing.Color> addBtn =
                (btn, txt, yPos, color) =>
            {
                btn.Text      = txt;
                btn.Font      = new System.Drawing.Font("Segoe UI", 10F);
                btn.ForeColor = System.Drawing.Color.White;
                btn.BackColor = color;
                btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Location  = new System.Drawing.Point(10, yPos);
                btn.Size      = new System.Drawing.Size(180, 45);
                btn.Cursor    = System.Windows.Forms.Cursors.Hand;
                btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                btn.Padding   = new System.Windows.Forms.Padding(10, 0, 0, 0);
            };

            addBtn(this.btnBookingBaru,  "➕ Booking Baru",       90,  System.Drawing.Color.FromArgb(0, 153, 76));
            addBtn(this.btnProfil,       "👤 Profil Saya",        145, System.Drawing.Color.FromArgb(0, 102, 153));
            addBtn(this.btnBatalBooking, "❌ Batalkan Booking",   200, System.Drawing.Color.FromArgb(180, 60, 40));
            addBtn(this.btnRefresh,      "🔄 Refresh",            255, System.Drawing.Color.FromArgb(60, 80, 100));
            addBtn(this.btnLogout,       "🚪 Logout",             500, System.Drawing.Color.FromArgb(100, 30, 30));

            this.btnBookingBaru.Click  += new System.EventHandler(this.btnBookingBaru_Click);
            this.btnProfil.Click       += new System.EventHandler(this.btnProfil_Click);
            this.btnBatalBooking.Click += new System.EventHandler(this.btnBatalBooking_Click);
            this.btnRefresh.Click      += new System.EventHandler(this.btnRefresh_Click);
            this.btnLogout.Click       += new System.EventHandler(this.btnLogout_Click);

            this.panelSide.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.btnBookingBaru, this.btnProfil, this.btnBatalBooking, this.btnRefresh, this.btnLogout
            });

            this.lblRiwayat.Text      = "📋 Riwayat Booking Saya";
            this.lblRiwayat.Font      = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblRiwayat.ForeColor = System.Drawing.Color.FromArgb(30, 40, 60);
            this.lblRiwayat.Location  = new System.Drawing.Point(220, 80);
            this.lblRiwayat.Size      = new System.Drawing.Size(350, 30);

            this.dgvBooking.Location            = new System.Drawing.Point(210, 120);
            this.dgvBooking.Size                = new System.Drawing.Size(760, 510);
            this.dgvBooking.BackgroundColor     = System.Drawing.Color.White;
            this.dgvBooking.BorderStyle         = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvBooking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooking.ReadOnly            = true;
            this.dgvBooking.SelectionMode       = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooking.AllowUserToAddRows  = false;
            this.dgvBooking.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(0, 102, 204);
            this.dgvBooking.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBooking.ColumnHeadersDefaultCellStyle.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvBooking.EnableHeadersVisualStyles = false;
            this.dgvBooking.RowHeadersVisible         = false;
            this.dgvBooking.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(240, 245, 255);

            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.panelTop, this.panelSide, this.lblRiwayat, this.dgvBooking
            });
            this.panelTop.ResumeLayout(false);
            this.panelSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).EndInit();
            this.ResumeLayout(false);
        }
    }
}

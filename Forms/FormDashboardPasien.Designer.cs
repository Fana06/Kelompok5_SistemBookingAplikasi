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
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabRiwayat = new System.Windows.Forms.TabPage();
            this.panelRiwayatBar = new System.Windows.Forms.Panel();
            this.txtCariRiwayat = new System.Windows.Forms.TextBox();
            this.lblCariRiwayat = new System.Windows.Forms.Label();
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

            this.panelTop.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabRiwayat.SuspendLayout();
            this.tabBookingBaru.SuspendLayout();
            this.tabProfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.dgvRiwayat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.dgvJadwal).BeginInit();
            this.SuspendLayout();

            this.Text = "Dashboard Pasien - Sistem Booking Kontrol Pasien";
            this.Size = new System.Drawing.Size(1000, 640);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Height = 60;
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.panelTop.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblAppTitle, this.lblWelcome, this.btnLogout });

            this.lblAppTitle.Text = "🏥 Portal Pasien";
            this.lblAppTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblAppTitle.ForeColor = System.Drawing.Color.White;
            this.lblAppTitle.Location = new System.Drawing.Point(20, 15);
            this.lblAppTitle.Size = new System.Drawing.Size(300, 30);

            this.lblWelcome.Text = "";
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(200, 240, 200);
            this.lblWelcome.Location = new System.Drawing.Point(340, 20);
            this.lblWelcome.Size = new System.Drawing.Size(420, 22);

            this.btnLogout.Text = "Logout";
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.Location = new System.Drawing.Point(880, 15);
            this.btnLogout.Size = new System.Drawing.Size(90, 32);
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControl.Controls.AddRange(new System.Windows.Forms.TabPage[] {
                this.tabRiwayat, this.tabBookingBaru, this.tabProfil });
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);

            this.tabRiwayat.Text = "  Riwayat Booking  ";

            this.panelRiwayatBar.Location = new System.Drawing.Point(10, 10);
            this.panelRiwayatBar.Size = new System.Drawing.Size(950, 48);
            this.panelRiwayatBar.BackColor = System.Drawing.Color.Transparent;
            this.lblCariRiwayat.Text = "Cari:";
            this.lblCariRiwayat.Location = new System.Drawing.Point(10, 12);
            this.lblCariRiwayat.Size = new System.Drawing.Size(40, 20);
            this.lblCariRiwayat.Font =
                new System.Drawing.Font("Segoe UI", 9F,
                System.Drawing.FontStyle.Bold);
            this.txtCariRiwayat.Location = new System.Drawing.Point(55, 9);

            this.txtCariRiwayat.Size = new System.Drawing.Size(250, 23);

            this.txtCariRiwayat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.txtCariRiwayat.TextChanged += new System.EventHandler(this.txtCariRiwayat_TextChanged);

            this.btnBatalBooking.Text = "✖  Batalkan Booking";
            this.btnBatalBooking.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBatalBooking.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnBatalBooking.ForeColor = System.Drawing.Color.White;
            this.btnBatalBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatalBooking.FlatAppearance.BorderSize = 0;
            this.btnBatalBooking.Location = new System.Drawing.Point(810, 7);
            this.btnBatalBooking.Size = new System.Drawing.Size(140, 34);
            this.btnBatalBooking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBatalBooking.Click += new System.EventHandler(this.btnBatalBooking_Click);

            this.panelRiwayatBar.Controls.Add(this.lblCariRiwayat);
            this.panelRiwayatBar.Controls.Add(this.txtCariRiwayat);
            this.panelRiwayatBar.Controls.Add(this.btnBatalBooking);

            this.dgvRiwayat.Location = new System.Drawing.Point(10, 65);
            this.dgvRiwayat.Size = new System.Drawing.Size(950, 470);
            this.dgvRiwayat.BackgroundColor = System.Drawing.Color.White;
            this.dgvRiwayat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRiwayat.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.dgvRiwayat.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvRiwayat.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvRiwayat.ColumnHeadersHeight = 36;
            this.dgvRiwayat.EnableHeadersVisualStyles = false;
            this.dgvRiwayat.AllowUserToAddRows = false;

            this.tabRiwayat.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.panelRiwayatBar, this.dgvRiwayat });

            this.tabBookingBaru.Text = "  Booking Jadwal  ";

            this.panelJadwalTop.Location = new System.Drawing.Point(10, 10);
            this.panelJadwalTop.Size = new System.Drawing.Size(950, 28);
            this.panelJadwalTop.BackColor = System.Drawing.Color.Transparent;

            this.lblPilihJadwal.Text = "Jadwal Tersedia (pilih satu, lalu isi keluhan di bawah):";
            this.lblPilihJadwal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPilihJadwal.ForeColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.lblPilihJadwal.Location = new System.Drawing.Point(0, 4);
            this.lblPilihJadwal.Size = new System.Drawing.Size(700, 22);
            this.panelJadwalTop.Controls.Add(this.lblPilihJadwal);

            this.dgvJadwal.Location = new System.Drawing.Point(10, 44);
            this.dgvJadwal.Size = new System.Drawing.Size(950, 330);
            this.dgvJadwal.BackgroundColor = System.Drawing.Color.White;
            this.dgvJadwal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvJadwal.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.dgvJadwal.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvJadwal.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvJadwal.ColumnHeadersHeight = 36;
            this.dgvJadwal.EnableHeadersVisualStyles = false;
            this.dgvJadwal.AllowUserToAddRows = false;

            this.panelKeluhanBar.Location = new System.Drawing.Point(10, 385);
            this.panelKeluhanBar.Size = new System.Drawing.Size(950, 140);
            this.panelKeluhanBar.BackColor = System.Drawing.Color.White;
            this.panelKeluhanBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.lblKeluhan.Text = "Keluhan / Alasan Kontrol:";
            this.lblKeluhan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblKeluhan.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lblKeluhan.Location = new System.Drawing.Point(15, 12);
            this.lblKeluhan.Size = new System.Drawing.Size(200, 18);

            this.txtKeluhan.Location = new System.Drawing.Point(15, 34);
            this.txtKeluhan.Size = new System.Drawing.Size(780, 80);
            this.txtKeluhan.Multiline = true;
            this.txtKeluhan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKeluhan.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);

            this.btnBooking.Text = "✔  Booking Sekarang";
            this.btnBooking.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBooking.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnBooking.ForeColor = System.Drawing.Color.White;
            this.btnBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooking.FlatAppearance.BorderSize = 0;
            this.btnBooking.Location = new System.Drawing.Point(810, 34);
            this.btnBooking.Size = new System.Drawing.Size(125, 80);
            this.btnBooking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);

            this.panelKeluhanBar.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblKeluhan, this.txtKeluhan, this.btnBooking });

            this.tabBookingBaru.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.panelJadwalTop, this.dgvJadwal, this.panelKeluhanBar });

            this.tabProfil.Text = "  Profil Saya  ";

            this.panelProfil.Location = new System.Drawing.Point(30, 20);
            this.panelProfil.Size = new System.Drawing.Size(600, 450);
            this.panelProfil.BackColor = System.Drawing.Color.White;
            this.panelProfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.lblProfilTitle.Text = "Data Diri Pasien";
            this.lblProfilTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblProfilTitle.ForeColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.lblProfilTitle.Location = new System.Drawing.Point(20, 20);
            this.lblProfilTitle.Size = new System.Drawing.Size(400, 30);

      

            this.panelProfil.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblProfilTitle,
                this.lblNikKey,    this.lblProfilNIK,
                this.lblNamaKey,   this.lblProfilNama,
                this.lblTglKey,    this.lblProfilTgl,
                this.lblJKKey,     this.lblProfilJK,
                this.lblAlamatKey, this.lblProfilAlamat,
                this.lblHPKey,     this.lblProfilHP,
                this.lblEmailKey,  this.lblProfilEmail
            });
            this.tabProfil.Controls.Add(this.panelProfil);

            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panelTop);

            this.panelTop.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabRiwayat.ResumeLayout(false);
            this.tabBookingBaru.ResumeLayout(false);
            this.tabProfil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.dgvRiwayat).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.dgvJadwal).EndInit();
            this.ResumeLayout(false);

            this.Load += new System.EventHandler(this.FormDashboardPasien_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDashboardPasien_FormClosed);
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
    }
}
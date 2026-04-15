namespace SistemBookingPasien_5.Forms
{
    partial class FormBooking
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDokter, lblJadwal, lblTanggal, lblKeluhan;
        private System.Windows.Forms.ComboBox cboDokter, cboJadwal;
        private System.Windows.Forms.DateTimePicker dtpTanggal;
        private System.Windows.Forms.TextBox txtKeluhan;
        private System.Windows.Forms.Button btnBuat, btnBatal;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle   = new System.Windows.Forms.Label();
            this.lblDokter  = new System.Windows.Forms.Label();
            this.cboDokter  = new System.Windows.Forms.ComboBox();
            this.lblJadwal  = new System.Windows.Forms.Label();
            this.cboJadwal  = new System.Windows.Forms.ComboBox();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.dtpTanggal = new System.Windows.Forms.DateTimePicker();
            this.lblKeluhan = new System.Windows.Forms.Label();
            this.txtKeluhan = new System.Windows.Forms.TextBox();
            this.btnBuat    = new System.Windows.Forms.Button();
            this.btnBatal   = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.Text            = "Buat Booking Baru";
            this.Size            = new System.Drawing.Size(500, 500);
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox     = false;
            this.BackColor       = System.Drawing.Color.White;

            this.lblTitle.Text      = "📅 Buat Booking Kontrol";
            this.lblTitle.Font      = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(0, 102, 204);
            this.lblTitle.Location  = new System.Drawing.Point(20, 20);
            this.lblTitle.Size      = new System.Drawing.Size(450, 35);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            int y = 75;
            System.Action<System.Windows.Forms.Label, System.Windows.Forms.Control, string> addF =
                (lbl, ctrl, cap) =>
            {
                lbl.Text     = cap;
                lbl.Font     = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
                lbl.Location = new System.Drawing.Point(25, y);
                lbl.Size     = new System.Drawing.Size(440, 20);
                ctrl.Location = new System.Drawing.Point(25, y + 22);
                ctrl.Size     = new System.Drawing.Size(440, 30);
                ctrl.Font     = new System.Drawing.Font("Segoe UI", 10F);
                y += 70;
            };

            addF(this.lblDokter, this.cboDokter, "Pilih Dokter");
            this.cboDokter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDokter.SelectedIndexChanged += new System.EventHandler(this.cboDokter_SelectedIndexChanged);

            addF(this.lblJadwal, this.cboJadwal, "Pilih Jadwal (Hari & Jam)");
            this.cboJadwal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            addF(this.lblTanggal, this.dtpTanggal, "Tanggal Kontrol");
            this.dtpTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            addF(this.lblKeluhan, this.txtKeluhan, "Keluhan / Keterangan");
            this.txtKeluhan.Height    = 80;
            this.txtKeluhan.Multiline = true;
            this.txtKeluhan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            y += 40;

            this.btnBuat.Text      = "✅ BUAT BOOKING";
            this.btnBuat.Font      = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnBuat.BackColor = System.Drawing.Color.FromArgb(0, 153, 76);
            this.btnBuat.ForeColor = System.Drawing.Color.White;
            this.btnBuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuat.Location  = new System.Drawing.Point(25, y);
            this.btnBuat.Size      = new System.Drawing.Size(200, 42);
            this.btnBuat.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnBuat.Click    += new System.EventHandler(this.btnBuat_Click);

            this.btnBatal.Text      = "✖ BATAL";
            this.btnBatal.Font      = new System.Drawing.Font("Segoe UI", 11F);
            this.btnBatal.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnBatal.ForeColor = System.Drawing.Color.White;
            this.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatal.Location  = new System.Drawing.Point(265, y);
            this.btnBatal.Size      = new System.Drawing.Size(200, 42);
            this.btnBatal.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnBatal.Click    += new System.EventHandler(this.btnBatal_Click);

            this.Height = y + 100;
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblTitle, this.lblDokter, this.cboDokter,
                this.lblJadwal, this.cboJadwal, this.lblTanggal, this.dtpTanggal,
                this.lblKeluhan, this.txtKeluhan, this.btnBuat, this.btnBatal
            });
            this.ResumeLayout(false);
        }
    }
}

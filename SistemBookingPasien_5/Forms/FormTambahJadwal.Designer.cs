namespace SistemBookingPasien_5.Forms
{
    partial class FormTambahJadwal
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDokter, lblHari, lblMulai, lblSelesai, lblKuota;
        private System.Windows.Forms.ComboBox cboDokter, cboHari;
        private System.Windows.Forms.DateTimePicker dtpMulai, dtpSelesai;
        private System.Windows.Forms.NumericUpDown numKuota;
        private System.Windows.Forms.Button btnSimpan, btnBatal;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle  = new System.Windows.Forms.Label();
            this.lblDokter = new System.Windows.Forms.Label();
            this.cboDokter = new System.Windows.Forms.ComboBox();
            this.lblHari   = new System.Windows.Forms.Label();
            this.cboHari   = new System.Windows.Forms.ComboBox();
            this.lblMulai  = new System.Windows.Forms.Label();
            this.dtpMulai  = new System.Windows.Forms.DateTimePicker();
            this.lblSelesai= new System.Windows.Forms.Label();
            this.dtpSelesai= new System.Windows.Forms.DateTimePicker();
            this.lblKuota  = new System.Windows.Forms.Label();
            this.numKuota  = new System.Windows.Forms.NumericUpDown();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal  = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numKuota)).BeginInit();
            this.SuspendLayout();

            this.Text            = "Tambah Jadwal Dokter";
            this.Size            = new System.Drawing.Size(440, 480);
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox     = false;
            this.BackColor       = System.Drawing.Color.White;

            this.lblTitle.Text      = "🗓 Tambah Jadwal Dokter";
            this.lblTitle.Font      = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(0, 102, 204);
            this.lblTitle.Location  = new System.Drawing.Point(15, 15);
            this.lblTitle.Size      = new System.Drawing.Size(400, 35);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            int y = 70;
            System.Action<System.Windows.Forms.Label, System.Windows.Forms.Control, string> addF =
                (lbl, ctrl, cap) =>
            {
                lbl.Text = cap; lbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
                lbl.Location = new System.Drawing.Point(20, y); lbl.Size = new System.Drawing.Size(390, 20);
                ctrl.Location = new System.Drawing.Point(20, y + 22); ctrl.Size = new System.Drawing.Size(390, 30);
                ctrl.Font = new System.Drawing.Font("Segoe UI", 10F);
                y += 65;
            };

            addF(this.lblDokter, this.cboDokter, "Pilih Dokter *");
            this.cboDokter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            addF(this.lblHari, this.cboHari, "Hari Praktik *");
            this.cboHari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHari.Items.AddRange(new object[] { "Senin","Selasa","Rabu","Kamis","Jumat","Sabtu","Minggu" });
            this.cboHari.SelectedIndex = 0;

            addF(this.lblMulai, this.dtpMulai, "Jam Mulai *");
            this.dtpMulai.Format       = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpMulai.ShowUpDown   = true;
            this.dtpMulai.Value        = new System.DateTime(2000, 1, 1, 8, 0, 0);

            addF(this.lblSelesai, this.dtpSelesai, "Jam Selesai *");
            this.dtpSelesai.Format     = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSelesai.ShowUpDown = true;
            this.dtpSelesai.Value      = new System.DateTime(2000, 1, 1, 12, 0, 0);

            addF(this.lblKuota, this.numKuota, "Kuota Pasien *");
            this.numKuota.Minimum = 1; this.numKuota.Maximum = 50; this.numKuota.Value = 10;
            this.numKuota.Font    = new System.Drawing.Font("Segoe UI", 10F);

            this.btnSimpan.Text = "💾 SIMPAN"; this.btnSimpan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSimpan.BackColor = System.Drawing.Color.FromArgb(0, 102, 204); this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.Location = new System.Drawing.Point(20, y + 5); this.btnSimpan.Size = new System.Drawing.Size(185, 38);
            this.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand; this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);

            this.btnBatal.Text = "✖ BATAL"; this.btnBatal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBatal.BackColor = System.Drawing.Color.FromArgb(220, 53, 69); this.btnBatal.ForeColor = System.Drawing.Color.White;
            this.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatal.Location = new System.Drawing.Point(225, y + 5); this.btnBatal.Size = new System.Drawing.Size(185, 38);
            this.btnBatal.Cursor = System.Windows.Forms.Cursors.Hand; this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);

            this.Height = y + 120;
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblTitle, this.lblDokter, this.cboDokter, this.lblHari, this.cboHari,
                this.lblMulai, this.dtpMulai, this.lblSelesai, this.dtpSelesai,
                this.lblKuota, this.numKuota, this.btnSimpan, this.btnBatal
            });
            ((System.ComponentModel.ISupportInitialize)(this.numKuota)).EndInit();
            this.ResumeLayout(false);
        }
    }
}

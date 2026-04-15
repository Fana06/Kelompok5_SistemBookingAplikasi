namespace SistemBookingPasien_5.Forms
{
    partial class FormTambahDokter
    {
        private System.ComponentModel.IContainer components = null;
        internal System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNama, lblSpesialis, lblNoHp;
        private System.Windows.Forms.TextBox txtNama, txtSpesialis, txtNoHp;
        private System.Windows.Forms.CheckBox chkAktif;
        private System.Windows.Forms.Button btnSimpan, btnBatal;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle    = new System.Windows.Forms.Label();
            this.lblNama     = new System.Windows.Forms.Label();
            this.txtNama     = new System.Windows.Forms.TextBox();
            this.lblSpesialis= new System.Windows.Forms.Label();
            this.txtSpesialis= new System.Windows.Forms.TextBox();
            this.lblNoHp     = new System.Windows.Forms.Label();
            this.txtNoHp     = new System.Windows.Forms.TextBox();
            this.chkAktif    = new System.Windows.Forms.CheckBox();
            this.btnSimpan   = new System.Windows.Forms.Button();
            this.btnBatal    = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.Text            = "Tambah Dokter";
            this.Size            = new System.Drawing.Size(430, 400);
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox     = false;
            this.BackColor       = System.Drawing.Color.White;

            this.lblTitle.Text      = "➕ Tambah Dokter Baru";
            this.lblTitle.Font      = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(0, 102, 204);
            this.lblTitle.Location  = new System.Drawing.Point(15, 15);
            this.lblTitle.Size      = new System.Drawing.Size(390, 35);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            int y = 70;
            System.Action<System.Windows.Forms.Label, System.Windows.Forms.TextBox, string> addF = (lbl, txt, cap) =>
            {
                lbl.Text = cap; lbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
                lbl.Location = new System.Drawing.Point(20, y); lbl.Size = new System.Drawing.Size(380, 20);
                txt.Location = new System.Drawing.Point(20, y + 22); txt.Size = new System.Drawing.Size(380, 28);
                txt.Font = new System.Drawing.Font("Segoe UI", 10F); txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                y += 65;
            };
            addF(this.lblNama, this.txtNama, "Nama Dokter *");
            addF(this.lblSpesialis, this.txtSpesialis, "Spesialisasi");
            addF(this.lblNoHp, this.txtNoHp, "Nomor HP");

            this.chkAktif.Text     = "✅ Dokter Aktif";
            this.chkAktif.Font     = new System.Drawing.Font("Segoe UI", 10F);
            this.chkAktif.Checked  = true;
            this.chkAktif.Location = new System.Drawing.Point(20, y);
            this.chkAktif.Size     = new System.Drawing.Size(200, 25);
            y += 45;

            this.btnSimpan.Text = "💾 SIMPAN"; this.btnSimpan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSimpan.BackColor = System.Drawing.Color.FromArgb(0, 102, 204); this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.Location = new System.Drawing.Point(20, y); this.btnSimpan.Size = new System.Drawing.Size(175, 38);
            this.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand; this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);

            this.btnBatal.Text = "✖ BATAL"; this.btnBatal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBatal.BackColor = System.Drawing.Color.FromArgb(220, 53, 69); this.btnBatal.ForeColor = System.Drawing.Color.White;
            this.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatal.Location = new System.Drawing.Point(225, y); this.btnBatal.Size = new System.Drawing.Size(175, 38);
            this.btnBatal.Cursor = System.Windows.Forms.Cursors.Hand; this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);

            this.Height = y + 100;
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblTitle, this.lblNama, this.txtNama, this.lblSpesialis, this.txtSpesialis,
                this.lblNoHp, this.txtNoHp, this.chkAktif, this.btnSimpan, this.btnBatal
            });
            this.ResumeLayout(false);
        }
    }
}

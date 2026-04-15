namespace SistemBookingPasien_5.Forms
{
    partial class FormProfilPasien
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNIK, lblNama, lblLahir, lblJK, lblAlamat, lblNoHp;
        private System.Windows.Forms.TextBox txtNIK, txtNama, txtAlamat, txtNoHp;
        private System.Windows.Forms.DateTimePicker dtpLahir;
        private System.Windows.Forms.ComboBox cboJK;
        private System.Windows.Forms.Button btnSimpan, btnBatal;
        private System.Windows.Forms.TableLayoutPanel tableLayout;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle   = new System.Windows.Forms.Label();
            this.lblNIK     = new System.Windows.Forms.Label();
            this.txtNIK     = new System.Windows.Forms.TextBox();
            this.lblNama    = new System.Windows.Forms.Label();
            this.txtNama    = new System.Windows.Forms.TextBox();
            this.lblLahir   = new System.Windows.Forms.Label();
            this.dtpLahir   = new System.Windows.Forms.DateTimePicker();
            this.lblJK      = new System.Windows.Forms.Label();
            this.cboJK      = new System.Windows.Forms.ComboBox();
            this.lblAlamat  = new System.Windows.Forms.Label();
            this.txtAlamat  = new System.Windows.Forms.TextBox();
            this.lblNoHp    = new System.Windows.Forms.Label();
            this.txtNoHp    = new System.Windows.Forms.TextBox();
            this.btnSimpan  = new System.Windows.Forms.Button();
            this.btnBatal   = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.Text            = "Profil Pasien";
            this.Size            = new System.Drawing.Size(500, 560);
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox     = false;
            this.BackColor       = System.Drawing.Color.White;

            this.lblTitle.Text      = "📝 Data Diri Pasien";
            this.lblTitle.Font      = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(0, 102, 204);
            this.lblTitle.Location  = new System.Drawing.Point(20, 20);
            this.lblTitle.Size      = new System.Drawing.Size(450, 40);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            int y = 80;
            System.Action<System.Windows.Forms.Label, System.Windows.Forms.Control, string> addField =
                (lbl, ctrl, cap) =>
            {
                lbl.Text     = cap;
                lbl.Font     = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
                lbl.Location = new System.Drawing.Point(30, y);
                lbl.Size     = new System.Drawing.Size(440, 20);
                ctrl.Location = new System.Drawing.Point(30, y + 22);
                ctrl.Size     = new System.Drawing.Size(430, 28);
                ctrl.Font     = new System.Drawing.Font("Segoe UI", 10F);
                if (ctrl is System.Windows.Forms.TextBox tb) tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                y += 65;
            };

            addField(this.lblNIK,    this.txtNIK,    "NIK (16 digit)");
            addField(this.lblNama,   this.txtNama,   "Nama Lengkap");
            addField(this.lblLahir,  this.dtpLahir,  "Tanggal Lahir");
            this.dtpLahir.Format  = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLahir.MaxDate = System.DateTime.Today;

            addField(this.lblJK, this.cboJK, "Jenis Kelamin");
            this.cboJK.Items.AddRange(new object[] { "Laki-laki", "Perempuan" });
            this.cboJK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboJK.SelectedIndex = 0;

            addField(this.lblAlamat, this.txtAlamat, "Alamat");
            addField(this.lblNoHp,   this.txtNoHp,   "Nomor HP");

            this.btnSimpan.Text      = "💾 SIMPAN";
            this.btnSimpan.Font      = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSimpan.BackColor = System.Drawing.Color.FromArgb(0, 102, 204);
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.Location  = new System.Drawing.Point(30, y + 10);
            this.btnSimpan.Size      = new System.Drawing.Size(200, 42);
            this.btnSimpan.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnSimpan.Click    += new System.EventHandler(this.btnSimpan_Click);

            this.btnBatal.Text      = "✖ BATAL";
            this.btnBatal.Font      = new System.Drawing.Font("Segoe UI", 11F);
            this.btnBatal.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnBatal.ForeColor = System.Drawing.Color.White;
            this.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatal.Location  = new System.Drawing.Point(260, y + 10);
            this.btnBatal.Size      = new System.Drawing.Size(200, 42);
            this.btnBatal.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnBatal.Click    += new System.EventHandler(this.btnBatal_Click);

            this.Height = y + 120;
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblTitle, this.lblNIK, this.txtNIK, this.lblNama, this.txtNama,
                this.lblLahir, this.dtpLahir, this.lblJK, this.cboJK,
                this.lblAlamat, this.txtAlamat, this.lblNoHp, this.txtNoHp,
                this.btnSimpan, this.btnBatal
            });
            this.ResumeLayout(false);
        }
    }
}

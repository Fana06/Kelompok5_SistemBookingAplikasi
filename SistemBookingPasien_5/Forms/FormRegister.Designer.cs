namespace SistemBookingPasien_5.Forms
{
    partial class FormRegister
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblKonfirm;
        private System.Windows.Forms.TextBox txtKonfirmPassword;
        private System.Windows.Forms.Button btnDaftar;
        private System.Windows.Forms.Button btnBatal;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelMain         = new System.Windows.Forms.Panel();
            this.lblTitle          = new System.Windows.Forms.Label();
            this.lblEmail          = new System.Windows.Forms.Label();
            this.txtEmail          = new System.Windows.Forms.TextBox();
            this.lblPassword       = new System.Windows.Forms.Label();
            this.txtPassword       = new System.Windows.Forms.TextBox();
            this.lblKonfirm        = new System.Windows.Forms.Label();
            this.txtKonfirmPassword= new System.Windows.Forms.TextBox();
            this.btnDaftar         = new System.Windows.Forms.Button();
            this.btnBatal          = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();

            this.Text            = "Daftar Akun Baru";
            this.Size            = new System.Drawing.Size(460, 480);
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox     = false;
            this.BackColor       = System.Drawing.Color.FromArgb(240, 248, 255);

            this.panelMain.BackColor   = System.Drawing.Color.White;
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Location    = new System.Drawing.Point(30, 30);
            this.panelMain.Size        = new System.Drawing.Size(390, 400);

            this.lblTitle.Text      = "📋 Registrasi Akun Pasien";
            this.lblTitle.Font      = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(0, 102, 204);
            this.lblTitle.Location  = new System.Drawing.Point(10, 20);
            this.lblTitle.Size      = new System.Drawing.Size(370, 35);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            int y = 75;
            Action<System.Windows.Forms.Label, System.Windows.Forms.TextBox, string, bool> addRow = (lbl, txt, caption, isPwd) => {
                lbl.Text     = caption;
                lbl.Font     = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
                lbl.Location = new System.Drawing.Point(25, y);
                lbl.Size     = new System.Drawing.Size(340, 22);
                txt.Location = new System.Drawing.Point(25, y + 25);
                txt.Size     = new System.Drawing.Size(340, 28);
                txt.Font     = new System.Drawing.Font("Segoe UI", 11F);
                txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                if (isPwd) txt.PasswordChar = '●';
                y += 75;
            };

            addRow(this.lblEmail, this.txtEmail, "Email", false);
            addRow(this.lblPassword, this.txtPassword, "Password", true);
            addRow(this.lblKonfirm, this.txtKonfirmPassword, "Konfirmasi Password", true);

            this.btnDaftar.Text      = "DAFTAR";
            this.btnDaftar.Font      = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnDaftar.BackColor = System.Drawing.Color.FromArgb(0, 153, 76);
            this.btnDaftar.ForeColor = System.Drawing.Color.White;
            this.btnDaftar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDaftar.Location  = new System.Drawing.Point(25, 310);
            this.btnDaftar.Size      = new System.Drawing.Size(160, 40);
            this.btnDaftar.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnDaftar.Click    += new System.EventHandler(this.btnDaftar_Click);

            this.btnBatal.Text      = "BATAL";
            this.btnBatal.Font      = new System.Drawing.Font("Segoe UI", 11F);
            this.btnBatal.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnBatal.ForeColor = System.Drawing.Color.White;
            this.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatal.Location  = new System.Drawing.Point(205, 310);
            this.btnBatal.Size      = new System.Drawing.Size(160, 40);
            this.btnBatal.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnBatal.Click    += new System.EventHandler(this.btnBatal_Click);

            this.panelMain.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblTitle, this.lblEmail, this.txtEmail,
                this.lblPassword, this.txtPassword,
                this.lblKonfirm, this.txtKonfirmPassword,
                this.btnDaftar, this.btnBatal
            });
            this.Controls.Add(this.panelMain);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}

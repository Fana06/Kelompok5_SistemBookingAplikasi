namespace SistemBookingPasien_5.Forms
{
    partial class FormLogin
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.LinkLabel linkLabelForgot;
        private System.Windows.Forms.PictureBox picIcon;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelMain      = new System.Windows.Forms.Panel();
            this.lblTitle       = new System.Windows.Forms.Label();
            this.lblSubtitle    = new System.Windows.Forms.Label();
            this.lblEmail       = new System.Windows.Forms.Label();
            this.txtEmail       = new System.Windows.Forms.TextBox();
            this.lblPassword    = new System.Windows.Forms.Label();
            this.txtPassword    = new System.Windows.Forms.TextBox();
            this.btnLogin       = new System.Windows.Forms.Button();
            this.btnRegister    = new System.Windows.Forms.Button();
            this.linkLabelForgot= new System.Windows.Forms.LinkLabel();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();

            this.Text            = "Login - Sistem Booking Kontrol Pasien";
            this.Size            = new System.Drawing.Size(480, 560);
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox     = false;
            this.BackColor       = System.Drawing.Color.FromArgb(240, 248, 255);

            this.panelMain.BackColor  = System.Drawing.Color.White;
            this.panelMain.BorderStyle= System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Location   = new System.Drawing.Point(40, 40);
            this.panelMain.Size       = new System.Drawing.Size(390, 460);

            this.lblTitle.Text      = "🏥 Sistem Booking";
            this.lblTitle.Font      = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(0, 102, 204);
            this.lblTitle.Location  = new System.Drawing.Point(20, 30);
            this.lblTitle.Size      = new System.Drawing.Size(350, 40);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblSubtitle.Text      = "Kontrol Pasien";
            this.lblSubtitle.Font      = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.Gray;
            this.lblSubtitle.Location  = new System.Drawing.Point(20, 70);
            this.lblSubtitle.Size      = new System.Drawing.Size(350, 25);
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblEmail.Text     = "Email";
            this.lblEmail.Font     = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmail.Location = new System.Drawing.Point(30, 130);
            this.lblEmail.Size     = new System.Drawing.Size(330, 22);

            this.txtEmail.Location  = new System.Drawing.Point(30, 155);
            this.txtEmail.Size      = new System.Drawing.Size(330, 30);
            this.txtEmail.Font      = new System.Drawing.Font("Segoe UI", 11F);
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.lblPassword.Text     = "Password";
            this.lblPassword.Font     = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPassword.Location = new System.Drawing.Point(30, 205);
            this.lblPassword.Size     = new System.Drawing.Size(330, 22);

            this.txtPassword.Location     = new System.Drawing.Point(30, 230);
            this.txtPassword.Size         = new System.Drawing.Size(330, 30);
            this.txtPassword.Font         = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.BorderStyle  = System.Windows.Forms.BorderStyle.FixedSingle;

            this.linkLabelForgot.Text     = "Lupa password?";
            this.linkLabelForgot.Location = new System.Drawing.Point(230, 270);
            this.linkLabelForgot.Size     = new System.Drawing.Size(130, 20);
            this.linkLabelForgot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelForgot_LinkClicked);

            this.btnLogin.Text      = "MASUK";
            this.btnLogin.Font      = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(0, 102, 204);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location  = new System.Drawing.Point(30, 310);
            this.btnLogin.Size      = new System.Drawing.Size(330, 45);
            this.btnLogin.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Click    += new System.EventHandler(this.btnLogin_Click);

            this.btnRegister.Text      = "Daftar Akun Baru";
            this.btnRegister.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.btnRegister.BackColor = System.Drawing.Color.White;
            this.btnRegister.ForeColor = System.Drawing.Color.FromArgb(0, 102, 204);
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 102, 204);
            this.btnRegister.Location  = new System.Drawing.Point(30, 370);
            this.btnRegister.Size      = new System.Drawing.Size(330, 40);
            this.btnRegister.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Click    += new System.EventHandler(this.btnRegister_Click);

            this.panelMain.Controls.Add(this.lblTitle);
            this.panelMain.Controls.Add(this.lblSubtitle);
            this.panelMain.Controls.Add(this.lblEmail);
            this.panelMain.Controls.Add(this.txtEmail);
            this.panelMain.Controls.Add(this.lblPassword);
            this.panelMain.Controls.Add(this.txtPassword);
            this.panelMain.Controls.Add(this.linkLabelForgot);
            this.panelMain.Controls.Add(this.btnLogin);
            this.panelMain.Controls.Add(this.btnRegister);
            this.Controls.Add(this.panelMain);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}

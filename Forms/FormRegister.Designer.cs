namespace BookingKontrolPasien.Forms
{
    partial class FormRegister
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.panelBody = new System.Windows.Forms.Panel();
            this.panelAccount = new System.Windows.Forms.Panel();
            this.lblSectionAkun = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblKonfirmasi = new System.Windows.Forms.Label();
            this.txtKonfirmasi = new System.Windows.Forms.TextBox();
            this.lblSectionData = new System.Windows.Forms.Label();
            this.lblNIK = new System.Windows.Forms.Label();
            this.txtNIK = new System.Windows.Forms.TextBox();
            this.lblNama = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.lblTglLahir = new System.Windows.Forms.Label();
            this.dtTanggalLahir = new System.Windows.Forms.DateTimePicker();
            this.lblJK = new System.Windows.Forms.Label();
            this.rbLaki = new System.Windows.Forms.RadioButton();
            this.rbPerempuan = new System.Windows.Forms.RadioButton();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.lblNoHP = new System.Windows.Forms.Label();
            this.txtNoHP = new System.Windows.Forms.TextBox();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.btnDaftar = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.panelAccount.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
           
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.lblSubTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(652, 90);
            this.panelHeader.TabIndex = 0;
            
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(30, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Pendaftaran Akun Pasien";
            
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.lblSubTitle.Location = new System.Drawing.Point(30, 50);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(400, 20);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Isi formulir berikut untuk mendaftar";
           
            this.panelBody.BackColor = System.Drawing.Color.White;
            this.panelBody.Controls.Add(this.panelAccount);
            this.panelBody.Controls.Add(this.lblSectionData);
            this.panelBody.Controls.Add(this.lblNIK);
            this.panelBody.Controls.Add(this.txtNIK);
            this.panelBody.Controls.Add(this.lblNama);
            this.panelBody.Controls.Add(this.txtNama);
            this.panelBody.Controls.Add(this.lblTglLahir);
            this.panelBody.Controls.Add(this.dtTanggalLahir);
            this.panelBody.Controls.Add(this.lblJK);
            this.panelBody.Controls.Add(this.rbLaki);
            this.panelBody.Controls.Add(this.rbPerempuan);
            this.panelBody.Controls.Add(this.lblAlamat);
            this.panelBody.Controls.Add(this.txtAlamat);
            this.panelBody.Controls.Add(this.lblNoHP);
            this.panelBody.Controls.Add(this.txtNoHP);
            this.panelBody.Location = new System.Drawing.Point(0, 90);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(620, 590);
            this.panelBody.TabIndex = 1;
            
            this.panelAccount.BackColor = System.Drawing.Color.White;
            this.panelAccount.Controls.Add(this.lblSectionAkun);
            this.panelAccount.Controls.Add(this.lblEmail);
            this.panelAccount.Controls.Add(this.txtEmail);
            this.panelAccount.Controls.Add(this.lblPassword);
            this.panelAccount.Controls.Add(this.txtPassword);
            this.panelAccount.Controls.Add(this.lblKonfirmasi);
            this.panelAccount.Controls.Add(this.txtKonfirmasi);
            this.panelAccount.Location = new System.Drawing.Point(30, 10);
            this.panelAccount.Name = "panelAccount";
            this.panelAccount.Size = new System.Drawing.Size(560, 190);
            this.panelAccount.TabIndex = 0;
            
            this.lblSectionAkun.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSectionAkun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblSectionAkun.Location = new System.Drawing.Point(0, 0);
            this.lblSectionAkun.Name = "lblSectionAkun";
            this.lblSectionAkun.Size = new System.Drawing.Size(300, 22);
            this.lblSectionAkun.TabIndex = 0;
            this.lblSectionAkun.Text = "▌ Data Akun";
            
            this.lblEmail.Location = new System.Drawing.Point(0, 28);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(200, 18);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
             
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(0, 48);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(540, 23);
            this.txtEmail.TabIndex = 2;
            
            this.lblPassword.Location = new System.Drawing.Point(0, 82);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(200, 18);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Location = new System.Drawing.Point(0, 102);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(540, 23);
            this.txtPassword.TabIndex = 4;
           
            this.lblKonfirmasi.Location = new System.Drawing.Point(0, 136);
            this.lblKonfirmasi.Name = "lblKonfirmasi";
            this.lblKonfirmasi.Size = new System.Drawing.Size(200, 18);
            this.lblKonfirmasi.TabIndex = 5;
            this.lblKonfirmasi.Text = "Konfirmasi Password";
            
            this.txtKonfirmasi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtKonfirmasi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKonfirmasi.Location = new System.Drawing.Point(0, 156);
            this.txtKonfirmasi.Name = "txtKonfirmasi";
            this.txtKonfirmasi.PasswordChar = '●';
            this.txtKonfirmasi.Size = new System.Drawing.Size(540, 23);
            this.txtKonfirmasi.TabIndex = 6;
            
            this.lblSectionData.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSectionData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblSectionData.Location = new System.Drawing.Point(30, 210);
            this.lblSectionData.Name = "lblSectionData";
            this.lblSectionData.Size = new System.Drawing.Size(300, 22);
            this.lblSectionData.TabIndex = 1;
            this.lblSectionData.Text = "▌ Data Diri Pasien";
            
            this.lblNIK.Location = new System.Drawing.Point(30, 238);
            this.lblNIK.Name = "lblNIK";
            this.lblNIK.Size = new System.Drawing.Size(200, 18);
            this.lblNIK.TabIndex = 2;
            this.lblNIK.Text = "NIK (16 digit)";
                        this.txtNIK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtNIK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNIK.Location = new System.Drawing.Point(30, 258);
            this.txtNIK.MaxLength = 20;
            this.txtNIK.Name = "txtNIK";
            this.txtNIK.Size = new System.Drawing.Size(560, 23);
            this.txtNIK.TabIndex = 3;
            
            this.lblNama.Location = new System.Drawing.Point(30, 292);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(200, 18);
            this.lblNama.TabIndex = 4;
            this.lblNama.Text = "Nama Lengkap";
           
            this.txtNama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNama.Location = new System.Drawing.Point(30, 312);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(560, 23);
            this.txtNama.TabIndex = 5;
            
            this.lblTglLahir.Location = new System.Drawing.Point(30, 346);
            this.lblTglLahir.Name = "lblTglLahir";
            this.lblTglLahir.Size = new System.Drawing.Size(200, 18);
            this.lblTglLahir.TabIndex = 6;
            this.lblTglLahir.Text = "Tanggal Lahir";
            
            this.dtTanggalLahir.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTanggalLahir.Location = new System.Drawing.Point(30, 366);
            this.dtTanggalLahir.Name = "dtTanggalLahir";
            this.dtTanggalLahir.Size = new System.Drawing.Size(260, 23);
            this.dtTanggalLahir.TabIndex = 7;
            
            this.lblJK.Location = new System.Drawing.Point(310, 346);
            this.lblJK.Name = "lblJK";
            this.lblJK.Size = new System.Drawing.Size(200, 18);
            this.lblJK.TabIndex = 8;
            this.lblJK.Text = "Jenis Kelamin";
          
            this.rbLaki.Checked = true;
            this.rbLaki.Location = new System.Drawing.Point(310, 366);
            this.rbLaki.Name = "rbLaki";
            this.rbLaki.Size = new System.Drawing.Size(120, 20);
            this.rbLaki.TabIndex = 9;
            this.rbLaki.TabStop = true;
            this.rbLaki.Text = "Laki-laki";
           
            this.rbPerempuan.Location = new System.Drawing.Point(440, 366);
            this.rbPerempuan.Name = "rbPerempuan";
            this.rbPerempuan.Size = new System.Drawing.Size(120, 20);
            this.rbPerempuan.TabIndex = 10;
            this.rbPerempuan.Text = "Perempuan";
           
            this.lblAlamat.Location = new System.Drawing.Point(30, 400);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.Size = new System.Drawing.Size(200, 18);
            this.lblAlamat.TabIndex = 11;
            this.lblAlamat.Text = "Alamat";
          
            this.txtAlamat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtAlamat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAlamat.Location = new System.Drawing.Point(30, 420);
            this.txtAlamat.Multiline = true;
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(560, 60);
            this.txtAlamat.TabIndex = 12;
           
            this.lblNoHP.Location = new System.Drawing.Point(30, 490);
            this.lblNoHP.Name = "lblNoHP";
            this.lblNoHP.Size = new System.Drawing.Size(200, 18);
            this.lblNoHP.TabIndex = 13;
            this.lblNoHP.Text = "Nomor HP";
           
            this.txtNoHP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtNoHP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNoHP.Location = new System.Drawing.Point(30, 510);
            this.txtNoHP.Name = "txtNoHP";
            this.txtNoHP.Size = new System.Drawing.Size(260, 23);
            this.txtNoHP.TabIndex = 14;
         
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.panelFooter.Controls.Add(this.btnDaftar);
            this.panelFooter.Controls.Add(this.btnBatal);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 691);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(652, 70);
            this.panelFooter.TabIndex = 2;
        
            this.btnDaftar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnDaftar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDaftar.FlatAppearance.BorderSize = 0;
            this.btnDaftar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDaftar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDaftar.ForeColor = System.Drawing.Color.White;
            this.btnDaftar.Location = new System.Drawing.Point(390, 15);
            this.btnDaftar.Name = "btnDaftar";
            this.btnDaftar.Size = new System.Drawing.Size(130, 40);
            this.btnDaftar.TabIndex = 0;
            this.btnDaftar.Text = "DAFTAR";
            this.btnDaftar.UseVisualStyleBackColor = false;
            this.btnDaftar.Click += new System.EventHandler(this.BtnDaftar_Click);
       
            this.btnBatal.BackColor = System.Drawing.Color.White;
            this.btnBatal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBatal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBatal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnBatal.Location = new System.Drawing.Point(530, 15);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(80, 40);
            this.btnBatal.TabIndex = 1;
            this.btnBatal.Text = "BATAL";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click += new System.EventHandler(this.BtnBatal_Click);
          
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(652, 761);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelFooter);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrasi Pasien";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormRegister_FormClosed);
            this.panelHeader.ResumeLayout(false);
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            this.panelAccount.ResumeLayout(false);
            this.panelAccount.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel           panelHeader;
        private System.Windows.Forms.Label           lblTitle;
        private System.Windows.Forms.Label           lblSubTitle;
        private System.Windows.Forms.Panel           panelBody;
        private System.Windows.Forms.Panel           panelAccount;
        private System.Windows.Forms.Label           lblSectionAkun;
        private System.Windows.Forms.Label           lblEmail;
        private System.Windows.Forms.TextBox         txtEmail;
        private System.Windows.Forms.Label           lblPassword;
        private System.Windows.Forms.TextBox         txtPassword;
        private System.Windows.Forms.Label           lblKonfirmasi;
        private System.Windows.Forms.TextBox         txtKonfirmasi;
        private System.Windows.Forms.Label           lblSectionData;
        private System.Windows.Forms.Label           lblNIK;
        private System.Windows.Forms.TextBox         txtNIK;
        private System.Windows.Forms.Label           lblNama;
        private System.Windows.Forms.TextBox         txtNama;
        private System.Windows.Forms.Label           lblTglLahir;
        private System.Windows.Forms.DateTimePicker  dtTanggalLahir;
        private System.Windows.Forms.Label           lblJK;
        private System.Windows.Forms.RadioButton     rbLaki;
        private System.Windows.Forms.RadioButton     rbPerempuan;
        private System.Windows.Forms.Label           lblAlamat;
        private System.Windows.Forms.TextBox         txtAlamat;
        private System.Windows.Forms.Label           lblNoHP;
        private System.Windows.Forms.TextBox         txtNoHP;
        private System.Windows.Forms.Panel           panelFooter;
        private System.Windows.Forms.Button          btnDaftar;
        private System.Windows.Forms.Button          btnBatal;
    }
}

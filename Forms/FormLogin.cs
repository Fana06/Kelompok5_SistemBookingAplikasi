using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using BookingKontrolPasien.Helpers;

namespace BookingKontrolPasien.Forms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Email dan password tidak boleh kosong!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "SELECT id, email, role FROM users WHERE email=@email AND password=@password";
            SqlParameter[] param = {
                new SqlParameter("@email", email),
                new SqlParameter("@password", password)
            };

            DataTable dt = DBHelper.ExecuteQuery(query, param);

            if (dt.Rows.Count > 0)
            {
                Session.UserId = Convert.ToInt32(dt.Rows[0]["id"]);
                Session.Email  = dt.Rows[0]["email"].ToString();
                Session.Role   = dt.Rows[0]["role"].ToString();

                if (Session.Role == "admin")
                {
                    Session.NamaLengkap = "Administrator";
                    this.Hide();
                    new FormDashboardAdmin().Show();
                }
                else
                {
                    string qPasien = "SELECT id, nama_lengkap FROM pasien WHERE user_id=@uid";
                    DataTable dtPasien = DBHelper.ExecuteQuery(qPasien,
                        new[] { new SqlParameter("@uid", Session.UserId) });

                    if (dtPasien.Rows.Count > 0)
                    {
                        Session.PasienId    = Convert.ToInt32(dtPasien.Rows[0]["id"]);
                        Session.NamaLengkap = dtPasien.Rows[0]["nama_lengkap"].ToString();
                        this.Hide();
                        new FormDashboardPasien().Show();
                    }
                    else
                    {
                        MessageBox.Show("Silakan lengkapi data diri terlebih dahulu.", "Info",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        new FormRegister(Session.UserId).Show();
                    }
                }
            }
            else
            {
                lblError.Text    = "Email atau password salah!";
                lblError.Visible = true;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormRegister().Show();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnLogin_Click(sender, e);
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lblAppName_Click(object sender, EventArgs e)
        {

        }
    }
}

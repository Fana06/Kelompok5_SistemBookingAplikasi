using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using SistemBookingPasien_5.Helpers;

namespace SistemBookingPasien_5.Forms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email    = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Email dan password harus diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = @"SELECT u.id, u.email, u.role,
                                    ISNULL(p.id,0) AS pasien_id,
                                    ISNULL(p.nama_lengkap,'') AS nama_lengkap
                             FROM users u
                             LEFT JOIN pasien p ON p.user_id = u.id
                             WHERE u.email = @email AND u.password = @password";

            SqlParameter[] parms = {
                new SqlParameter("@email",    email),
                new SqlParameter("@password", password)
            };

            DataTable dt = DBHelper.ExecuteQuery(query, parms);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Email atau password salah!", "Login Gagal",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataRow row = dt.Rows[0];
            SessionHelper.UserId      = Convert.ToInt32(row["id"]);
            SessionHelper.Email       = row["email"].ToString();
            SessionHelper.Role        = row["role"].ToString();
            SessionHelper.PasienId    = Convert.ToInt32(row["pasien_id"]);
            SessionHelper.NamaLengkap = row["nama_lengkap"].ToString();

            this.Hide();

            if (SessionHelper.IsAdmin)
            {
                new FormAdminDashboard().ShowDialog();
            }
            else
            {
                // Cek apakah pasien sudah isi profil
                if (SessionHelper.PasienId == 0)
                {
                    MessageBox.Show("Selamat datang! Silakan lengkapi data diri Anda terlebih dahulu.",
                        "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    new FormProfilPasien().ShowDialog();
                }
                new FormPasienDashboard().ShowDialog();
            }

            this.Show();
            txtPassword.Clear();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            new FormRegister().ShowDialog();
        }

        private void linkLabelForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Hubungi admin untuk reset password.", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

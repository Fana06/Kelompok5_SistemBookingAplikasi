using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using SistemBookingPasien_5.Helpers;

namespace SistemBookingPasien_5.Forms
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            string email    = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            string konfirm  = txtKonfirmPassword.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Semua field harus diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != konfirm)
            {
                MessageBox.Show("Password dan konfirmasi tidak sama!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Cek email sudah ada
            object cek = DBHelper.ExecuteScalar(
                "SELECT COUNT(*) FROM users WHERE email = @email",
                new[] { new SqlParameter("@email", email) });

            if (Convert.ToInt32(cek) > 0)
            {
                MessageBox.Show("Email sudah terdaftar!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO users (email, password, role) VALUES (@email, @password, 'pasien')";
            SqlParameter[] parms = {
                new SqlParameter("@email",    email),
                new SqlParameter("@password", password)
            };

            int rows = DBHelper.ExecuteNonQuery(query, parms);
            if (rows > 0)
            {
                MessageBox.Show("Registrasi berhasil! Silakan login.", "Sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

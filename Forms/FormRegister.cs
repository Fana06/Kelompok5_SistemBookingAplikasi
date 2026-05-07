using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using BookingKontrolPasien.Helpers;

namespace BookingKontrolPasien.Forms
{
    public partial class FormRegister : Form
    {
        private int _existingUserId = 0;

        public FormRegister(int existingUserId = 0)
        {
            InitializeComponent();
            _existingUserId = existingUserId;

            if (_existingUserId > 0)
            {
                panelAccount.Visible = false;
                lblTitle.Text = "Lengkapi Data Diri";
                this.Height = 560;
            }
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            if (_existingUserId == 0)
            {
                if (string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtPassword.Text) ||
                    string.IsNullOrWhiteSpace(txtKonfirmasi.Text))
                {
                    MessageBox.Show("Semua field akun harus diisi!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtPassword.Text != txtKonfirmasi.Text)
                {
                    MessageBox.Show("Password dan konfirmasi tidak sama!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (string.IsNullOrWhiteSpace(txtNIK.Text) ||
                string.IsNullOrWhiteSpace(txtNama.Text) ||
                string.IsNullOrWhiteSpace(txtAlamat.Text) ||
                string.IsNullOrWhiteSpace(txtNoHP.Text))
            {
                MessageBox.Show("Semua field data diri harus diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int userId = _existingUserId;

                if (userId == 0)
                {
                    string qUser = "INSERT INTO users (email, password, role) VALUES (@email, @pass, 'pasien'); SELECT SCOPE_IDENTITY();";
                    object result = DBHelper.ExecuteScalar(qUser, new SqlParameter[]
                    {
                        new SqlParameter("@email", txtEmail.Text.Trim()),
                        new SqlParameter("@pass",  txtPassword.Text.Trim())
                    });
                    userId = Convert.ToInt32(result);
                }

                string jk = rbLaki.Checked ? "L" : "P";
                string qPasien = @"INSERT INTO pasien (user_id, nik, nama_lengkap, tanggal_lahir, jenis_kelamin, alamat, no_hp)
                                   VALUES (@uid, @nik, @nama, @tgl, @jk, @alamat, @hp)";
                DBHelper.ExecuteNonQuery(qPasien, new SqlParameter[]
                {
                    new SqlParameter("@uid",    userId),
                    new SqlParameter("@nik",    txtNIK.Text.Trim()),
                    new SqlParameter("@nama",   txtNama.Text.Trim()),
                    new SqlParameter("@tgl",    dtTanggalLahir.Value.Date),
                    new SqlParameter("@jk",     jk),
                    new SqlParameter("@alamat", txtAlamat.Text.Trim()),
                    new SqlParameter("@hp",     txtNoHP.Text.Trim())
                });

                MessageBox.Show("Registrasi berhasil! Silakan login.", "Sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                new FormLogin().Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mendaftar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormLogin().Show();
        }

        private void FormRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

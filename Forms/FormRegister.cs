using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BookingKontrolPasien.Helpers;

namespace BookingKontrolPasien.Forms
{
    public partial class FormRegister : Form
    {
        private readonly int _existingUserId = 0;

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

        private void BtnDaftar_Click(object sender, EventArgs e)
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
                    using (SqlConnection conn =
                        DBHelper.GetConnection())
                    {
                        conn.Open();

                        using (SqlCommand cmd =
                            new SqlCommand(
                                "sp_InsertUser",
                                conn))
                        {
                            cmd.CommandType =
                                CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue(
                                "@email",
                                txtEmail.Text.Trim());

                            cmd.Parameters.AddWithValue(
                                "@password",
                                txtPassword.Text.Trim());

                            object result =
                                cmd.ExecuteScalar();

                            userId =
                                Convert.ToInt32(result);
                        }
                    }
                }

                string jk =
                    rbLaki.Checked ? "L" : "P";

                using (SqlConnection conn =
                    DBHelper.GetConnection())
                {
                    conn.Open();

                    using (SqlCommand cmd =
                        new SqlCommand(
                            "sp_InsertPasien",
                            conn))
                    {
                        cmd.CommandType =
                            CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue(
                            "@uid",
                            userId);

                        cmd.Parameters.AddWithValue(
                            "@nik",
                            txtNIK.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@nama",
                            txtNama.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@tgl",
                            dtTanggalLahir.Value.Date);

                        cmd.Parameters.AddWithValue(
                            "@jk",
                            jk);

                        cmd.Parameters.AddWithValue(
                            "@alamat",
                            txtAlamat.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@hp",
                            txtNoHP.Text.Trim());

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Registrasi berhasil! Silakan login.",
                    "Sukses",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.Hide();

                new FormLogin().Show();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Gagal mendaftar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBatal_Click(object sender, EventArgs e)
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

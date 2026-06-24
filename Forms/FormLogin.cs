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

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password))
            {
                MessageBox.Show(

                    "Email dan password tidak boleh kosong!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DataTable dt = new DataTable();

            using (SqlConnection conn =
                DBHelper.GetConnection())
            {
                conn.Open();

                using (SqlCommand cmd =
                    new SqlCommand(
                        "sp_LoginUser",
                        conn))
                {
                    cmd.CommandType =
                        CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue(
                        "@email",
                        email);

                    cmd.Parameters.AddWithValue(
                        "@password",
                        password);

                    using (SqlDataAdapter da =
                        new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            if (dt.Rows.Count > 0)
            {
                Session.UserId =
                    Convert.ToInt32(
                        dt.Rows[0]["id"]);

                Session.Email =
                    dt.Rows[0]["email"]
                    .ToString();

                Session.Role =
                    dt.Rows[0]["role"]
                    .ToString();

                if (Session.Role == "admin")
                {
                    Session.NamaLengkap =
                        "Administrator";

                    this.Hide();

                    new FormDashboardAdmin()
                        .Show();
                }
                else
                {
                    DataTable dtPasien =
                        new DataTable();

                    using (SqlConnection conn =
                        DBHelper.GetConnection())
                    {
                        conn.Open();

                        using (SqlCommand cmd =
                            new SqlCommand(
                                "sp_GetPasienByUserId",
                                conn))
                        {
                            cmd.CommandType =
                                CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue(
                                "@uid",
                                Session.UserId);

                            using (SqlDataAdapter da =
                                new SqlDataAdapter(cmd))
                            {
                                da.Fill(dtPasien);
                            }
                        }
                    }

                    if (dtPasien.Rows.Count > 0)
                    {
                        Session.PasienId =
                            Convert.ToInt32(
                                dtPasien.Rows[0]["id"]);

                        Session.NamaLengkap =
                            dtPasien.Rows[0]["nama_lengkap"]
                            .ToString();

                        this.Hide();

                        new FormDashboardPasien()
                            .Show();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Silakan lengkapi data diri terlebih dahulu.",
                            "Info",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        this.Hide();

                        new FormRegister(
                            Session.UserId)
                            .Show();
                    }
                }
            }
            else
            {
                lblError.Text =
                    "Email atau password salah!";

                lblError.Visible = true;
            }
        }


        private void BtnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormRegister().Show();
        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) BtnLogin_Click(sender, e);
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LblAppName_Click(object sender, EventArgs e)
        {

        }

        private void PanelLeft_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

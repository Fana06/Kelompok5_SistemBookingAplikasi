using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using SistemBookingPasien_5.Helpers;

namespace SistemBookingPasien_5.Forms
{
    public partial class FormProfilPasien : Form
    {
        public FormProfilPasien()
        {
            InitializeComponent();
            LoadProfil();
        }

        private void LoadProfil()
        {
            if (SessionHelper.PasienId == 0) return;
            string query = @"SELECT nik, nama_lengkap, tanggal_lahir, jenis_kelamin, alamat, no_hp
                             FROM pasien WHERE id = @id";
            DataTable dt = DBHelper.ExecuteQuery(query,
                new[] { new SqlParameter("@id", SessionHelper.PasienId) });
            if (dt.Rows.Count == 0) return;
            DataRow r = dt.Rows[0];
            txtNIK.Text      = r["nik"].ToString();
            txtNama.Text     = r["nama_lengkap"].ToString();
            dtpLahir.Value   = Convert.ToDateTime(r["tanggal_lahir"]);
            cboJK.Text       = r["jenis_kelamin"].ToString() == "L" ? "Laki-laki" : "Perempuan";
            txtAlamat.Text   = r["alamat"].ToString();
            txtNoHp.Text     = r["no_hp"].ToString();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string nik   = txtNIK.Text.Trim();
            string nama  = txtNama.Text.Trim();
            string jk    = cboJK.SelectedIndex == 0 ? "L" : "P";
            string alamat= txtAlamat.Text.Trim();
            string noHp  = txtNoHp.Text.Trim();
            DateTime tgl = dtpLahir.Value.Date;

            if (string.IsNullOrEmpty(nik) || string.IsNullOrEmpty(nama))
            {
                MessageBox.Show("NIK dan Nama wajib diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlParameter[] parms = {
                new SqlParameter("@nik",    nik),
                new SqlParameter("@nama",   nama),
                new SqlParameter("@tgl",    tgl),
                new SqlParameter("@jk",     jk),
                new SqlParameter("@alamat", alamat),
                new SqlParameter("@nohp",   noHp),
                new SqlParameter("@uid",    SessionHelper.UserId)
            };

            if (SessionHelper.PasienId == 0)
            {
                string ins = @"INSERT INTO pasien (user_id,nik,nama_lengkap,tanggal_lahir,jenis_kelamin,alamat,no_hp)
                               VALUES (@uid,@nik,@nama,@tgl,@jk,@alamat,@nohp)";
                DBHelper.ExecuteNonQuery(ins, parms);
                // update session pasien_id
                object newId = DBHelper.ExecuteScalar(
                    "SELECT id FROM pasien WHERE user_id=@uid",
                    new[] { new SqlParameter("@uid", SessionHelper.UserId) });
                SessionHelper.PasienId    = Convert.ToInt32(newId);
                SessionHelper.NamaLengkap = nama;
            }
            else
            {
                SqlParameter[] uparms = {
                    new SqlParameter("@nik",    nik),
                    new SqlParameter("@nama",   nama),
                    new SqlParameter("@tgl",    tgl),
                    new SqlParameter("@jk",     jk),
                    new SqlParameter("@alamat", alamat),
                    new SqlParameter("@nohp",   noHp),
                    new SqlParameter("@id",     SessionHelper.PasienId)
                };
                string upd = @"UPDATE pasien SET nik=@nik, nama_lengkap=@nama, tanggal_lahir=@tgl,
                               jenis_kelamin=@jk, alamat=@alamat, no_hp=@nohp WHERE id=@id";
                DBHelper.ExecuteNonQuery(upd, uparms);
                SessionHelper.NamaLengkap = nama;
            }

            MessageBox.Show("Profil berhasil disimpan!", "Sukses",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnBatal_Click(object sender, EventArgs e) => this.Close();
    }
}

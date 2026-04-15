using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using SistemBookingPasien_5.Helpers;

namespace SistemBookingPasien_5.Forms
{
    public partial class FormTambahDokter : Form
    {
        private int _dokterId = 0;

        public FormTambahDokter(int dokterId = 0)
        {
            InitializeComponent();
            _dokterId = dokterId;
            if (_dokterId > 0)
            {
                this.Text = "Edit Dokter";
                lblTitle.Text = "✏️ Edit Data Dokter";
                LoadData();
            }
        }

        private void LoadData()
        {
            DataTable dt = DBHelper.ExecuteQuery(
                "SELECT * FROM dokter WHERE id=@id",
                new[] { new SqlParameter("@id", _dokterId) });
            if (dt.Rows.Count == 0) return;
            DataRow r = dt.Rows[0];
            txtNama.Text         = r["nama_dokter"].ToString();
            txtSpesialis.Text    = r["spesialisasi"].ToString();
            txtNoHp.Text         = r["no_hp"].ToString();
            chkAktif.Checked     = Convert.ToBoolean(r["status_aktif"]);
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string nama    = txtNama.Text.Trim();
            string spesial = txtSpesialis.Text.Trim();
            string nohp    = txtNoHp.Text.Trim();
            bool aktif     = chkAktif.Checked;

            if (string.IsNullOrEmpty(nama))
            {
                MessageBox.Show("Nama dokter wajib diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_dokterId == 0)
            {
                string ins = @"INSERT INTO dokter (nama_dokter, spesialisasi, no_hp, status_aktif)
                               VALUES (@nama, @spesial, @nohp, @aktif)";
                DBHelper.ExecuteNonQuery(ins, new[] {
                    new SqlParameter("@nama",    nama),
                    new SqlParameter("@spesial", spesial),
                    new SqlParameter("@nohp",    nohp),
                    new SqlParameter("@aktif",   aktif ? 1 : 0)
                });
                MessageBox.Show("Dokter berhasil ditambahkan!", "Sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string upd = @"UPDATE dokter SET nama_dokter=@nama, spesialisasi=@spesial,
                               no_hp=@nohp, status_aktif=@aktif WHERE id=@id";
                DBHelper.ExecuteNonQuery(upd, new[] {
                    new SqlParameter("@nama",    nama),
                    new SqlParameter("@spesial", spesial),
                    new SqlParameter("@nohp",    nohp),
                    new SqlParameter("@aktif",   aktif ? 1 : 0),
                    new SqlParameter("@id",      _dokterId)
                });
                MessageBox.Show("Data dokter berhasil diperbarui!", "Sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void btnBatal_Click(object sender, EventArgs e) => this.Close();
    }
}

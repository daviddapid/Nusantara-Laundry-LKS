using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NusantaraLaundry
{
    public partial class FormModalPegawaiEdit : Form
    {
        private int _PegawaiId;
        private Pegawai _Pegawai;

        public FormModalPegawaiEdit(int pegawaiId)
        {
            InitializeComponent();
            _PegawaiId= pegawaiId;
            using (NusantaraLaundryDataContext dc = new NusantaraLaundryDataContext())
            {
                //SET JABATANS FOR COMBOBOX
                inputJabatan.DataSource = dc.Jabatans;
                inputJabatan.DisplayMember = "Nama";
                inputJabatan.ValueMember = "Id";

                //Save current Pegawai props
                _Pegawai = dc.Pegawais.Where(p => p.Id == _PegawaiId).FirstOrDefault();
            }
        }

        private void FormModalPegawaiEdit_Load(object sender, EventArgs e)
        {
                inputAlamat.Text = _Pegawai.Alamat;
                inputEmail.Text = _Pegawai.Email;
                inputJabatan.SelectedValue = _Pegawai.JabatanId;
                inputNama.Text = _Pegawai.Nama;
                inputNoTelepon.Text = _Pegawai.NoTelp;
                inputPassword.Text = _Pegawai.Password;
                inputTglLahir.Value = _Pegawai.TglLahir;
                inputUsername.Text = _Pegawai.Username;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Apa anda yakin untuk menghapus data ini ?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            try
            {
                if (result == DialogResult.Yes)
                {
                    using (NusantaraLaundryDataContext dc = new NusantaraLaundryDataContext())
                    {
                        var pegawai = dc.Pegawais.Where(p => p.Id== _PegawaiId).FirstOrDefault();
                        dc.Pegawais.DeleteOnSubmit(pegawai);
                        dc.SubmitChanges();
                    }
                    MessageBox.Show("Data Berhasil Dihapus");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (_validateAllInput())
                {
                    using (NusantaraLaundryDataContext dc = new NusantaraLaundryDataContext())
                    {
                        var pegawai = dc.Pegawais.Where(p => p.Id == _PegawaiId).FirstOrDefault();
                        pegawai.Alamat = inputAlamat.Text;
                        pegawai.NoTelp = inputNoTelepon.Text;
                        pegawai.JabatanId = (int)inputJabatan.SelectedValue;
                        pegawai.Nama = inputNama.Text;
                        pegawai.Password = inputPassword.Text;
                        pegawai.Email = inputEmail.Text;
                        pegawai.TglLahir = inputTglLahir.Value;
                        pegawai.Password = inputPassword.Text;
                        pegawai.Username= inputUsername.Text;

                        dc.SubmitChanges();
                    }
                    MessageBox.Show("Sukses Memperbarui Data");
                }
                else
                {
                    MessageBox.Show("Kolom Inputan Tidak Boleh Ada Yang Kosong");
                }
                
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            
        }

        private bool _validateAllInput()
        {
            bool valid = true;

            if (string.IsNullOrWhiteSpace(inputAlamat.Text))
            {
                errorProvider1.SetError(inputAlamat, "Input alamat tidak boleh kosong");
                valid = false;
            }
            if (string.IsNullOrWhiteSpace(inputEmail.Text))
            {
                errorProvider1.SetError(inputEmail, "Input email tidak boleh kosong");
                valid = false;
            }
            if (string.IsNullOrWhiteSpace(inputNama.Text))
            {
                errorProvider1.SetError(inputNama, "Input nama tidak boleh kosong");
                valid = false;
            }
            if (string.IsNullOrWhiteSpace(inputNoTelepon.Text))
            {
                errorProvider1.SetError(inputNoTelepon, "Input nomor telepon tidak boleh kosong");
                valid = false;
            }
            if (string.IsNullOrWhiteSpace(inputPassword.Text))
            {
                errorProvider1.SetError(inputPassword, "Input password tidak boleh kosong");
                valid = false;
            }
            if (string.IsNullOrWhiteSpace(inputTglLahir.Text))
            {
                errorProvider1.SetError(inputTglLahir, "Input tanggal lahir tidak boleh kosong");
                valid = false;
            }
            if (string.IsNullOrWhiteSpace(inputUsername.Text))
            {
                errorProvider1.SetError(inputUsername, "Input username tidak boleh kosong");
                valid = false;
            }

            return valid;
        }
    }
}

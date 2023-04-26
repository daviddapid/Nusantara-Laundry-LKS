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
    public partial class FormModalPegawai : Form
    {
        public FormModalPegawai()
        {
            InitializeComponent();
        }

        private void FormModalPegawai_Load(object sender, EventArgs e)
        {
            using(NusantaraLaundryDataContext dc = new NusantaraLaundryDataContext())
            {
                inputJabatan.DataSource = dc.Jabatans;
                inputJabatan.DisplayMember = "Nama";
                inputJabatan.ValueMember = "Id";
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (_validateAllInput())
                {
                    errorProvider1.Clear();
                    Pegawai p = new Pegawai
                    {
                        Alamat = inputAlamat.Text,
                        JabatanId = (int)inputJabatan.SelectedValue,
                        Nama = inputNama.Text,
                        Email = inputEmail.Text,
                        NoTelp = inputNoTelepon.Text,
                        Password = inputPassword.Text,
                        TglLahir = inputTglLahir.Value,
                        Username = inputUsername.Text,
                    };

                    using (NusantaraLaundryDataContext dc = new NusantaraLaundryDataContext())
                    {
                        dc.Pegawais.InsertOnSubmit(p);
                        dc.SubmitChanges();
                        MessageBox.Show("Sukses Menambahkan Data Baru");
                    }
                }
                else {
                    MessageBox.Show("Gagal Menambah Data");
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

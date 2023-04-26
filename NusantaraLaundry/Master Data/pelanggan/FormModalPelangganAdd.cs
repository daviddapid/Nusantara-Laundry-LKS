using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NusantaraLaundry.Master_Data.pelanggan
{
    public partial class FormModalPelangganAdd : Form
    {
        public FormModalPelangganAdd()
        {
            InitializeComponent();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (_validatedInputs())
            {
                using (NusantaraLaundryDataContext dc = new NusantaraLaundryDataContext())
                {
                    dc.Pelanggans.InsertOnSubmit(new Pelanggan()
                    {
                        Alamat = inputAlamat.Text,
                        Nama = inputNama.Text,
                        NoTelp = inputNoTelp.Text
                    });
                    dc.SubmitChanges();
                }
                MessageBox.Show("Sukses menambah data pelanggan baru");
            }
            else
            {
                MessageBox.Show("semua inputan tidak boleh kosong");
            }
        }

        private bool _validatedInputs()
        {
            bool valid = true;

            if (string.IsNullOrWhiteSpace( inputNama.Text))
            {
                valid = false;
                errorProvider1.SetError(inputNama, "Nama tidak boleh kosong");
            }
            if (string.IsNullOrWhiteSpace(inputNoTelp.Text))
            {
                valid = false;
                errorProvider1.SetError(inputNoTelp, "No telepon tidak boleh kosong");
            }
            if (string.IsNullOrWhiteSpace(inputAlamat.Text))
            {
                valid = false;
                errorProvider1.SetError(inputAlamat, "Alamat tidak boleh kosong");
            }

            return valid;
        }
    }
}

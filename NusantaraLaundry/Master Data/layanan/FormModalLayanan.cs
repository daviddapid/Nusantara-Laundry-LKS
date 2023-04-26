using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NusantaraLaundry.Master_Data.layanan
{
    public partial class FormModalLayanan : Form
    {
        public FormModalLayanan()
        {
            InitializeComponent();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (_validatedInputs())
                {
                    using (NusantaraLaundryDataContext dc = new NusantaraLaundryDataContext())
                    {
                        Layanan l = new Layanan()
                        {
                            EstimastiDurasi = (int)inputEstimasiDurasi.Value,
                            HargaUnit = (int)inputHarga.Value,
                            KategoriId = (int?)inputKategori.SelectedValue ?? null,
                            Nama = inputNama.Text,
                            UnitId = (int?)inputUnit.SelectedValue ?? null,
                        };
                        dc.Layanans.InsertOnSubmit(l);
                        dc.SubmitChanges();
                    }
                    MessageBox.Show("Sukses menambah data baru");
                }
                else
                {
                    MessageBox.Show("Gagal menambah data baru");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            
        }
        private bool _validatedInputs()
        {
            bool valid = true;
            if (inputEstimasiDurasi.Value<0)
            {
                valid = false;
                errorProvider1.SetError(inputEstimasiDurasi, "Estimasi durasi tidak boleh kurang dari 0 atau mines");
            }
            if (inputHarga.Value < 0)
            {
                valid = false;
                errorProvider1.SetError(inputEstimasiDurasi, "Input harga tidak boleh kurang dari 0 atau mines");
            }
            if (string.IsNullOrWhiteSpace(inputNama.Text))
            {
                valid = false;
                errorProvider1.SetError(inputNama, "Input nama, tidak boleh kosong");
            }

            return valid;
        }

        private void FormModalLayanan_Load(object sender, EventArgs e)
        {
            using (NusantaraLaundryDataContext dc = new NusantaraLaundryDataContext())
            {
                inputKategori.DataSource = dc.Kategoris;
                inputKategori.DisplayMember= "Nama";
                inputKategori.ValueMember = "Id";

                inputUnit.DataSource = dc.Units;
                inputUnit.DisplayMember = "Nama";
                inputUnit.ValueMember = "Id";
            }
        }
    }
}

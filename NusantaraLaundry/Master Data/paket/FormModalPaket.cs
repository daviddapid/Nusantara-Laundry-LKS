using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NusantaraLaundry.Master_Data.paket
{
    public partial class FormModalPaket : Form
    {
        public FormModalPaket()
        {
            InitializeComponent();
        }
        private bool _validatedInputs()
        {
            bool valid = true;

            if (inputHarga.Value < 0)
            {
                valid = false;
            }
            if (inputTotalUnit.Value < 0)
            {
                valid = false;
            }

            return valid;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (_validatedInputs())
            {
                Paket paket = new Paket()
                {
                    Harga = (int)inputHarga.Value,
                    LayananId = (int)inputLayanan.SelectedValue,
                    TotalUnit = (int)inputTotalUnit.Value,
                };

                using (NusantaraLaundryDataContext dc = new NusantaraLaundryDataContext())
                {
                    dc.Pakets.InsertOnSubmit(paket);
                    dc.SubmitChanges();
                }
                MessageBox.Show("Sukses menambah data baru");
            }
            else
            {
                MessageBox.Show("Kolom input tidak boleh ada yang kosong");
            }

        }

        private void FormModalPaket_Load(object sender, EventArgs e)
        {
            using (NusantaraLaundryDataContext dc = new NusantaraLaundryDataContext())
            {
                inputLayanan.DataSource = dc.Layanans;
                inputLayanan.DisplayMember = "Nama";
                inputLayanan.ValueMember= "Id";
            }
        }
    }
}

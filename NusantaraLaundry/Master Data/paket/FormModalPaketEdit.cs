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
    public partial class FormModalPaketEdit : Form
    {
        private int _paketId;
        public FormModalPaketEdit(int paketId)
        {
            InitializeComponent();
            _paketId = paketId;
        }
        private bool _validatedInputs()
        {
            bool valid = true;
            if (inputTotalUnit.Value < 0)
            {
                valid = false;
            }
            if (inputHarga.Value < 0)
            {
                valid = false;
            }
            return valid;
        }
        private void FormModalPaketEdit_Load(object sender, EventArgs e)
        {
            using (NusantaraLaundryDataContext dc = new NusantaraLaundryDataContext())
            {
                Paket selectedPaket = dc.Pakets.Where(p => p.Id == _paketId).FirstOrDefault(); 

                //set layanan combobox
                inputLayanan.DataSource = dc.Layanans;
                inputLayanan.DisplayMember = "Nama";
                inputLayanan.ValueMember = "Id";
                inputLayanan.SelectedValue = selectedPaket.LayananId;

                inputTotalUnit.Value = selectedPaket.TotalUnit;
                inputHarga.Value = selectedPaket.Harga;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (NusantaraLaundryDataContext dc = new NusantaraLaundryDataContext())
                {
                    Paket selectedPaket = dc.Pakets.Where(p => p.Id == _paketId).FirstOrDefault();
                    dc.Pakets.DeleteOnSubmit(selectedPaket);
                    dc.SubmitChanges();
                }
                MessageBox.Show("Sukses menghapus data");
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
                if (_validatedInputs())
                {
                    using (NusantaraLaundryDataContext dc = new NusantaraLaundryDataContext())
                    {
                        Paket selectedPaket = dc.Pakets.Where(p => p.Id == _paketId).FirstOrDefault();
                        selectedPaket.LayananId = (int)inputLayanan.SelectedValue;
                        selectedPaket.TotalUnit = (int)inputTotalUnit.Value;
                        selectedPaket.Harga = (int)inputHarga.Value;
                        dc.SubmitChanges();
                    }
                    MessageBox.Show("Sukses memperbarui data");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            
        }
    }
}

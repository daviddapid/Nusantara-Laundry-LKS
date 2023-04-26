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
    public partial class FormModalLayananEdit : Form
    {
        private int _layananId;

        public FormModalLayananEdit(int layananId)
        {
            InitializeComponent();
            _layananId = layananId;
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            try
            {
                using (NusantaraLaundryDataContext dc = new NusantaraLaundryDataContext())
                {
                    var layanan = dc.Layanans.Where(l => l.Id == _layananId).FirstOrDefault();
                    dc.Layanans.DeleteOnSubmit(layanan);
                    dc.SubmitChanges();
                }
                MessageBox.Show("Sukses menghapus data");
                this.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (NusantaraLaundryDataContext dc = new NusantaraLaundryDataContext())
                {
                    var layanan = dc.Layanans.Where(l => l.Id == _layananId).FirstOrDefault();
                    layanan.Nama = inputNama.Text;
                    layanan.HargaUnit = (int)inputHarga.Value;
                    layanan.EstimastiDurasi = (int)inputEstimasiDurasi.Value;
                    layanan.KategoriId = (int)inputKategori.SelectedValue;
                    layanan.UnitId = (int)inputUnit.SelectedValue;
                    dc.SubmitChanges();
                }
                MessageBox.Show("Sukses memperbarui data");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void FormModalLayananEdit_Load(object sender, EventArgs e)
        {
            try
            {
                using (NusantaraLaundryDataContext dc = new NusantaraLaundryDataContext())
                {
                    //binding datasource
                    inputKategori.DataSource = dc.Kategoris;
                    inputKategori.DisplayMember = "Nama";
                    inputKategori.ValueMember = "Id";

                    inputUnit.DataSource = dc.Units;
                    inputUnit.DisplayMember = "Nama";
                    inputUnit.ValueMember = "Id";

                    //set old value
                    var layanan = dc.Layanans.Where(l => l.Id == _layananId).FirstOrDefault();
                    inputEstimasiDurasi.Value = layanan.EstimastiDurasi;
                    inputHarga.Value = layanan.HargaUnit;
                    inputNama.Text = layanan.Nama;
                    inputKategori.SelectedValue = layanan.KategoriId ?? 1;
                    inputUnit.SelectedValue = layanan.UnitId ?? 1;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            
        }
    }
}

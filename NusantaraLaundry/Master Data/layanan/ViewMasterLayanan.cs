using NusantaraLaundry.Master_Data.layanan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NusantaraLaundry.Views
{
    public partial class ViewMasterLayanan : UserControl
    {
        public ViewMasterLayanan()
        {
            InitializeComponent();
        }

        private void ViewMasterLayanan_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            using (NusantaraLaundryDataContext dc = new NusantaraLaundryDataContext())
            {
                dataGridView1.DataSource = dc.Layanans.Select(l => new
                {
                    l.Id,
                    l.Nama,
                    Unit = l.Unit.Nama,
                    l.HargaUnit,
                    l.EstimastiDurasi,
                    Kategori = l.Kategori.Nama,
                });
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            (new FormModalLayanan()).ShowDialog();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedId = (int)dataGridView1.Rows[e.RowIndex].Cells["Id"].Value;
            (new FormModalLayananEdit(selectedId)).ShowDialog();
            loadData();
        }

        private void searchbar_TextChanged(object sender, EventArgs e)
        {
            using (NusantaraLaundryDataContext dc = new NusantaraLaundryDataContext())
            {
                dataGridView1.DataSource = dc.Layanans.Where(l=> l.Nama.Contains(searchbar.Text)).Select(l => new
                {
                    l.Id,
                    l.Nama,
                    Unit = l.Unit.Nama,
                    l.HargaUnit,
                    l.EstimastiDurasi,
                    Kategori = l.Kategori.Nama,
                });
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            searchbar.Text= string.Empty;
            loadData();
        }
    }
}

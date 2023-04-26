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
    public partial class ViewMasterPaket : UserControl
    {
        public ViewMasterPaket()
        {
            InitializeComponent();
        }

        private object _displayedPaketProps(Paket paket)
        {
            return new
            {
                paket.Harga,
                paket.Id,
                Layanan = paket.Layanan.Nama,
                paket.TotalUnit
            };
        }
        private void _loadData()
        {
            using (NusantaraLaundryDataContext dc = new NusantaraLaundryDataContext())
            {
                dataGridView1.DataSource = dc.Pakets.Select(p => _displayedPaketProps(p));
            }
        }
        private void ViewMasterLayanan_Load(object sender, EventArgs e)
        {
            _loadData();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            (new FormModalPaket()).ShowDialog();
            _loadData();
        }

        private void searchbar_TextChanged(object sender, EventArgs e)
        {
            using (NusantaraLaundryDataContext dc = new NusantaraLaundryDataContext())
            {
                dataGridView1.DataSource = dc.Pakets.Where(p => p.Layanan.Nama.Contains(searchbar.Text)).Select(p => _displayedPaketProps(p));
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedId = (int)dataGridView1.Rows[e.RowIndex].Cells["Id"].Value;
            (new FormModalPaketEdit(selectedId)).ShowDialog();
            _loadData();
        }
    }
}

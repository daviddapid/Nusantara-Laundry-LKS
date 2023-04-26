using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NusantaraLaundry.transaksi.lihat_transaksi
{
    public partial class ViewLihatTransaksi : UserControl
    {
        private NusantaraLaundryDataContext dc = new NusantaraLaundryDataContext();
        private Transaksi _selectedTransaksi;
        
        public ViewLihatTransaksi()
        {
            InitializeComponent();
        }

        private void ViewLihatTransaksi_Load(object sender, EventArgs e)
        {
            gridviewTransaksi.DataSource = dc.Transaksis.Select(t => new
            {
                t.Id,
                t.PelangganId,
                PelangganNama = t.Pelanggan.Nama,
                t.PegawaiId,
                PegawaiNama = t.Pegawai.Nama,
                t.TanggalTransaksi,
                t.EstimasiSelesai,
                btnSelesai = new Button() { Text= "david"}
            });
            
        }

        private void gridviewTransaksi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string selectedTransaksiId = (string)gridviewTransaksi.Rows[e.RowIndex].Cells["Id"].Value;
            _selectedTransaksi = dc.Transaksis.Where(t => string.Equals(t.Id, selectedTransaksiId)).FirstOrDefault();
            if (_selectedTransaksi == null)
            {
                MessageBox.Show($"Detail Transaksi dengan Id:\"{_selectedTransaksi.Id}\" Tidak ditemukan");
            }
            else
            {
                _loadDetailTransaksis();
                foreach (DataGridViewRow currentRow in gridviewDetailTransaksi.Rows)
                {
                    if (currentRow.Cells["TanggalSelesai"].Value != null)
                    {
                        currentRow.Cells["btnSelesai"] = new DataGridViewTextBoxCell() { Value = "-" };
                    }

                }
            }
        }

        private void _loadDetailTransaksis()
        {
            gridviewDetailTransaksi.DataSource = _selectedTransaksi.DetailTransaksis.Select(dt => new
            {
                dt.Id,
                NamaLayanan = dt.Layanan.Nama,
                PaketId = dt.DetailPaketId,
                dt.HargaUnit,
                dt.TotalUnit,
                dt.TanggalSelesai,
            }).ToList();
        }

        private void gridviewDetailTransaksi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bool notCompletedTrans = gridviewDetailTransaksi.Rows[e.RowIndex].Cells["TanggalSelesai"].Value == null;
            if (gridviewDetailTransaksi.Columns[e.ColumnIndex].Name == "btnSelesai" && notCompletedTrans)
            {
                var isSelesai = MessageBox.Show("Apa anda yakin mengubah status transaksi ini menjadi selesai?", "Konfirmasi Selesai", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (isSelesai == DialogResult.Yes)
                {
                    int selectedDetailTransaksiId = (int)gridviewDetailTransaksi.Rows[e.RowIndex].Cells["DetailTransaksiId"].Value;
                    
                    DetailTransaksi _detailTran = dc.DetailTransaksis.Where(dt => dt.Id == selectedDetailTransaksiId).FirstOrDefault();
                    _detailTran.TanggalSelesai = DateTime.Now;
                    dc.SubmitChanges();

                    _loadDetailTransaksis();
                    MessageBox.Show("Sukses mengkonfirmasi transaksi telah selesai");
                }
            
            }
        }
        
    }
}

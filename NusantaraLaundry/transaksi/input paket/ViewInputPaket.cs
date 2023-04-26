using NusantaraLaundry.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NusantaraLaundry.transaksi.input_paket
{
    public partial class ViewInputPaket : UserControl
    {
        private Paket _selectedPaket;
        private Pelanggan _selectedPelanggan;
        public ViewInputPaket()
        {
            InitializeComponent();
        }

        private void ViewInputPaket_Load(object sender, EventArgs e)
        {
            using (NusantaraLaundryDataContext dc= new NusantaraLaundryDataContext())
            {
                gridviewPaket.DataSource = dc.Pakets.Select(p => new
                {
                    p.Id,
                    Layanan = p.Layanan.Nama,
                    p.TotalUnit,
                    p.Harga
                });
            }
        }

        private void gridviewPaket_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedId = (int)gridviewPaket.Rows[e.RowIndex].Cells["Id"].Value;
            using (NusantaraLaundryDataContext dc = new NusantaraLaundryDataContext())
            {
                _selectedPaket = dc.Pakets.Where(p => p.Id == selectedId).FirstOrDefault();
                inputPaketId.Text = _selectedPaket.Id.ToString();
                inputLayananNama.Text = _selectedPaket.Layanan.Nama;
                inputHarga.Value = _selectedPaket.Harga;
            }
        }

        private void inputNoTelp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(inputNoTelp.Text))
                {
                    MessageBox.Show("No telepon harus diisi terlebih dahulu");
                }
                else
                {
                    _searchPelanggan();
                }
            }
        }

        private void _searchPelanggan()
        {
            using (NusantaraLaundryDataContext dc = new NusantaraLaundryDataContext())
            {
                Pelanggan pel = dc.Pelanggans.Where(p => p.NoTelp == inputNoTelp.Text).FirstOrDefault();
                if (pel == null)
                {
                    inputNama.Clear();
                    inputAlamat.Clear();
                    btnOrder.Enabled = false;
                    MessageBox.Show($"Pelanggan dengan no telp \"{inputNoTelp.Text}\" tidak ditemukan");
                }
                else
                {
                    _selectedPelanggan = pel;
                    inputNama.Text = pel.Nama;
                    inputAlamat.Text = pel.Alamat;
                    btnOrder.Enabled = true;
                    MessageBox.Show("Pelanggan ditemukan");
                }
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            using (NusantaraLaundryDataContext dc = new NusantaraLaundryDataContext())
            {
                //insert transaksi
                Transaksi t = new Transaksi() {
                    Id = "Order/" + DateTime.Now.ToString("yyy/MM/d"),
                    PelangganId = _selectedPelanggan.Id,
                    PegawaiId = Auth.Pegawai.Id,
                    TanggalTransaksi = DateTime.Now,
                    EstimasiSelesai = DateTime.Now.AddMinutes(_selectedPaket.TotalUnit * _selectedPaket.Layanan.EstimastiDurasi)
                };
                dc.Transaksis.InsertOnSubmit(t);

                //insert detail paket
                DetailPaket dp = new DetailPaket()
                {
                    PelangganId = _selectedPelanggan.Id,
                    PaketId = _selectedPaket.Id,
                    Harga = _selectedPaket.Harga,
                    TanggalMulai = DateTime.Now,
                    TanggalSelesai = DateTime.Now.AddDays(7),
                };
                dc.DetailPakets.InsertOnSubmit(dp);

                //insert detail transaksi
                DetailTransaksi dt = new DetailTransaksi()
                {
                    TransaksiId = t.Id,
                    LayananId = _selectedPaket.LayananId,
                    HargaUnit = _selectedPaket.Harga,
                    TotalUnit = _selectedPaket.TotalUnit,
                    DetailPaketId = dp.Id,
                    TanggalSelesai = dp.TanggalSelesai,
                };
                dc.DetailTransaksis.InsertOnSubmit(dt);

                dc.SubmitChanges();
            }
            MessageBox.Show("Sukses melakukan transaksi");
        }
    }
}

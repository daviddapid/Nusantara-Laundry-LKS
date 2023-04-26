using NusantaraLaundry.Master_Data.pelanggan;
using NusantaraLaundry.Services;
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

namespace NusantaraLaundry.transaksi.input_transaksi
{
    public partial class ViewInputTransaksi : UserControl
    {

        private Layanan _selectedLayanan;
        private Pelanggan _selectedPelanggan;
        private List<object> _detailOrders = new List<object>();
        private List<DetailTransaksi> _detailTransaksi = new List<DetailTransaksi>();

        // for track gridviewDEtailOrder
        private int _selectedRecordIndex;

        public ViewInputTransaksi()
        {
            InitializeComponent();
        }

        private void ViewInputTransaksi_Load(object sender, EventArgs e)
        {
            using (NusantaraLaundryDataContext dc = new NusantaraLaundryDataContext())
            {
                gridviewLayanan.DataSource = dc.Layanans.Select(l => new
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
        private void gridviewLayanan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            using (NusantaraLaundryDataContext dc = new NusantaraLaundryDataContext())
            {
                int layananId = (int)gridviewLayanan.Rows[e.RowIndex].Cells["Id"].Value;
                _selectedLayanan = dc.Layanans.Where(l => l.Id == layananId).FirstOrDefault();
            }
            inputQuantity.Enabled = true;
            inputNamaLayanan.Text = _selectedLayanan.Nama;
            inputQuantity.Value = 1;
            inputHarga.Value = _selectedLayanan.HargaUnit;
        }

        //subtotal selected layanan
        private void inputQuantity_ValueChanged(object sender, EventArgs e)
        {
            inputHarga.Value = inputQuantity.Value * _selectedLayanan.HargaUnit;
        }

        private void buttonTambahLayanan_Click(object sender, EventArgs e)
        {
            //set gridviewDetailOrder
            _detailOrders.Add(new
            {
                LayananId = _selectedLayanan.Id,
                NamaLayanan = _selectedLayanan.Nama,
                Qty = inputQuantity.Value,
                Harga = inputHarga.Value
            });
            gridViewDetailOrder.DataSource = _detailOrders.ToList();

            //save or store the current selected layanan to _detailTransaksi, for the next order insert
            _detailTransaksi.Add(new DetailTransaksi()
            {
                LayananId = _selectedLayanan.Id,
                HargaUnit = _selectedLayanan.HargaUnit,
                TotalUnit = (int)inputQuantity.Value,
                TanggalSelesai = DateTime.Now.AddMinutes(_selectedLayanan.EstimastiDurasi * (int)inputQuantity.Value),
            });

            _updateGrandTotal();
        }

        private void _updateGrandTotal()
        {
            inputGrandtotal.Value = (decimal)_detailTransaksi.Select(p => new
            {
                Subtotal = p.HargaUnit * p.TotalUnit
            }).Sum(p => p.Subtotal);
        }

        private void gridViewDetailOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _selectedRecordIndex = e.RowIndex;
            btnHapusOrderDetail.Enabled = true;
        }

        private void btnHapusOrderDetail_Click(object sender, EventArgs e)
        {
            _detailOrders.RemoveAt(_selectedRecordIndex);
            _detailTransaksi.RemoveAt(_selectedRecordIndex);
            gridViewDetailOrder.DataSource = _detailOrders.ToList();
            btnHapusOrderDetail.Enabled = false;

            _updateGrandTotal();
        }


        private void inputNoTelp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                using (NusantaraLaundryDataContext dc = new NusantaraLaundryDataContext())
                {
                    _selectedPelanggan = dc.Pelanggans.Where(p => p.NoTelp == inputNoTelp.Text).FirstOrDefault();
                    if (_selectedPelanggan == null)
                    {
                        MessageBox.Show($"Pelanggan dengan Nomor : \"{inputNoTelp.Text}\" tidak ditemukan");
                    }
                    else
                    {
                        inputNama.Text = _selectedPelanggan.Nama;
                        inputAlamat.Text = _selectedPelanggan.Alamat;
                        btnOrder.Enabled = true;
                        MessageBox.Show("Pelanggan ditemukan");
                    }
                }
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (_validatedInputs())
            {
                using (NusantaraLaundryDataContext dc = new NusantaraLaundryDataContext())
                {
                    Transaksi t = new Transaksi()
                    {
                        Id = inputIdTransaksi.Text,
                        PegawaiId = Auth.Pegawai.Id,
                        PelangganId = _selectedPelanggan.Id,
                        TanggalTransaksi = DateTime.Now,
                        EstimasiSelesai = _detailTransaksi.Max(dt => dt.TanggalSelesai).Value,
                    };

                    foreach (DetailTransaksi dt in _detailTransaksi)
                    {
                        t.DetailTransaksis.Add(dt);
                    }
                    dc.Transaksis.InsertOnSubmit(t);
                    dc.SubmitChanges();
                }
                MessageBox.Show("Sukses melakukan transaksi");
            }
            else
            {
                MessageBox.Show("Harap Memastikan setiap kolom inputan telah valid atau terisi");
            }
        }

        private bool _validatedInputs()
        {
            bool valid = true;
            if (string.IsNullOrWhiteSpace(inputIdTransaksi.Text))
            {
                valid = false;
                errorProvider1.SetError(inputIdTransaksi, "Masukkan Id Transaksi Terlebih Dahulu");
            }
            if (inputGrandtotal.Value < 0)
            {
                valid = false;
                errorProvider1.SetError(inputGrandtotal, "Nilah tidak boleh kurang dari 0 atau minus");
            }
            if (string.IsNullOrEmpty(inputNoTelp.Text))
            {
                valid = false;
                errorProvider1.SetError(inputNoTelp, "No telepon tidak boleh kosong");
            }
            if (string.IsNullOrEmpty(inputAlamat.Text))
            {
                valid = false;
                errorProvider1.SetError(inputAlamat, "Alamat tidak boleh kosong");
            }
            if (string.IsNullOrEmpty(inputNama.Text))
            {
                valid = false;
                errorProvider1.SetError(inputNama, "Alamat tidak boleh kosong");
            }

            return valid;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            (new FormModalPelangganAdd()).ShowDialog();
        }
    }
}

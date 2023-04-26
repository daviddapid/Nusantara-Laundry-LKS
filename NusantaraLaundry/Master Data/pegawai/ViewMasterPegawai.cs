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
    public partial class ViewMasterPegawai : UserControl
    {
        
        public ViewMasterPegawai()
        {
            InitializeComponent();
        }
        ///<summary>config or return the props that should displayed</summary>
        private object _displayedPegawaiProps(Pegawai pegawai)
        {
            return new
            {
                pegawai.Id,
                pegawai.Username,
                pegawai.Password,
                pegawai.Nama,
                pegawai.Email,
                pegawai.Alamat,
                pegawai.NoTelp,
                pegawai.TglLahir,
                Jabatan = pegawai.Jabatan.Nama
            };
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            (new FormModalPegawai()).ShowDialog(); 
            loadDataPegawai();
        }

        private void ViewMasterPegawai_Load(object sender, EventArgs e)
        {
            loadDataPegawai();
        }
        private void loadDataPegawai()
        {
            using (NusantaraLaundryDataContext dc = new NusantaraLaundryDataContext())
            {
                dataGridView1.DataSource = dc.Pegawais.Select(p => _displayedPegawaiProps(p));
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedPegawaiId = (int)dataGridView1.Rows[e.RowIndex].Cells["Id"].Value;
            (new FormModalPegawaiEdit(selectedPegawaiId)).ShowDialog();
            loadDataPegawai();
        }

        private void searchbar_TextChanged(object sender, EventArgs e)
        {
            using (NusantaraLaundryDataContext dc = new NusantaraLaundryDataContext())
            {
                dataGridView1.DataSource = dc.Pegawais.Where(
                        p => p.Nama.Contains(searchbar.Text) || 
                        p.Email.Contains(searchbar.Text) ||
                        p.NoTelp.Contains(searchbar.Text)
                    ).Select(p =>  _displayedPegawaiProps(p) );
            }
        }
    }
}

using NusantaraLaundry.Master_Data.paket;
using NusantaraLaundry.Services;
using NusantaraLaundry.transaksi.input_paket;
using NusantaraLaundry.transaksi.input_transaksi;
using NusantaraLaundry.transaksi.lihat_transaksi;
using NusantaraLaundry.Views;
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

namespace NusantaraLaundry
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            lblCurrentTime.Text = DateTime.Now.ToString();
            lblUsername.Text = Auth.Pegawai.Username;
            if(Auth.Pegawai.Jabatan.Id != 1)
            {
                tabControl1.TabPages.Remove(tabPageMasterData);
            }
        }

        private void btnMaster_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Master");
        }

        //===METHOD NAVIGATION VIEW====
        private void navigateView(UserControl userControl, SplitContainer splitContainer)
        {
            splitContainer.Panel2.Controls.Clear();

            userControl.Dock = DockStyle.Fill;
            splitContainer.Panel2.Controls.Add(userControl);
        }
        private void btnViewPegawai_Click(object sender, EventArgs e)
        {
            navigateView(new ViewMasterPegawai(), splitContainerMaster);
        }

        private void btnViewLayanan_Click(object sender, EventArgs e)
        {
            navigateView(new ViewMasterLayanan(), splitContainerMaster);
        }
        private void btnViewPaket_Click(object sender, EventArgs e)
        {
            navigateView(new ViewMasterPaket(), splitContainerMaster);
        }
        private void btnViewInputTransaksi_Click(object sender, EventArgs e)
        {
            navigateView(new ViewInputTransaksi(), splitContainerTransaksi);
        }
        private void btnViewInputPaket_Click(object sender, EventArgs e)
        {
            navigateView(new ViewInputPaket(), splitContainerTransaksi);
        }
        private void btnViewLihatTransaksi_Click(object sender, EventArgs e)
        {
            navigateView(new ViewLihatTransaksi(), splitContainerTransaksi);
        }
        //===END NAVIGATION VIEW====

        //GENERAL METHOD
        private void button1_Click(object sender, EventArgs e)
        {
            Auth.Logout();
            this.Close();
        }

        private void FormHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if the user is currently login (not logout),
            //and the user click X (close button).
            //then exit app
            if(Auth.isAuthenticated())
            {
                Application.Exit();
            }
        }
    }
}

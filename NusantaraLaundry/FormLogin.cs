using NusantaraLaundry.Services;
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

namespace NusantaraLaundry
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(Auth.login(txtboxUsername.Text, txtboxPassword.Text))
            {
                this.Hide();
                this.txtboxUsername.Clear();
                this.txtboxPassword.Clear();
                Auth.FormLogin = this;
                (new FormMain()).Show();
            }
            else
            {
                MessageBox.Show("Gagal Login, Harap Masukkan Data yang Valid");
            }
        }
    }
}

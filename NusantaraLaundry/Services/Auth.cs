using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NusantaraLaundry.Services
{
    public static class Auth
    {
        private static bool _isAuthenticated = false;
        public static Pegawai Pegawai { get; private set; }
        public static FormLogin FormLogin { get; set; }

        public static bool isAuthenticated() => _isAuthenticated;
        public static bool login(string username, string password)
        {
            NusantaraLaundryDataContext dc = new NusantaraLaundryDataContext();
            Pegawai pegawai = dc.Pegawais.Where(p => p.Username == username && p.Password == password).FirstOrDefault();
            if(pegawai != null)
            {
                _isAuthenticated = true;
                Pegawai = pegawai;
                return true;
            }
            return false;
            
        }
        public static void Logout()
        {
            _isAuthenticated = false;
            Pegawai = null;
            FormLogin.Show();
        }

    }
}

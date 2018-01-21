using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belajar_csharp
{
    class Manusia : MahlukHidup
    {
        private string namaLengkap;
        private int usia;
        private string alamat;
        private string agama;

        public Manusia( string nama,int usia,string setAlamat,string setAgama )
        {
            namaLengkap = nama;
            usia = usia;
            alamat = setAlamat;
            agama = setAgama;
        }

        public string getNama()
        {
            return namaLengkap;
        }
        public int getUsia()
        {
            return usia;
        }
        public string getAlamat()
        {
            return alamat;
        }

        public string getAgama()
        {
            return agama;
        }
    }
}

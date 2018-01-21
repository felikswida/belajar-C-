using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belajar_csharp
{
    class Hewan : MahlukHidup
    {
        private string namaHewan;
        private int tinggiRataRata;
        private int jumlahKaki;
        private string warnaBulu;
        private string tempatHidup;

        public Hewan(string namahewan,int tinggiratarata,int jumlahkaki, string warnabulu)
        {
            namaHewan = namahewan;
            tinggiRataRata = tinggiratarata;
            jumlahKaki = jumlahkaki;
            warnaBulu = warnabulu;
        }

        public string getNamaHewan()
        {
            return namaHewan;
        }

        public int getTinggiRataRata()
        {
            return tinggiRataRata;
        }

        public int getJumlahKaki()
        {
            return jumlahKaki;
        }

        public string getWarnaBulu()
        {
            return warnaBulu;

        }
    }
}

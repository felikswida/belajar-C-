using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belajar_csharp
{
    class Tumbuhan : MahlukHidup
    {
        private string namaTumbuhan;
        private string jenisAkar;

        public Tumbuhan(string namatumbuhan,string jenisakar)
        {
            namaTumbuhan = namatumbuhan;
            jenisAkar = jenisakar;
        }
        public string getNamaTumbuhan()
        {
            return namaTumbuhan;
        }
        public string getJenisAkar()
        {
            return jenisAkar;
        }
    }
}

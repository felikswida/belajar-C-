using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belajar_csharp
{
    class MahlukHidup
    {
        private string habitatHidup;
        private int umurHidup;
        private string jenisKelamin ;
        
        public void setHabitatHidup(string habitat)
        {
            habitatHidup = habitat;
        }
        public void setRataRataHidup(int umur)
        {
            umurHidup = umur;
        }
        public void setJenisKelamin(string kelamin)
        {
            jenisKelamin = kelamin;
        }

        public string getHabitatHidup()
        {
            return habitatHidup;
        }
        public int getRataRataUmurHidup()
        {
            return umurHidup;
        }
        public string getJenisKelamin()
        {
            return jenisKelamin;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belajar_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Hewan anjing = new Hewan("anjing kampung", 50, 4, "merah");
            anjing.setHabitatHidup("darat");
            anjing.setJenisKelamin("Jantan");
            anjing.setRataRataHidup(40);
            Console.WriteLine("Jenis hewan \t: {0}",anjing.getNamaHewan());
            Console.WriteLine("Jumlah kaki\t: {0}", anjing.getJumlahKaki());
            Console.WriteLine("Tinggi \t\t: {0}", anjing.getTinggiRataRata());
            Console.WriteLine("Warna Hewan \t: {0}", anjing.getWarnaBulu());
            Console.WriteLine("Habitat hidup\t: {0}", anjing.getHabitatHidup());
            Console.WriteLine("Jenis Kelamin\t: {0}", anjing.getJenisKelamin());
            Console.WriteLine("Rata2 Usia\t: {0}", anjing.getRataRataUmurHidup());


            Tumbuhan anggrek = new Tumbuhan("Angrek Hitam", "Serabut");
            anggrek.setHabitatHidup("darat");
            anggrek.setJenisKelamin("Betina");
            anggrek.setRataRataHidup(100);
            Console.WriteLine("\n\nnama Tumbuhan\t: {0}", anggrek.getNamaTumbuhan());
            Console.WriteLine("Jenis Akar\t: {0}", anggrek.getJenisAkar());
            Console.WriteLine("habitat Hidup\t: {0}", anggrek.getHabitatHidup());
            Console.WriteLine("Jenis Kelamin\t: {0}", anggrek.getJenisKelamin());
            Console.WriteLine("Rata2 Usia\t: {0}", anggrek.getRataRataUmurHidup());

            Manusia ivana = new Manusia("Ivana Wida Mardaneta", 8, "Argamas Barat", "Kristen");
            ivana.setHabitatHidup("darat");
            ivana.setJenisKelamin("Perempuan");
            ivana.setRataRataHidup(100);
            Console.WriteLine("\n\nnama Manusia\t: {0}", ivana.getNama());
            Console.WriteLine("Usia\t\t: {0}", ivana.getUsia());
            Console.WriteLine("Alaamt\t\t: {0}", ivana.getAlamat());
            Console.WriteLine("Agama\t\t: {0}", ivana.getAgama());
            Console.WriteLine("habitat Hidup\t: {0}", ivana.getHabitatHidup());
            Console.WriteLine("Jenis Kelamin\t: {0}", ivana.getJenisKelamin());
            Console.WriteLine("Rata2 Usia\t: {0}", ivana.getRataRataUmurHidup());

            Console.ReadKey();
        }
    }
}

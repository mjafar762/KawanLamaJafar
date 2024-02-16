using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soal_Kawan_Lama_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Jumlah anting per jenis
            int jumlahRuby = 5;
            int jumlahTopaz = 3;
            int jumlahPermata = 1;

            // Harga per pasang anting
            int hargaRuby = 1000000;
            int hargaTopaz = 1250000;
            int hargaPermata = 3000000;

            // Menghitung pendapatan maksimum
            int Jumlah_Ruby = (jumlahRuby * hargaRuby);
            int Jumlah_Topaz = (jumlahTopaz * hargaTopaz);
            int Jumlah_Permata = (jumlahPermata * hargaPermata);
            int pendapatanMax = Jumlah_Ruby + Jumlah_Topaz + Jumlah_Permata;
            Console.WriteLine("Ruby : Rp" + Jumlah_Ruby.ToString("###,###,###"));
            Console.WriteLine("Topaz : Rp" + Jumlah_Topaz.ToString("###,###,###"));
            Console.WriteLine("Permata: Rp" + Jumlah_Permata.ToString("###,###,###"));

            Console.WriteLine("Potensi pendapatan maksimum dari toko KawanLamaJewel: Rp" + pendapatanMax.ToString("###,###,###"));
            System.Threading.Thread.Sleep(5000);
        }
    }
}

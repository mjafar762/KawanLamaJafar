using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soal_Kawan_Lama_Nomer3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(perkalian(5, 4));
           System.Threading.Thread.Sleep(5000);
        }
        static int perkalian(int j, int k)
        {
            int hasil = 0; 
            while (j > 0)
            {
                hasil += k;
                j--; 
            }
            return hasil; 
        }
    }
}

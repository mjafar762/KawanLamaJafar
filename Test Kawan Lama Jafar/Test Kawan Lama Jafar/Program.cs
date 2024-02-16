using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Kawan_Lama_Jafar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "USOMAANAPAIUMASYDNIP";
            int count = JumlahSiapaWords(input);
            Console.WriteLine("Jumlah kata yang dihasilkan: " + count);
            System.Threading.Thread.Sleep(5000);
        }
        static int JumlahSiapaWords(string input)
        {
            int count = 0;

            int countS = 0, countI = 0, countA = 0, countP = 0;
            foreach (char c in input)
            {
                if (c == 'S') countS++;
                else if (c == 'I') countI++;
                else if (c == 'A') countA++;
                else if (c == 'P') countP++;
            }

            while (countS >= 1 && countI >= 1 && countA >= 2 && countP >= 1)
            {
                count++;
                countS--;
                countI--;
                countA -= 2;
                countP--;
            }

            return count;
        }
    }
}

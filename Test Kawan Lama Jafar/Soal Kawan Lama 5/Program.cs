using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soal_Kawan_Lama_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "2871337";

            Console.WriteLine("Input:");
            Console.WriteLine(input);

            Console.WriteLine("\nPyramid:");
            PrintPyramid(input);
            System.Threading.Thread.Sleep(5000);

        }

        static void PrintPyramid(string input)
        {
            int length = input.Length;
            int currentNumber = int.Parse(input);
            int currentDigit = 0;

            while (currentNumber > 0)
            {
                
                Console.WriteLine(currentNumber.ToString().PadLeft(length - currentDigit, ' '));

               
                currentNumber /= 10;

                
                currentDigit++;
            }
           
        }
    }
}

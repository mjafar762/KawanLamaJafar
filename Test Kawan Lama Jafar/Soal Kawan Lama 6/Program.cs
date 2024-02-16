using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soal_Kawan_Lama_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 27, 11, 23, 20, 65, 12, 11, 10, 97 };

            Console.WriteLine("Array sebelum diurutkan:");
            PrintArray(arr);

            InputSort(arr);

            Console.WriteLine("\nArray setelah diurutkan:");
            PrintArray(arr);
            System.Threading.Thread.Sleep(5000);
        }

        static void InputSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                // Geser elemen yang lebih besar dari key ke posisi setelahnya
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }

        static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}

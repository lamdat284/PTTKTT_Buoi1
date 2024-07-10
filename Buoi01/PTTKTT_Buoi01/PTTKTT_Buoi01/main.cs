using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKTT_Buoi01
{
    class main
    {
        static void PrintArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        static int SumArray(int[] a)
        {
            int sum = 0;
            for(int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }

            return sum;
        }
        static void Main()
        {
            int[] arr = { 12, 11, 13, 5, 6, 7 };
            Console.Write("Mang a: ");
            PrintArray(arr);
            Console.Write("Tong mang a: " + SumArray(arr));
            
            Console.ReadKey();
        }
    }
}


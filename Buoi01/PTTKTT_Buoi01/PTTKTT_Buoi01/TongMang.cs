using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKTT_Buoi01
{
    class TongMang
    {
        static void Main(string[] args)
        {
            Console.Title = "Buoi1";
            var numbers = new[] {10, 3, 1, 7, 9, 2, 0};
            Console.Write("=> Mang A: ");

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                Console.Write(" " + numbers[i]);
            }

            int sum = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                sum+= numbers[i];
            }
            
            Console.Write("\n\t**Tong mang A la: " + sum);
            Console.ReadKey();
        }
        }
 }


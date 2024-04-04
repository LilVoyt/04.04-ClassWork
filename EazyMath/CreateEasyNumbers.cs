using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EazyMath
{
    public static class CreateEasyNumbers
    {
        public static void Even(int start,  int end)
        {
            Console.WriteLine("Even numbers: ");
            for (int i = start; i <= end; i++)
            {
                if(i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
        public static void Odd(int start, int end)
        {
            Console.WriteLine("Odd numbers: ");
            for (int i = start; i <= end; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}

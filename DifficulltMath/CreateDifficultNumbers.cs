using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifficulltMath
{
    public class CreateDifficultNumbers
    {
        public static void SimpleNumber(int start, int end)
        {
            Console.WriteLine("Simple numbers: ");
            for (int i = start; i < end; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= i / 2; j++) //Загуглив вирішення 
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForGeometry
{
    internal class Geometry
    {
        public static void Triangle(int side)
        {
            Console.WriteLine("Triangle: ");
            for (int i = 0; i < side; i++)
            {
                for (int j = 0; j <= i; j++) 
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        public static void Rectangle(int wide,  int height)
        {
            Console.WriteLine("Rectangle: ");
            for (int i = 0;i < wide; i++)
            {
                for(int j = 0; j < height; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public static void Square(int side)
        {
            Console.WriteLine("Square: ");
            for ( int i = 0; i < side; i++)
            {
                for (int j = 0; j < side; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}

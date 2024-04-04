using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DifficulltMath;
using EazyMath;
using ForGeometry;
using Sentences;

namespace Namespaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex 1 (file "EazyMath" and "Difficult math")
            CreateEasyNumbers.Even(2, 23);
            CreateEasyNumbers.Odd(2, 23);
            CreateDifficultNumbers.SimpleNumber(2, 23);

            //Ex 2
            Geometry.Triangle(5);
            Geometry.Rectangle(2, 4);
            Geometry.Square(6);

            //Ex 4
            string sentence = Words.Sentence(4, 6, 2, 3);
            Console.WriteLine(sentence);
        }
    }
}

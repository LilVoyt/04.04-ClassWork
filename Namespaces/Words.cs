using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentences
{
    internal class Words
    {
        private static char[] Vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };
        private static char[] Consonants = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l',
                                        'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'z' };
        public static string Sentence(int WordMin, int WordMax, int VowelsNum, int ConsonantsNum)
        {
            int VowelsCount;
            int ConsonantsCount;
            bool IsVowels;
            Random rand = new Random();
            int NumWords = rand.Next(3, 20); //кількість слів рандомна
            char[][] chars = new char[NumWords][]; //Вперше використав так звані "рвані" масиви, досить складно, але є аналогія з с++
            for (int i = 0; i < NumWords; i++)
            {
                VowelsCount = 0;
                ConsonantsCount = 0;
                IsVowels = rand.Next(0, 2) == 0; //нова логіка для мене
                chars[i] = new char[rand.Next(WordMin, WordMax)]; //Ініціалізація кожного рядка
                for (int j = 0; j < chars[i].Length; j++)
                {
                    if (IsVowels && VowelsCount < VowelsNum)
                    {
                        chars[i][j] = Vowels[rand.Next(0, Vowels.Length)];
                        VowelsCount++;
                    }
                    else if (!IsVowels && ConsonantsCount < ConsonantsNum)
                    {
                        chars[i][j] = Consonants[rand.Next(0, Consonants.Length)];
                        ConsonantsCount++;
                    }
                    else //якщо вже кількість голосних і приголосних букв закінчилось
                    {
                        IsVowels = rand.Next(0, 2) == 0;
                        if (IsVowels)
                        {
                            chars[i][j] = Vowels[rand.Next(0, Vowels.Length)];
                        }
                        else
                        {
                            chars[i][j] = Consonants[rand.Next(0, Consonants.Length)];
                        }
                    }
                }
            }
            string[] strings = new string[NumWords];
            for (int i = 0; i < NumWords; i++)
            {
                strings[i] = new string(chars[i]);
            }
            string sentence = string.Join(" ", strings);
            return sentence;
        }
    }
}

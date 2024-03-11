using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_3_dz_1_2
{
   class Program
   {
      static void Main(string[] args)
      {
         // 1 zadacha - Ввести с клавиатуры предложение.
         // Предложение представляет собой слова, разделенные пробелом.
         // Знаки препинания не используются.
         // Найти самое длинное слово в строке.
         Console.Write("Введите предложение:");
         string start = Console.ReadLine();
         string max = "";
         string[] mass;
         mass = start.Split();
         max = mass[0];
         foreach (string i in mass)
         {
            int t = i.Length;
            if (t >= max.Length)
            {
               max = i;
            }
         }
         Console.Write("Самое длинное слово в предложении: {0}", max);
         Console.ReadKey();
      }
   }
}

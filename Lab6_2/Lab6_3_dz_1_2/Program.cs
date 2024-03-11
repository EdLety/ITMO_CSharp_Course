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
         // 1 zadacha - максимальное слово в предложении
         /*string start = Console.ReadLine();
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
         Console.WriteLine(max);
         Console.ReadKey();*/

         // 2 zadacha - перевернутое сообщение
         /*string start = Console.ReadLine();
         string[] x1 = start.Split();
         string x2 = "";
         string end = "";
         foreach (string i in x1) x2 += i;
         for (int i = 0; i < x2.Length; i++)
         {
            end = x2[i] + end;
         }
         if (end.ToLower() == x2.ToLower()) Console.WriteLine("Является палиндром");
         else Console.WriteLine("Не является палиндром");
         Console.ReadKey();*/
         // 3 zadacha
         string s = Console.ReadLine();
         string[] s1 = s.Split();
         
         Console.WriteLine(s1);
         Console.ReadKey();
      }
   }
}

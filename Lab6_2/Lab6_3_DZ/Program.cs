using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_3_DZ
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
         string start = Console.ReadLine();
         string[] x1 = start.Split();
         string x2 = "";
         foreach (string i in x1) x2 += i;
         for (int i = 0; i < x2.Length; i++) 
         {
            if()
         }
         Console.WriteLine(x2);
         Console.ReadKey();
      }
   }
}

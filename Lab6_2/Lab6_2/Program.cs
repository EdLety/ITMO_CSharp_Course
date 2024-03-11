using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_2
{
   class Program
   {
      static void Main(string[] args)
      {
         // 1 zadacha - наименьшее слово в предложении
         /*string start = Console.ReadLine();
         string end = "";
         string[] mass;
         mass = start.Split();
         end = mass[0];
         foreach (string i in mass) 
         {
            int t = i.Length;
            if (t <= end.Length) 
            {
               end = i;
            }
         }
         Console.WriteLine(end);
         Console.ReadKey();*/
         // 2 zadacha - перевернутое сообщение
         string start = Console.ReadLine();
         int x = start.Length;
         string end = "";
         for (int i = 0; i < x; i++)
         {
            end = start[i] + end; 
         }

         Console.WriteLine(end);
         Console.ReadKey();
      }
   }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_2_1
{
   class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine("Введите координаты для 1 вершины");
         Console.Write("X = ");
         int x1 = Convert.ToInt32(Console.ReadLine());
         Console.Write("Y = ");
         int y1 = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Введите координаты для 2 вершины");
         Console.Write("X = ");
         int x2 = Convert.ToInt32(Console.ReadLine());
         Console.Write("Y = ");
         int y2 = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Введите координаты для 3 вершины");
         Console.Write("X = ");
         int x3 = Convert.ToInt32(Console.ReadLine());
         Console.Write("Y = ");
         int y3 = Convert.ToInt32(Console.ReadLine());

         if ((x1 - x2) * (x3 - x2) + (y1 - y2) * (y3 - y2) == 0)
         {
            int x = x2 + (x1 - x2) + (x3 - x2);
            int y = y2 + (y1 - y2) + (y3 - y2);
            Console.WriteLine("Координаты четвертой вершины x = {0} y = {1}", x, y);
         }
         else if ((x2 - x1) * (x3 - x1) + (y2 - y1) * (y3 - y1) == 0)
         {
            int x = x1 + (x2 - x1) + (x3 - x1);
            int y = y1 + (y2 - y1) + (y3 - y1);
            Console.WriteLine("Координаты четвертой вершины x = {0} y = {1}", x, y);
         }
         else if ((x1 - x3) * (x2 - x3) + (y1 - y3) * (y2 - y3) == 0)
         {
            int x = x3 + (x1 - x3) + (x2 - x3);
            int y = y3 + (y1 - y3) + (y2 - y3);
            Console.WriteLine("Координаты четвертой вершины x = {0} y = {1}", x, y);
         }
         Console.ReadKey();
      }
   }
}

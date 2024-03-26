using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_2
{
   internal class Program
   {
      static void Main(string[] args)
      {
         //1 Zadacha - Дана длина L окружности. Найти ее радиус R и площадь S круга, ограниченного этой окружностью.
         Console.Write("Введите длину окружности L: ");
         double l = Convert.ToDouble(Console.ReadLine());
         double r = (l / Math.PI) / 2;
         double s = Math.Pow(l, 2) / (4 * Math.PI);
         Console.WriteLine("Радиус круга: {0}", r);
         Console.WriteLine("Площадь круга: {0}", s);
         Console.ReadLine();
      }
   }
}

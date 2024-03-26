using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_2
{
   class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine("Введите 3 длины сторон 1 треугольника: ");
         double x1 = Convert.ToDouble(Console.ReadLine());
         double y1 = Convert.ToDouble(Console.ReadLine());
         double z1 = Convert.ToDouble(Console.ReadLine());
         Console.WriteLine("Введите 3 длины сторон 2 треугольника:");
         double x2 = Convert.ToDouble(Console.ReadLine()); 
         double y2 = Convert.ToDouble(Console.ReadLine()); 
         double z2 = Convert.ToDouble(Console.ReadLine());
         FindSMax(x1, y1, z1, out double s1);
         FindSMax(x2, y2, z2, out double s2);

         if (s1 > s2) Console.WriteLine("1 треугольник больше 2 треугольника");
         else if (s2 > s1) Console.WriteLine("2 треугольник больше 1 треугольника");
         else Console.WriteLine("Треугольники равны");
         Console.ReadKey();
      }
      // 1 zadacha
      static void FindSMax(double x1, double y1, double z1,out double s1)
      {
         double p1 = (x1 + y1 + z1) / 2.0;
         s1 = Math.Sqrt(p1 * (p1 - x1) * (p1 - y1) * (p1 - z1));
      }
   }
}

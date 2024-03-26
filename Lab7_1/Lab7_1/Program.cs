using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_1
{
   class Program
   {
      static void Main(string[] args)
      {
         int a1 = Convert.ToInt32(Console.ReadLine());
         int b1 = Convert.ToInt32(Console.ReadLine());

         int a2 = Convert.ToInt32(Console.ReadLine());
         int b2 = Convert.ToInt32(Console.ReadLine());
         if (FindGipoten(a1, b1) == FindGipoten(a2, b2)) Console.WriteLine("Гипотенузы равны");
         else Console.WriteLine("Гипотенузы не равны");
         double r = Convert.ToDouble(Console.ReadLine());
         double v, s;
         FindVandS(r, out v, out s);
         Console.WriteLine("{0} {1}", s, v);
         Console.ReadKey();
      }
      static double FindGipoten(double b, double a) 
      {
         double c = Math.Sqrt(Math.Pow(b, 2) + Math.Pow(a, 2));
         return c;
      }
      static void FindVandS(double r, out double v, out double s)
      {
         s = Math.PI * 4 * Math.Pow(r, 2); 
         v = (double)4 / 3 * Math.PI * Math.Pow(r, 3);
      }
   }
}

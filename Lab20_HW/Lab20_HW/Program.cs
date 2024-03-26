using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20_HW
{
   class Program
   {
      delegate double MyDelegate(double r);
      static void Main(string[] args)
      {
         MyDelegate myDelegate = LCircle;
         myDelegate += SCircle;
         myDelegate += VBall;
         myDelegate((double)2);

         Console.ReadKey();
      }
      static double VBall(double r)
      {
         double v = (4.0 / 3.0) * Math.PI * Math.Pow(r, 3);
         Console.WriteLine("Объем шара {0:f2}", v);
         return v;
      }
      static double SCircle(double r)
      {
         double s = Math.PI * Math.Pow(r, 2);
         Console.WriteLine("Площадь круга {0:f2}", s);
         return s;
      }
      static double LCircle(double r) 
      {
         double d = 2 * Math.PI * r;
         Console.WriteLine("Длина окружности {0:f2}", d);
         return d;
      }
   }
}

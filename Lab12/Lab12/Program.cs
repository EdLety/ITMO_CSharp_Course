using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
   class Program
   {
      static void Main(string[] args)
      {
         double r = Convert.ToDouble(Console.ReadLine());
         double x1 = Convert.ToDouble(Console.ReadLine());
         double y1 = Convert.ToDouble(Console.ReadLine());
         double x2 = Convert.ToDouble(Console.ReadLine());
         double y2 = Convert.ToDouble(Console.ReadLine());

         //Console.WriteLine(Circle.GetLenght(r));
         Console.WriteLine(Circle.GetPointAffiliation(r, x1, y1, x2, y2));
         //Console.WriteLine(Circle.GetSquare(r));
         Console.ReadKey();
      }
   }
}

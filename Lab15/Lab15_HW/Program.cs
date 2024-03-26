using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15_HW
{
   class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine("ARITHMETIC");
         ArithProgression arith = new ArithProgression();
         arith.SetStart(10);
         arith.setStep(2);
         Console.WriteLine(arith.GetNext());
         Console.WriteLine(arith.GetNext());
         Console.WriteLine(arith.GetNext());
         Console.WriteLine(arith.GetNext());
         arith.Reset();
         Console.WriteLine(arith.GetNext());
         Console.WriteLine(arith.GetNext());

         Console.WriteLine("GEOMETRY");
         GeomProgression geom = new GeomProgression();
         geom.SetStart(10);
         geom.setStep(2);
         Console.WriteLine(geom.GetNext());
         Console.WriteLine(geom.GetNext());
         Console.WriteLine(geom.GetNext());
         Console.WriteLine(geom.GetNext());
         geom.Reset();
         Console.WriteLine(geom.GetNext());
         Console.WriteLine(geom.GetNext());
         Console.ReadKey();
      }
   }
}

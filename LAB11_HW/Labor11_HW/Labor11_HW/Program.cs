using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Labor11_HW
{
   class Program
   {
      static void Main(string[] args)
      {
         double k = Convert.ToDouble(Console.ReadLine());
         double b = Convert.ToDouble(Console.ReadLine());
         LineEq lineEq = new LineEq(k, b);
         Console.WriteLine(lineEq.Root());
         Console.ReadKey();
      }
   }
}

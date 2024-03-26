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
         Console.WriteLine("Решение линейного уравнения 0=kx+b");
         Console.Write("Введите число k: ");
         double k = Convert.ToDouble(Console.ReadLine());
         Console.Write("Введите число b: ");
         double b = Convert.ToDouble(Console.ReadLine());
         LineEq lineEq = new LineEq(k, b);
         Console.WriteLine(lineEq.Root());
         Console.ReadKey();
      }
   }
}

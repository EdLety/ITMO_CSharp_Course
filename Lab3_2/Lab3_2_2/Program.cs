using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_2_2
{
   internal class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine("Введите значение для точки А");
         int A = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Введите значение для точки В");
         int B = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Введите значение для точки С");
         int C = Convert.ToInt32(Console.ReadLine());
         int D = Math.Abs(B - A);
         int E = Math.Abs(C - A);
         if (D > E) { Console.WriteLine("Точка С будет ближе к точка А, расстояние между ними равно: {0}", E); }
         else if (D < E) { Console.WriteLine("Точка B будет ближе к точка А, расстояние между ними равно: {0}", D); }
         else
         {
            Console.WriteLine("Точки B и C сейчас являются равностоящими от точки А, или совпадают с точкой А, или между собой.");
         }
         Console.ReadKey();
      }
   }
}

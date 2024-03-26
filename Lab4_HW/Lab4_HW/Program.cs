using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_HW
{
   class Program
   {
      static void Main()
      {
         Console.WriteLine("Введите целое число N (больше нуля):");
         int N = int.Parse(Console.ReadLine());

         int sum = 0;

         for (int i = 1; i <= N; i++)
         {
            sum += (2 * i - 1);
            Console.WriteLine($"\tКвадрат числа {i} равен {sum}");
         }
         Console.WriteLine($"Квадрат {N} равен {sum}");
         Console.ReadKey();
      }
   }
}

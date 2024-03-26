using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lab23_HW
{
   class Program
   {
      static void Main(string[] args)
      {
         Console.Write("Введите число: ");
         int n = Convert.ToInt32(Console.ReadLine());
         FactoryAsync(n);
         Console.ReadKey();
      }
      static void Factory(int n) 
      {
         int s = 1;
         for (int i = 1; i < n + 1; i++)
         {
            s *= i;
            Thread.Sleep(10);

         }
         Console.WriteLine(s);
      }
      static async void FactoryAsync(int n) 
      {
         await Task.Run(() => Factory(n));
      }
   }
}

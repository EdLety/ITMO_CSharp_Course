using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lab21_HW
{
   class Program
   {
      private static int[,] garden;
      private static int m;
      private static int n;

      static void Main()
      {
         n = Convert.ToInt32(Console.ReadLine());
         m = Convert.ToInt32(Console.ReadLine());

         garden = new int[n, m];

         Thread thread1 = new Thread(Gardner1);
         Thread thread2 = new Thread(Gardner2);

         thread1.Start();
         thread2.Start();

         thread1.Join();
         thread2.Join();

         for (int i = 0; i < n; i++)
         {
            for (int j = 0; j < m; j++)
            {
               Console.Write(garden[i, j] + " ");
            }
            Console.WriteLine();
         }
         Console.ReadLine();
      }

      private static void Gardner1()
      {
         for (int i = 0; i < n; i++)
         {
            for (int j = 0; j < m; j++)
            {
               if (garden[i, j] == 0)
                  garden[i, j] = 1;
               Thread.Sleep(1);
            }
         }
      }

      private static void Gardner2()
      {
         for (int i = m - 1; i > 0; i--)
         {
            for (int j = n - 1; j > 0; j--)
            {
               if (garden[j, i] == 0)
                  garden[j, i] = 2;
               Thread.Sleep(1);
            }
         }
      }
   }
}

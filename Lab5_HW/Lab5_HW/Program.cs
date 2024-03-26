using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_HW
{
   class Program
   {
      static void Main(string[] args)
      {
         // 1. Обязательная задача*. Сформировать одномерный массив из 7 элементов. Заполнить массив числами, вводимыми с клавиатуры, определить среднее арифметическое элементов.
         /*int[] array = new int[7];
         double sum = 0;

         for (int i = 0; i < array.Length; i++)
         {
            Console.WriteLine($"Введите число для элемента {i + 1}:");
            array[i] = Convert.ToInt32(Console.ReadLine());
            sum += array[i];
         }

         double average = sum / array.Length;
         Console.WriteLine($"Среднее арифметическое элементов массива: {average}");
         Console.ReadKey();*/
         // 5. Обязательная задача*. Запросить у пользователя целочисленное значение N. Сформировать двумерный массив размера NxN
         /*Console.WriteLine("Введите целое число N:");
         int n = int.Parse(Console.ReadLine());

         int[,] array = new int[n, n];

         for (int i = 0; i < n; i++)
         {
            for (int j = 0; j < n; j++)
            {
               if ((i + j) % 2 == 0)
               {
                  array[i, j] = 1;
               }
               else
               {
                  array[i, j] = 0;
               }
            }
         }
         for (int i = 0; i < n; i++)
         {
            for (int j = 0; j < n; j++)
            {
               Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
         }
         Console.ReadKey();*/
      }
   }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_3_2
{
   class Program
   {
      static void Main(string[] args)
      {
         // 2 zadacha - Ввести с клавиатуры предложение.
         // Предложение представляет собой слова, разделенные пробелом.
         // Знаки препинания не используются.
         // Составить программу, определяющую является ли строка палиндромом без учёта пробелов и регистра (пример палиндрома – «А роза упала на лапу Азора»).
         Console.Write("Введите предложение:");
         string start = Console.ReadLine();
         string[] x1 = start.Split();
         string x2 = "";
         string end = "";
         foreach (string i in x1) x2 += i;
         for (int i = 0; i < x2.Length; i++)
         {
            end = x2[i] + end;
         }
         if (end.ToLower() == x2.ToLower()) Console.WriteLine("Является палиндром");
         else Console.WriteLine("Не является палиндром");
         Console.ReadKey();
      }
   }
}

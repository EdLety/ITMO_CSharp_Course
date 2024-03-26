using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_HW
{
   class Program
   {
      static void Main(string[] args)
      {
         // 1 zadacha - Выберите любую папку на своем компьютере, имеющую вложенные директории. Выведите на консоль ее содержимое и содержимое всех подкаталогов.
         string folderPath = @"C:\Users\nuss.ea\Documents\Visual Studio 2022";
         if (Directory.Exists(folderPath))
         {
            DisplayFolderContents(folderPath);
         }
         else
         {
            Console.WriteLine("Папка не найдена.");
         }
         Console.ReadLine();
         /*string path1 = @"C:\Users\nuss.ea\Documents\Papka1";
         string[] catalogs = Directory.GetDirectories(path1);
         foreach (string items in catalogs) { 
            Console.WriteLine(items);

            *//*Directory.GetCurrentDirectory(items);*//*

         }
         Console.ReadKey();*/
         // 2 zadacha - Программно создайте текстовый файл и запишите в него 10 случайных чисел. Затем программно откройте созданный файл, рассчитайте сумму чисел в нем, ответ выведите на консоль.
         /*Random sw = new Random();
         int count = 0;
         string path = @"C:\Users\nuss.ea\Documents\Papka1\log.txt";
         *//*using (StreamWriter se = new StreamWriter(path, true))
         {
            for (int i = 0; i < 10; i++) se.WriteLine(sw.Next(-10, 10));
         }*//*
         Console.WriteLine("Sum of ints:");
         using (StreamReader sw1 = new StreamReader(path))
         {
            for (int i = 0; i < 10; i++)
            {
               int j = Convert.ToInt32(sw1.ReadLine());
               count+=j;
            }
         }
         Console.WriteLine(count);
         Console.ReadKey();*/
      }
      static void DisplayFolderContents(string folderPath)
      {
         Console.WriteLine($"Содержимое папки {folderPath}:");

         string[] files = Directory.GetFiles(folderPath);
         foreach (string file in files)
         {
            Console.WriteLine($"Файл: {file}");
         }

         string[] directories = Directory.GetDirectories(folderPath);
         foreach (string directory in directories)
         {
            Console.WriteLine($"Подкаталог: {directory}");
            DisplayFolderContents(directory);
         }
      }
   }
}

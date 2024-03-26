using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_HW
{
   class Program
   {
      static void Main(string[] args)
      {
         int x, y, c;
         Console.WriteLine("Вас приветствует калькулятор!");
         try
         {
            Console.Write("Введите целое число: Х = ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите целое число: Y = ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите код операции: \n      1 - сложение\n      2 – вычитание\n      3 – произведение\n      4 – частное");
            Console.Write("Код выбора: ");
            c = Convert.ToInt32(Console.ReadLine());
         }
         catch (ArgumentOutOfRangeException) when (c1 != 0) 
         {
            Console.WriteLine("Нет операций с указанным номером");
         }
         catch (Exception ex)
         {
            Console.WriteLine(ex.Message);
         }
         Console.ReadKey();
         
      }
   }
}

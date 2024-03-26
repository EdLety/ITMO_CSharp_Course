using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Calculator
{
   static void Main()
   {
      try
      {
         Console.WriteLine("Вас приветствует калькулятор!");
         Console.Write("Введите целое число. X = ");
         double num1 = double.Parse(Console.ReadLine());

         Console.Write("Введите целое число. Y = ");
         double num2 = double.Parse(Console.ReadLine());
         Console.WriteLine("Введите код операции:");
         Console.WriteLine("\t1 - сложение");
         Console.WriteLine("\t2 - вычитание");
         Console.WriteLine("\t3 - произведение");
         Console.WriteLine("\t4 - частное");
         Console.Write($"Ваш выбор: ");
         int operation = Convert.ToInt32(Console.ReadLine());
         double result = 0;
         switch (operation)
         {
            case 1:
               result = num1 + num2;
               break;
            case 2:
               result = num1 - num2;
               break;
            case 3:
               result = num1 * num2;
               break;
            case 4:
               if (num2 == 0)
               {
                  throw new DivideByZeroException("Деление на ноль недопустимо.");
               }
               result = num1 / num2;
               break;
            default:
               throw new ArgumentException("Нет операции с указанным номером.");
         }

         Console.WriteLine("Результат: " + result);
      }
      catch (FormatException)
      {
         Console.WriteLine("Ошибка: Входная строка имела неверный формат.");
      }
      catch (DivideByZeroException ex)
      {
         Console.WriteLine("Ошибка: " + ex.Message);
      }
      catch (ArgumentException ex)
      {
         Console.WriteLine("Ошибка: " + ex.Message);
      }
      Console.ReadKey();
   }
}

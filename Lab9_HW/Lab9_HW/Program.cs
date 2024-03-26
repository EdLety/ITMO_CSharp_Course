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
         Console.WriteLine("Введите первое число:");
         double num1 = double.Parse(Console.ReadLine());

         Console.WriteLine("Введите второе число:");
         double num2 = double.Parse(Console.ReadLine());
         Console.WriteLine("Выберите операцию:");
         Console.WriteLine("\t1 - сложение");
         Console.WriteLine("\t2 - вычитание");
         Console.WriteLine("\t3 - произведение");
         Console.WriteLine("\t4 - частное");
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
               throw new ArgumentException("Некорректный код операции.");
         }

         Console.WriteLine("Результат: " + result);
      }
      catch (FormatException)
      {
         Console.WriteLine("Ошибка: Введите корректное число.");
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

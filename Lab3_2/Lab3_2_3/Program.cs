using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab3_2_3
{
   internal class Program
   {
      static void Main(string[] args)
      {
         Console.Write("Введите ваш возраст от 20 до 69 лет: ");
         int num = Convert.ToInt32(Console.ReadLine());
         if (num >= 20 && num <= 69)
         {
            int sto_1 = num / 10;
            int sto_2 = num % 10;
            string name = "";
            switch (sto_1)
            {
               case 1:
                  name += "Сто ";
                  break;
               case 2:
                  name += "Двадцать ";
                  break;
               case 3:
                  name += "Тридцать ";
                  break;
               case 4:
                  name += "Сорок ";
                  break;
               case 5:
                  name += "Пятьдесят ";
                  break;
               case 6:
                  name += "Шестьдесят ";
                  break;
               case 7:
                  name += "Семьдесят ";
                  break;
               case 8:
                  name += "Восемьдесят ";
                  break;
               case 9:
                  name += "Девяносто ";
                  break;
               default:
                  break;
            }
            switch (sto_2)
            {
               case 1:
                  name += "один год";
                  break;
               case 2:
                  name += "два года";
                  break;
               case 3:
                  name += "три года";
                  break;
               case 4:
                  name += "четыре года";
                  break;
               case 5:
                  name += "пять лет";
                  break;
               case 6:
                  name += "шесть лет";
                  break;
               case 7:
                  name += "семь лет";
                  break;
               case 8:
                  name += "восемь лет";
                  break;
               case 9:
                  name += "девять лет";
                  break;
               default:
                  name += "лет";
                  break;
            }
            Console.WriteLine(name);
            Console.Write("Нажмите любую клавишу для завершения программы -> ");
         }
         else { Console.WriteLine("!error: check your age!"); }
         Console.ReadKey();
      }
   }
}

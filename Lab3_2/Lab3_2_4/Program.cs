using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_2_4
{
   internal class Program
   {
      static void Main(string[] args)
      {
         int num = Convert.ToInt32(Console.ReadLine());
         int sto = num / 100;
         string name = "";
         switch (sto)
         {
            case 1:
               name += "Сто ";
               break;
            case 2:
               name += "Двести ";
               break;
            case 3:
               name += "Триста ";
               break;
            case 4:
               name += "Четыреста ";
               break;
            case 5:
               name += "Пятьсот ";
               break;
            case 6:
               name += "Шестьсот ";
               break;
            case 7:
               name += "Семьсот ";
               break;
            case 8:
               name += "Восемьсот ";
               break;
            case 9:
               name += "Девятьсот ";
               break;
            default:
               break;
         }
         if ((num / 10) - Math.Abs(sto * 10) == 1) 
         {
            switch ((num / 10) - Math.Abs(sto * 10))
            {
               case 1:
                  name += "десять";
                  break;
               case 2:
                  name += "Двести";
                  break;
               case 3:
                  name += "Триста";
                  break;
               case 4:
                  name += "Четыреста";
                  break;
               case 5:
                  name += "пятьдесят";
                  break;
               case 6:
                  name += "Шестьсот";
                  break;
               case 7:
                  name += "Семьсот";
                  break;
               case 8:
                  name += "Восемьсот";
                  break;
               case 9:
                  name += "Девятьсот";
                  break;
               default:
                  break;
            }
         }
         int des = (num / 10) - Math.Abs(sto * 10);
         switch (des)
         {
            case 1:
               name += "Сто";
               break;
            case 2:
               name += "Двести";
               break;
            case 3:
               name += "Триста";
               break;
            case 4:
               name += "Четыреста";
               break;
            case 5:
               name += "пятьдесят";
               break;
            case 6:
               name += "Шестьсот";
               break;
            case 7:
               name += "Семьсот";
               break;
            case 8:
               name += "Восемьсот";
               break;
            case 9:
               name += "Девятьсот";
               break;
            default:
               break;
         }
         int edi = num % 10;
         switch (edi)
         {
            case 1:
               name += "один";
               break;
            case 2:
               name += "два";
               break;
            case 3:
               name += "три";
               break;
            case 4:
               name += "четыре";
               break;
            case 5:
               name += "пять";
               break;
            case 6:
               name += "шесть";
               break;
            case 7:
               name += "семь";
               break;
            case 8:
               name += "восемь";
               break;
            case 9:
               name += "девять";
               break;
            default:
               break;
         }
         Console.WriteLine(name);
         Console.WriteLine(des);
         Console.WriteLine(edi);
         Console.ReadKey();
      }
   }
}

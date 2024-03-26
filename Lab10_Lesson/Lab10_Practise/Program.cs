using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_Practise
{
   class Program
   {
      static void Main(string[] args)
      {
         Clock clock = new Clock(1, 61, 30);
         Console.WriteLine(clock.ToSecond());
         Console.ReadKey();
      }
   }
   class Clock 
   {
      private int hour, min, sec;
      public Clock(int hour, int min, int sec) 
      {
         Hour = hour;
         Min = min;
         Sec = sec;
      }
      public int Hour 
      { 
         get => hour;
         set {
            if (0 <= value && value < 60) hour = value;
            else throw new ArgumentException($"{value} hour - неправильное значение");
         }
      }
      public int Min
      {
         get => min;
         set
         {
            if (0 <= value && value < 60) min = value;
            else throw new ArgumentException($"{value} min - неправильное значение");
         }
      }
      public int Sec
      {
         get => sec;
         set
         {
            if (0 <= value && value < 60) sec = value;
            else throw new ArgumentException($"{value} sec - неправильное значение");
         }
      }
      public int ToSecond() 
      {
         int fullseconds = hour * 3600 + min * 60 + sec;
         return fullseconds;
      }
   }
}

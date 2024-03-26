using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_HW
{
   class Program
   {
      static void Main()
      {
         Radians radians = new Radians(42, 32 , 15);
         Console.WriteLine("{0}, {1}, {2}", radians.Gradus, radians.Min, radians.Sec);
         Console.WriteLine(radians.ToRadians());
         Console.ReadKey();
      }
   }
   class Radians
   {
      private int gradus, min, sec;
      public Radians (int gradus, int min, int sec)
      {
         Gradus = gradus;
         Min = min;
         Sec = sec;
      }
      public double ToRadians()
      {
         double totalDegrees = gradus + (min / 60.0) + (sec / 3600.0);
         return totalDegrees * Math.PI / 180.0;
      }

      public int Gradus 
      { 
         get => gradus;
         set 
         {
            if (value >= 0 && value < 360) gradus = value;
            else throw new ArgumentException("Не в диапазоне: от 0 до 359 (включительно) градусов");
         }
      }
      public int Min 
      {
         get => min;
         set 
         {
            if (value >= 0 && min < 60) min = value;
            else throw new ArgumentException("Не в диапазоне: от 1 до 60 (включительно) минут");
         }
      }
      public int Sec 
      {
         get => sec;
         set 
         {
            if (value >= 0 && value < 60) sec = value;
            else throw new ArgumentException("Не в диапазоне: от 1 до 60 (включительно) секунд");
         }
      }
   }
}

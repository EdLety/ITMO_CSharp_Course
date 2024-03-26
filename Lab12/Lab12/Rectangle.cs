using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
   static class Circle
   {
      /// <summary>
      /// метод, определяющий длину окружности по заданному радиусу
      /// </summary>
      static public double GetLenght(double r) { return 2 * Math.PI * r; }
      /// <summary>
      /// метод, определяющий площадь круга по заданному радиусу
      /// </summary>
      static public double GetSquare(double r) { return Math.PI * Math.Pow(r, 2); }
      /// <summary>
      /// метод, проверяющий принадлежность точки с координатами (x,y) кругу с радиусом r и координатами центра x0, y0
      /// </summary>
      static public string GetPointAffiliation(double r, double x1, double y1, double x2, double y2) 
      {
         double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

         if (distance <= r)
         {
            return $"Точка с координатами ({x2};{y2}) принадлежит кругу";
         }
         else
         {
            return $"Точка с координатами ({x2};{y2}) не принадлежит кругу";
         }
      }
   }
}

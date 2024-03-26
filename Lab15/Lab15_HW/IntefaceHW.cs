using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15_HW
{
   interface ISeries 
   {
      /// <summary>
      /// устанавливает начальное значение
      /// </summary>
      /// <param name="x"></param>
      void SetStart(int x);
      /// <summary>
      /// возвращает следующее число ряда
      /// </summary>
      /// <returns></returns>
      int GetNext();
      /// <summary>
      /// выполняет сброс к начальному значению
      /// </summary>
      void Reset();
   }
   /// <summary>
   /// Арифметическая прогрессия
   /// </summary>
   class ArithProgression : ISeries
   {
      int startValue;
      int currentValue;
      int step;
      public int GetNext() { return currentValue += step; } 

      public void Reset()
      {
         currentValue = startValue;
      }

      public void SetStart(int x)
      {
         startValue = x;
         currentValue = startValue;
      }
      public void setStep(int s)
      {
         step = s;
      }
   }
   /// <summary>
   /// Геометрическая прогрессия
   /// </summary>
   class GeomProgression
   {
      int startValue;
      int currentValue;
      int step;
      public int GetNext() { return currentValue *= step; }

      public void Reset()
      {
         currentValue = startValue;
      }

      public void SetStart(int x)
      {
         startValue = x;
         currentValue = startValue;
      }
      public void setStep(int s)
      {
         step = s;
      }
   }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public struct LineEq
    {
      public double k, b;
      public LineEq(double k, double b) 
      {
         this.k = k;
         this.b = b;
      }
      public string Root() 
      {
         double x = -b / k;
         return $"Корень х равен: {x}";
      }
    }
}

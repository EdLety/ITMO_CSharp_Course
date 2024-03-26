using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_Lesson
{
   class Program
   {
      static void Main(string[] args)
      {
         Cat cat1 = new Cat("Murka", "White", 15);
         cat1.Weow();
         Console.WriteLine(cat1.name + cat1.color);
         Console.ReadKey();
      }
   }
   class Cat
   {
      public string name;
      public string color;
      public int age;
      public Cat (string n, string c, int a) 
      {
         name = n;
         color = c;
         age = a;
      }
      public void Weow() 
      {
         Console.WriteLine("wew говорит {0}", name);
      }

   }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18_HW
{
   class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine("Введите строку");
         string str = Console.ReadLine();
         Console.WriteLine(Check(str));
         Console.ReadKey();
      }
      static bool Check(string str) 
      {
         Stack<char> stack = new Stack<char>();
         Dictionary<char, char> skobki = new Dictionary<char, char>();
         skobki.Add('(', ')');
         skobki.Add('[', ']');
         skobki.Add('{', '}');
         foreach (char c in str)
         {
            if (c == '(' || c == '[' || c == '{')
               stack.Push(skobki[c]);
            if (c == ')' || c == ']' || c == '}')
            {
               if (stack.Count == 0 || stack.Pop() != c) return false;
            }

         }
         if (stack.Count == 0) return true;
         else return false;
      }
   }
}

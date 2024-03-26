using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14_Practice
{
   class Program
   {
      static void Main(string[] args)
      {
         Cat cat = new Cat("Барсек");
         cat.ShowInfo();
         Dog dog = new Dog("Шарек");
         dog.ShowInfo();
         Console.ReadKey();
      }
   }
   abstract class Animal 
   {
      public abstract string NameAnimal { get; set; }
      public Animal(string name) 
      {
         NameAnimal = name;
      }
      public abstract void Say();
      public void ShowInfo() 
      {
         Console.WriteLine(NameAnimal);
         Say();
      }
   }
   class Cat : Animal 
   {
      private string name;

      public override string NameAnimal
      { 
         get => name; 
         set => name = value; 
      }
      public Cat(string name) : base(name)
      {
      }
      public override void Say()
      {
         Console.WriteLine("Мяу");
      }
   }
   class Dog : Animal
   {
      private string name;

      public override string NameAnimal
      {
         get => name;
         set => name = value;
      }
      public Dog(string name) : base(name)
      {
      }
      public override void Say()
      {
         Console.WriteLine("Гав");
      }
   }
}

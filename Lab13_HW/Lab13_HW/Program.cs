using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_HW
{
   class Program
   {
      static void Main(string[] args)
      {
         Building building = new Building("Героев Хасана",  10,  3, 20);
         Console.WriteLine(building.Print());
         MultiBuilding multiBuilding = new MultiBuilding("Героев Хасана", 10, 3, 20, 19);
         Console.WriteLine(multiBuilding.Print());
         Console.ReadKey();
      }
   }
   public class Building
   {
      public string address;
      public double lenght;
      public double width;
      public double height;
      public Building(string address, double lenght, double width, double height) 
      {
         this.Address = address;
         this.Lenght = lenght;
         this.Width = width;
         this.Height = height;
      }
      public string Address 
      { get { return address; }
        set { address = value; }
      }
      public double Lenght
      {
         get { return lenght; }
         set { lenght = value; }
      }
      public double Width
      {
         get { return width; }
         set { width = value; }
      }
      public double Height
      {
         get { return height; }
         set { height = value; }
      }
      public string Print() 
      { 
         return $"Информация о здании:\n\tадрес здания: {address}\n\tдлина здания: {lenght}\n\tширина здания: {width}\n\tвысота здания: {height}"; 
      }
   }
   sealed public class MultiBuilding : Building 
   {
      public int floors;
      public MultiBuilding(string address, double length, double width, double height, int floors) : base(address, length, width, height)
      {
         this.floors = floors;
      }

      public int Floors
      {
         get { return floors; }
         set { floors = value; }
      }

      public string Print()
      {
         base.Print();
         return $"Этажи: {floors}";
      }
   }
}

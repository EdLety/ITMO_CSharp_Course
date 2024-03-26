using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19HW
{
   class Program
   {
      static void Main(string[] args)
      {
         List<Computer> computer = new List<Computer>()
         {
            new Computer(){ ID = 1, Mark = "DELL", ProcesType = "Intel", Frequency = 3.2 , RAM = 16, AmountHD = 64 , AmountGPU = 12, Cost = 35000 , Count = 12},
            new Computer(){ ID = 2, Mark = "Apple", ProcesType = "M1", Frequency = 3.7 , RAM = 8, AmountHD = 64 , AmountGPU = 12, Cost = 125000 , Count = 3},
            new Computer(){ ID = 3, Mark = "Apple", ProcesType = "M1", Frequency = 3.7 , RAM = 12, AmountHD = 64 , AmountGPU = 12, Cost = 210000 , Count = 5},
            new Computer(){ ID = 4, Mark = "MSI", ProcesType = "AMD", Frequency = 3.2 , RAM = 12, AmountHD = 64 , AmountGPU = 8, Cost = 56000 , Count = 32},
            new Computer(){ ID = 5, Mark = "MSI", ProcesType = "Intel", Frequency = 3.2 , RAM = 16, AmountHD = 64 , AmountGPU = 12, Cost = 62000 , Count = 22},
            new Computer(){ ID = 6, Mark = "Asus", ProcesType = "AMD", Frequency = 2.7 , RAM = 12, AmountHD = 64 , AmountGPU = 8, Cost = 41000 , Count = 4},
            new Computer(){ ID = 7, Mark = "Asus", ProcesType = "Intel", Frequency = 3.2 , RAM = 8, AmountHD = 64 , AmountGPU = 8, Cost = 35000 , Count = 1},
            new Computer(){ ID = 8, Mark = "HP", ProcesType = "Intel", Frequency = 2.7 , RAM = 12, AmountHD = 64 , AmountGPU = 8, Cost = 65310 , Count = 10},
            new Computer(){ ID = 9, Mark = "DELL", ProcesType = "Intel", Frequency = 2.7 , RAM = 14, AmountHD = 64 , AmountGPU = 12, Cost = 76000 , Count = 7},
            new Computer(){ ID = 10, Mark = "DELL", ProcesType = "AMD", Frequency = 3.2 , RAM = 8, AmountHD = 64 , AmountGPU = 8, Cost = 56500 , Count = 8},
         };
         // все компьютеры с указанным процессором. Название процессора запросить у пользователя
         Console.WriteLine("Введите название процессора: ");
         string mark = Console.ReadLine();
         List<Computer> computers1 = computer.Where(x => x.ProcesType == mark).ToList();
         Print(computers1);
         // все компьютеры с объемом ОЗУ не ниже, чем указано. Объем ОЗУ запросить у пользователя
         Console.WriteLine("Введите объем ОЗУ: ");
         int vram = Convert.ToInt32(Console.ReadLine());
         List<Computer> computers2 = computer.Where(x => x.RAM >= vram).ToList();
         Print(computers2);
         // вывести весь список, отсортированный по увеличению стоимости
         List<Computer> computers3 = computer.OrderBy(x => x.Cost).ToList();
         Console.WriteLine("Список по увеличению стоимости: ");
         Print(computers3);
         // вывести весь список, сгруппированный по типу процессора;
         IEnumerable<IGrouping<string, Computer>> computers4 = computer.GroupBy(x => x.ProcesType);
         foreach (IGrouping<string, Computer> gr in computers4)
         {
            Console.WriteLine(gr.Key);
            foreach (Computer c in gr)
            {
               Console.WriteLine($"{c.ID}\n\t{c.Mark}\n\t{c.ProcesType}\n\t{c.RAM}\n\t{c.AmountGPU}\n\t{c.AmountHD}\n\t{c.Cost}\n\t{c.Count}");
            }
         }
         // найти самый дорогой и самый бюджетный компьютер
         var computers5 = computer.OrderBy(x => x.Cost).First();
         var computers6 = computer.OrderBy(x => x.Cost).Last();
         Console.WriteLine($"самый дорогой компьютер: {computers5.ID} {computers5.Mark} {computers5.ProcesType} {computers5.RAM} {computers5.AmountGPU} {computers5.AmountHD} {computers5.Cost} {computers5.Count}");
         Console.WriteLine($"самый бюджетный компьютер: {computers6.ID} {computers6.Mark} {computers6.ProcesType} {computers6.RAM} {computers6.AmountGPU} {computers6.AmountHD} {computers6.Cost} {computers6.Count}");
         // есть ли хотя бы один компьютер в количестве не менее 30 штук
         Console.WriteLine(computer.Any(x => x.Count >= 30));
         Console.ReadKey();
      }
      static void Print(List<Computer> computer)
      {
         foreach (Computer c in computer)
         {
            Console.WriteLine($"\tКод компьютера: {c.ID}\n\tМарка компьютера: {c.Mark}\n\tТип процессора: {c.ProcesType}\n\tКоличество ОЗУ: {c.RAM}\n\tОбъем графической памяти: {c.AmountGPU}\n\tОбъем жесткого диска: {c.AmountHD}\n\tСтоимость: {c.Cost}\n\tКоличество экземляров в наличии {c.Count}");

            Console.WriteLine();
         }
         Console.WriteLine();
      }
   }
}

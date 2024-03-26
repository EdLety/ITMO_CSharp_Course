using System;
using System.Threading.Tasks;

class Program
{
   static void Main()
   {
      Console.WriteLine("Введите размер массива:");
      int size = int.Parse(Console.ReadLine());

      int[] array = GenerateRandomArray(size);

      Task<int> sumTask = Task.Run(() => CalculateSum(array));
      Task<int> maxTask = Task.Run(() => CalculateMax(array));

      Task continuationTask = Task.WhenAll(sumTask, maxTask).ContinueWith((task) =>
      {
         Console.WriteLine($"Сумма чисел в массиве: {sumTask.Result}");
         Console.WriteLine($"Максимальное число в массиве: {maxTask.Result}");
      });

      continuationTask.Wait();
      Console.ReadKey();
   }

   static int[] GenerateRandomArray(int size)
   {
      Random random = new Random();
      int[] array = new int[size];
      for (int i = 0; i < size; i++)
      {
         array[i] = random.Next(1, 100);
      }
      return array;
   }

   static int CalculateSum(int[] array)
   {
      int sum = 0;
      foreach (int num in array)
      {
         sum += num;
      }
      return sum;
   }

   static int CalculateMax(int[] array)
   {
      int max = int.MinValue;
      foreach (int num in array)
      {
         if (num > max)
         {
            max = num;
         }
      }
      return max;
   }
}


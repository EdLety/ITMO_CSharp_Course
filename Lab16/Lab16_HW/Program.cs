using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.IO;

namespace Lab16_HW
{
   class Program
   {
      static void Main(string[] args)
      {
         /*const int count = 2;
         const string pathName = "Products.json";
         Product[] product = new Product[count];
         for (int i = 0; i < count; i++) 
         {
            Console.WriteLine("Введите номер: ");
            int code = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите имя: ");
            string name = Console.ReadLine();
            Console.WriteLine("Введите зарплату: ");
            double price = Convert.ToDouble(Console.ReadLine());

            product[i] = new Product() { ProductPrice = price, ProductName = name, ProductCode = code };
         }
         JsonSerializerOptions options = new JsonSerializerOptions()
         {
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
            WriteIndented = true
         };
         string jsonString = JsonSerializer.Serialize(product, options);

         using (StreamWriter sw = new StreamWriter(pathName)) { sw.WriteLine(jsonString); }
*/
         //string path = Directory.GetCurrentDirectory();
         //Console.WriteLine(path);
         string jsonString1 = String.Empty;
         using (StreamReader sr = new StreamReader("../../../Products.json")) 
         {
            jsonString1 = sr.ReadToEnd();
         }
         Product[] products = JsonSerializer.Deserialize<Product[]>(jsonString1);
         Product maxproduct1 = products[0];
         foreach (Product p in products) 
         {
            if (p.ProductPrice > maxproduct1.ProductPrice) { maxproduct1 = p; }
         }
         Console.WriteLine($"Название самого дорогого товара: {maxproduct1.ProductName}");
         
         Console.ReadKey();
      }
   }
   class Product 
   {
      public int ProductCode { get; set; }
      public string ProductName { get; set; }
      public double ProductPrice { get; set; }
   }
}

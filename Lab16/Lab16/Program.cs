using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.Text.Json.Serialization;

namespace Lab16
{
   class Program
   {
      static void Main(string[] args)
      {
         string jsonString = "{\"firstName\":\"Tom\",\"lastName\":\"Jackson\",\"gender\":\"male\",\"age\":29,\"online\":true,\"hobby\":[\"football\",\"reading\",\"swimming\"]}";
         Person person = JsonSerializer.Deserialize<Person>(jsonString);
         Person person1 = new Person()
         {
            FirstName = "Tom",
            LastName = "Jackson",
            Gender = "пидр",
            Age = 29,
            Online = false,
            Hobby = new string[] { "suck cocks", "glad to see u" }
         };
         JsonSerializerOptions options = new JsonSerializerOptions()
         {
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
            WriteIndented = true
         };
         string jsonString1 = JsonSerializer.Serialize(person1, options);
         Console.WriteLine(jsonString1);
         Console.ReadKey();
      }
   }
   class Person
   {
      //Атрибуты
      [JsonPropertyName("firstName")]
      public string FirstName { get; set; }
      [JsonPropertyName("lastName")]
      public string LastName { get; set; }
      [JsonPropertyName("gender")]
      public string Gender { get; set; }
      [JsonPropertyName("age")]
      public int Age { get; set; }
      [JsonPropertyName("online")]
      [JsonIgnore]
      public bool Online { get; set; }
      [JsonPropertyName("hobby")]
      [JsonIgnore]
      public string[] Hobby { get; set; }
   }
}

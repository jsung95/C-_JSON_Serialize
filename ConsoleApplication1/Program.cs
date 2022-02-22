using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Shirts shirts = new Shirts
            {
                Name = "myName",
                Created = new DateTime(2020, 10, 20),
                Sizes = new List<string> { "small", "big" }
            };

            string json1 = JsonConvert.SerializeObject(shirts, Formatting.Indented);

            Console.WriteLine(json1);


            string json2 = @"{
                              'Name': 'myName',
                              'Created': '2020-10-20T00:00:00',
                              'Sizes': [
                                'small',
                                'big'
                              ]
                            }";
            Shirts shirts2 = JsonConvert.DeserializeObject<Shirts>(json2);
            Console.WriteLine("{0} - {1} - {2}", shirts2.Name, shirts2.Created, shirts2.Sizes);
            Console.WriteLine(shirts2.Sizes[0]);
            Console.WriteLine(shirts2.Sizes[1]);
        }
    }
}

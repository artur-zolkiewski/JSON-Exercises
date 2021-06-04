using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;


namespace JSONexercises
{
    class Program
    {
    

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var path = @"E:\Projects\cwiczenia\JSONexercises\JSONexercises\example.json";
            string json = File.ReadAllText(path);

            List<User> items = JsonConvert.DeserializeObject<List<User>>(json);
            foreach (var item in items)
            {
                Console.WriteLine("{0} {1}", item.ID, item.Name);
            }

            Console.WriteLine("----------------------------------------------------------------------");

            var path1 = @"E:\Projects\cwiczenia\JSONexercises\JSONexercises\Employees2.json";
            string json2 = File.ReadAllText(path1);
            List<User2> items2 = JsonConvert.DeserializeObject<List<User2>>(json2);
            foreach (var item in items2)
            {
                Console.WriteLine(item.Email+' '+item.Name.First + ' ' + item.Name.Last);
                Console.WriteLine();
            }
        }

    }
}

using DataStructures.Algs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Apps
{
    public class HashTableApp
    {
        public static void _Main(string[] args)
        {
            HashTable<string, int> roundTable = new HashTable<string, int>();

            Console.WriteLine($"size : {roundTable.Size}");

            roundTable.Put("Ahmet", 0);
            roundTable.Remove("Ahmet");
            roundTable.Put("Ahmet", 0);
            roundTable.Put("Can", 0);
            roundTable.Put("Yusuf", 0);
            try
            {   // zaten mevcut
                roundTable.Put("Yusuf", 0);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            roundTable["Akif"] = 0;

            Console.WriteLine($"size : {roundTable.Size}");

            try
            {   // table'da Mahmut yok.
                roundTable.Remove("Mahmut");

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.WriteLine("Starting Points");
            foreach (var item in roundTable)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }

            for (int i = 0; i < 5; i++)
            {
                Random random = new Random();
                roundTable["Ahmet"] = random.Next(200);
                roundTable["Can"] = random.Next(200);
                roundTable["Yusuf"] = random.Next(200);
                roundTable["Akif"] = random.Next(200);

            }
            Console.WriteLine("Current Status");
            foreach (var item in roundTable)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }

            Console.ReadKey();
        }
    }
}

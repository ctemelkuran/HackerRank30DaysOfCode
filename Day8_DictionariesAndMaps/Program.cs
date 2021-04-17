using System.Collections.Generic;
using System;
using System.IO;

namespace Day8_DictionariesAndMaps
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n>Math.Pow(10,5) || n<1)
            {
                throw new Exception("Enter valid value");
            }
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                
                //string input = ;
                string[] items = Console.ReadLine().Split();
                phoneBook[items[0]] = items[1];

            }
            List<string> names = new List<string>();
            for (int i = 0; i < n; i++)
            {
                //string name = ;
                names.Add(Console.ReadLine());
                
                
            }

            
                foreach (var name in names)
                {
                
                    if (phoneBook.ContainsKey(name))
                    {
                        Console.WriteLine("{0}={1}", name, phoneBook[name]);
                    }
                    else if (!phoneBook.ContainsKey(name))
                    {
                        Console.WriteLine("Not found");
                    }
                
            }
        }
    }
}

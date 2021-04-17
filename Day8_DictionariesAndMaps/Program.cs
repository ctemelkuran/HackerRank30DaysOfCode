using System.Collections.Generic;
using System;
using System.IO;

namespace Day8_DictionariesAndMaps
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                
                string input = Console.ReadLine();
                string[] items = input.Split();
                phoneBook[items[0]] = items[1];
                if (items.Length > 2)
                {
                    Console.WriteLine("2 values must be entered");
                }
                else if (items[1].Length >8)
                {
                    Console.WriteLine("8 values must be entered");
                }
                
                  
                
                
            }
            List<string> names = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                names.Add(name);
                //string[] namesnput  = Console.ReadLine().ToString(); 
                
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

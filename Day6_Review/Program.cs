using System;
using System;
using System.Collections.Generic;
using System.IO;

namespace Day6_Review
{
    class Program
    {
        static void Main(string[] args)
        {
            //string S with a length of N
            // print its even-indexed and odd-indexed characters as space-separated strings on a single line
            //take input T for test cases
            int T = Convert.ToInt32(Console.ReadLine());
            List<string> stringList = new List<string>();

            for (int i = 0; i < T; i++)
            {
                stringList.Add(Console.ReadLine());
                
            }
            
            foreach (var item in stringList)
            {
                
                for (int i = 0; i < item.Length; i+=2)
                {
                    Console.Write(item[i]);
                }
                Console.Write(" ");
                for (int i = 1; i < item.Length; i+=2)
                {
                    Console.Write(item[i]);
                }
                Console.WriteLine("");
            }
        }
    }
}

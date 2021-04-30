using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Day16_StringToIntegerException
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();
            try
            {
                Console.WriteLine(Int32.Parse(S));
            }
            catch (FormatException)
            {
                Console.WriteLine("Bad String");
            }
       

        }
    }
}

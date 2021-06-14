using System;
using System.Collections.Generic;
using System.IO;


namespace Day25_RunningTimeAndComplexity
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                bool isPrime = true;
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine("Prime");
                }
                else
                {
                    Console.WriteLine("Not prime");
                }
            }
        }
    }
}

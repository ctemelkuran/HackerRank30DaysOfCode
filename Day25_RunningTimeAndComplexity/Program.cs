using System;
using System.Collections.Generic;
using System.IO;


namespace Day25_RunningTimeAndComplexity
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                list.Add(n);
            }
            bool isPrime = true;
            foreach (var item in list)
            {
                for (int i = 2; i < item; i++)
                {
                    if (item % i == 0)
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

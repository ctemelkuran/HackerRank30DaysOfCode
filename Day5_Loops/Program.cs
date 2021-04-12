using System;

namespace Day5_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                int result = i * n;
                Console.WriteLine("{0} x {1} = {2}", n, i, result);
            }
        }
    }
}

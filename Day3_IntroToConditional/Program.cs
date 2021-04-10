using System;

namespace Day3_IntroToConditional
{
    class Program
    {
        
        static void Main(string[] args)
        {

            int N = Convert.ToInt32(Console.ReadLine());
            
            if (!IsEven(N))
            {
                Console.WriteLine("Weird");
            }
            else if (IsEven(N))
            {
                if (N >= 2 && N <= 5)
                {
                    Console.WriteLine("Not Weird");
                }
                else if (N >= 6 && N <= 20)
                {
                    Console.WriteLine("Weird");
                }
                else if (N > 20)
                {
                    Console.WriteLine("Not Weird");
                }

            }
           
        }
        static bool IsEven(int n)
        {
            if (n % 2 == 0)
            {
                return true;

            }

            return false;
        }
    }
}

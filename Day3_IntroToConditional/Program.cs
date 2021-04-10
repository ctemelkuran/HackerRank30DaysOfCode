using System;

namespace Day3_IntroToConditional
{
    class Program
    {
        

        static void Main(string[] args)
        {

            int N = Convert.ToInt32(Console.ReadLine());
            
            if ()
            {
                Console.WriteLine("Weird");
            }
            else if (N%2==0 && N >= 2 && N <= 5)
            {
                Console.WriteLine("Not Weird");
            }
            else if (true)
            {

            }
        }
        public bool IsEven(int n)
        {
            if (n%2 == 0)
            {
                return true;
                
            }
            
            return false;
        }
    }
}

using System;

namespace Day17_MoreExceptions
{
    class Program
    {
        class Calculator
        {
            public int power(int n,int p)
            {
                double result;

                if (n < 0 ||p < 0)
                {
                    throw new Exception("n and p should be non-negative");
                }
                else
                {
                    result = Math.Pow(Convert.ToInt32(n), Convert.ToInt32(p));
                    return Convert.ToInt32(result);
                }

                
            }
        }
        static void Main(string[] args)
        {
            Calculator myCalculator = new Calculator();
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                string[] num = Console.ReadLine().Split();
                int n = int.Parse(num[0]);
                int p = int.Parse(num[1]);
                try
                {
                    int ans = myCalculator.power(n, p);
                    Console.WriteLine(ans);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }
            }
        }
    }
}

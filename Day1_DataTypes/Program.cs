using System;

namespace Day1_DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";
            // Declare second integer, double, and String variables.
            int myInt;
            double myDouble;
            string myString;
            // Read and save an integer, double, and String to your variables.
            myInt = Convert.ToInt32(Console.ReadLine());
            myDouble = Convert.ToDouble(Console.ReadLine());
            myString = Console.ReadLine();
            // Print the sum of both integer variables on a new line.
            Console.WriteLine(i + myInt);
            double sum = myDouble + d;
            Console.WriteLine(String.Format("{0:0.0}", sum));
            Console.WriteLine(s + myString);

        }
    }
}

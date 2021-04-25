using System;
using System.Linq;

namespace Day14_Scope
{
    class Difference
    {
        private int[] elements;
        public int maximumDifference;

        // Add your code here
        public Difference(int[] elements)
        {
            this.elements = elements;
        }

        public void computeDifference()
        {
            //for (int i = 0; i < elements.Length; i++)
            //{
            //    maximumDifference = Math.Abs(elements[i] )
            //}
            maximumDifference = Math.Abs(elements.Max()-elements.Min());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Convert.ToInt32(Console.ReadLine());

            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.computeDifference();

            Console.Write(d.maximumDifference);
        }
    }
}

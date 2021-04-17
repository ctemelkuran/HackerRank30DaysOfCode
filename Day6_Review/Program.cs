using System;
using System.Collections.Generic;

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

                for (int i = 0; i < item.Length; i += 2)
                {
                    Console.Write(item[i]);
                }
                Console.Write(" ");
                for (int i = 1; i < item.Length; i += 2)
                {
                    Console.Write(item[i]);
                }
                Console.WriteLine("");
            }

            //ArrayQueries();

        }

        private static void ArrayQueries()
        {
            int N = Convert.ToInt32(Console.ReadLine());

            int[] A = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            int Q = Convert.ToInt32(Console.ReadLine());


            int[][] LR = new int[Q][];


            for (int i = 0; i < Q; i++)
            {
                LR[i] = Array.ConvertAll(Console.ReadLine().Split(' '), LRTemp => Convert.ToInt32(LRTemp));
            }
            int sml = 0;
            int sml2nd = 9999;
            int j = 0;
            for (int a = 0; a < Q; a++)
            {
                for (int i = LR[a][0]; i < LR[a][1]; i++)
                {
                    if (sml > A[i])
                    {
                        sml = A[i];
                        j = i;
                    }

                }
            }
            for (int a = 0; a < Q; a++)
            {
                for (int i = LR[a][0]; i < LR[a][1]; i++)
                {
                    if (sml > A[i])
                    {
                        sml = A[i];
                        j = i;
                    }

                }
            }
        }
    }
}

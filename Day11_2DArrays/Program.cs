using System;

namespace Day11_2DArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[6][];
            int sum = 0, max = 0;

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < (arr[i].Length-2); j++)
                {
                    sum = arr[i][j];
                    //Console.Write(arr[i][j] + " ");
                }
                //Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

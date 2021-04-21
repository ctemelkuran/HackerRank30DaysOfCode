using System;

namespace Day11_2DArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[6][];
            int sum = 0, max = -64;

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < (arr[i].Length-1); j++)
                {
                    sum = arr[i][j] + arr[i-1][j-1] + arr[i-1][j] + arr[i-1][j+1]
                        + arr[i+1][j-1]+ arr[i+1][j] + arr[i+1][j+1];
                    if (max <= sum)
                    {
                        max = sum;
                    }
                    
                }
               
            }
            Console.WriteLine(max);
            Console.ReadLine();
        }
    }
}

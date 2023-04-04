using System;

namespace TwoDimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 3;
            int n = 4;
            double[,] array = new double[m, n];
            Random random = new Random();

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = random.NextDouble() * (random.Next(0, 2) == 0 ? 1 : -1);
                    Console.Write($"{array[i, j]:F2} ");
                }
                Console.WriteLine();
            }
        }
    }
}
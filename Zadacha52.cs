using System;

namespace ArrayColumnAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[,]
            {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 9, 10, 11, 12 }
            };

            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            for (int j = 0; j < columns; j++)
            {
                int columnSum = 0;

                for (int i = 0; i < rows; i++)
                {
                    columnSum += array[i, j];
                }

                double columnAverage = (double)columnSum / rows;
                Console.WriteLine($"Среднее арифметическое элементов в столбце {j}: {columnAverage}");
            }
        }
    }
}
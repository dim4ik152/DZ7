using System;

namespace ArrayElementLookup
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] array = new double[,]
            {
                { 0.5, 7, -2, -0.2 },
                { 1, -3.3, 8, -9.9 },
                { 8, 7.8, -7.1, 9 }
            };

            Console.WriteLine("Введите индекс строки элемента (начиная с 0):");
            int rowIndex = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите индекс столбца элемента (начиная с 0):");
            int columnIndex = int.Parse(Console.ReadLine());

            if (rowIndex >= 0 && rowIndex < array.GetLength(0) && columnIndex >= 0 && columnIndex < array.GetLength(1))
            {
                Console.WriteLine($"Значение элемента: {array[rowIndex, columnIndex]}");
            }
            else
            {
                Console.WriteLine("Такого элемента нет в массиве.");
            }
        }
    }
}
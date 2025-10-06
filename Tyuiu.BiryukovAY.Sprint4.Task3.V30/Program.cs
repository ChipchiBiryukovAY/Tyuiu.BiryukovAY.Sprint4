using System;
using Tyuiu.BiryukovAY.Sprint4.Task3.V30.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        int[,] array = {
            {2, 4, 3, 5, 1},
            {6, 6, 1, 2, 6},
            {3, 3, 2, 1, 5},
            {6, 4, 1, 3, 3},
            {5, 1, 1, 6, 4}
        };

        Console.WriteLine("Массив 5x5:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }

        int result = ds.Calculate(array);
        Console.WriteLine($"Максимум в третьей строке: {result}");

        Console.ReadKey();
    }
}
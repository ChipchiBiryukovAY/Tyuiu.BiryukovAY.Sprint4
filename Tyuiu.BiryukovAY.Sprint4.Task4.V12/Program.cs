using System;
using Tyuiu.BiryukovAY.Sprint4.Task4.V12.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        int[,] array = {
            {3, 6, 6, 8, 8},
            {2, 7, 2, 4, 6},
            {3, 6, 2, 6, 4},
            {8, 6, 2, 7, 3},
            {8, 7, 6, 6, 6}
        };

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        int[,] result = ds.Calculate(array);

        Console.WriteLine("\nПосле замены четных на 1:");
        PrintArray(result);

        Console.ReadKey();
    }
}
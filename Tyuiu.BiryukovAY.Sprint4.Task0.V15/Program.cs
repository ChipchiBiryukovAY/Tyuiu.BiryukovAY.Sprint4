using System;
using Tyuiu.BiryukovAY.Sprint4.Task0.V15.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int[] array = { 9, 8, 7, 6, 5, 7, 3, 2, 7, 3 };

        Console.WriteLine("Массив: { 9, 8, 7, 6, 5, 7, 3, 2, 7, 3 }");

        int result = ds.GetMultOddArrEl(array);
        Console.WriteLine($"Произведение нечетных: {result}");

        Console.ReadKey();
    }
}
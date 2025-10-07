using System;
using Tyuiu.BiryukovAY.Sprint4.Task7.V11.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        int rows = 4;
        int columns = 2;
        string str = "56789012";

        Console.WriteLine($"Строка: {str}");
        Console.WriteLine($"Матрица: {rows}x{columns}");

        int result = ds.Calculate(rows, columns, str);
        Console.WriteLine($"Нечетных чисел: {result}");

        Console.ReadKey();
    }
}
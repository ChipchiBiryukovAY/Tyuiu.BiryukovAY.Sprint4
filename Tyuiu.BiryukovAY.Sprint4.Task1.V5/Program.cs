using System;
using Tyuiu.BiryukovAY.Sprint4.Task1.V5.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int[] array = new int[15];

        Console.WriteLine("Введите 15 чисел от 5 до 9:");
        for (int i = 0; i < 15; i++)
        {
            Console.Write($"{i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Массив: ");
        foreach (int num in array)
            Console.Write(num + " ");

        int result = ds.Calculate(array);
        Console.WriteLine($"\nСумма четных: {result}");

        Console.ReadKey();
    }
}
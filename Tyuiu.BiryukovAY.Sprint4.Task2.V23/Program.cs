using System;
using Tyuiu.BiryukovAY.Sprint4.Task2.V23.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int[] array = new int[15];
        Random rand = new Random();

        for (int i = 0; i < 15; i++)
        {
            array[i] = rand.Next(3, 9);
        }

        Console.Write("Массив: ");
        foreach (int num in array)
            Console.Write(num + " ");

        int result = ds.Calculate(array);
        Console.WriteLine($"\nСумма четных: {result}");

        Console.ReadKey();
    }
}
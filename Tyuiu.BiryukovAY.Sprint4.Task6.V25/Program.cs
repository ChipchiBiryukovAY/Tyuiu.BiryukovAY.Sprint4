using System;
using Tyuiu.BiryukovAY.Sprint4.Task6.V25.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        string[] array = { "Теннис", "Футбол", "Крикет", "Баскетбол", "Бейсбол", "Регби", "Хоккей" };

        Console.WriteLine("Массив:");
        foreach (string element in array)
        {
            Console.WriteLine($"{element} - {element.Length} симв.");
        }

        int result = ds.Calculate(array);
        Console.WriteLine($"\nЭлементов длиннее 6 символов: {result}");

        Console.ReadKey();
    }
}
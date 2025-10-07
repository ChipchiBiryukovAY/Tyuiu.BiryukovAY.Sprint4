using System;
using Tyuiu.BiryukovAY.Sprint4.Task5.V6.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Random random = new Random();

        int[,] array = new int[5, 5];

        Console.WriteLine("Генерация массива 5x5 со случайными числами от -3 до 5");
        Console.WriteLine("=====================================================");

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                array[i, j] = random.Next(-3, 6); 
            }
        }

        Console.WriteLine("\nИсходный массив:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }

        int[,] result = ds.Calculate(array);

        Console.WriteLine("\nМассив после замены положительных элементов на 1:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(result[i, j] + " ");
            }
            Console.WriteLine();

            Console.ReadKey();
    }
}
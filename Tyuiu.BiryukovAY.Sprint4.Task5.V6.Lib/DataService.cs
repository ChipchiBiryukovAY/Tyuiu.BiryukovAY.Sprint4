using System;
using tyuiu.cources.programming.interfaces.Sprint4;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Tyuiu.BiryukovAY.Sprint4.Task5.V6.Lib
{
    public class DataService : ISprint4Task5V6
    {
        public int[,] Calculate(int[,] array)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (array[i, j] > 0)
                        array[i, j] = 1;
                }
            }
            return array;
        }
    }
}

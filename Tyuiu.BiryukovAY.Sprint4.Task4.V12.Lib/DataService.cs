using System;
using tyuiu.cources.programming.interfaces.Sprint4;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Tyuiu.BiryukovAY.Sprint4.Task4.V12.Lib
{
    public class DataService : ISprint4Task4V12
    {
        public int[,] Calculate(int[,] array)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (array[i, j] % 2 == 0)
                        array[i, j] = 1;
                }
            }
            return array;
        }
    }
}

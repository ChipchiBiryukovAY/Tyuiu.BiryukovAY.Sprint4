using System;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BiryukovAY.Sprint4.Task3.V30.Lib
{
    public class DataService : ISprint4Task3V30
    {
        public int Calculate(int[,] array)
        {
            int count = array[2, 0]; 

            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[2, j] > count)
                {
                    count = array[2, j];
                }
            }

            return count;
        }
    }
}

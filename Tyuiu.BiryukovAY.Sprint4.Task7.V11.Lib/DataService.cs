using System;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BiryukovAY.Sprint4.Task7.V11.Lib
{
    public class DataService : ISprint4Task7V11
    {
        public int Calculate(int rows, int columns, string value)
        {
            int[,] mtrx = new int[rows, columns];
            int index = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (index < value.Length)
                    {
                        mtrx[i, j] = int.Parse(value[index].ToString());
                        index++;
                    }
                }
            }

            int Count = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (mtrx[i, j] % 2 != 0)
                    {
                        Count++;
                    }
                }
            }

            return Count;
        }
    }
}

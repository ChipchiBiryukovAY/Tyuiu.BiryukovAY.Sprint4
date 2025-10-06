using System;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BiryukovAY.Sprint4.Task1.V5.Lib
{
    public class DataService : DataServiceBase, ISprint4Task1V5
    {
        public override int Calculate(int[] array)
        {
            int sum = 0;

            foreach (int element in array)
            {
                if (element % 2 == 0) 
                {
                    sum += element;
                }
            }
        }
    }
}

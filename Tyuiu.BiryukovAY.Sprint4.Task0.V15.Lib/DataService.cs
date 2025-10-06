using System;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BiryukovAY.Sprint4.Task0.V15.Lib
{
    public class DataService : ISprint4Task0V15
    {
        public int GetMultOddArrEl(int[] array)
        {
            int product = 1;
            bool found = false;

            foreach (int element in array)
            {
                if (element % 2 != 0)    
                {
                    product *= element;
                    found = true;
                }
            }

            return found ? product : 0;
        }
    }
}

using System;
using Tyuiu.BiryukovAY.Sprint4.Task4.V12.Lib;
namespace Tyuiu.BiryukovAY.Sprint4.Task4.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] inputArray = {
                {3, 6, 6, 8, 8},
                {2, 7, 2, 4, 6},
                {3, 6, 2, 6, 4},
                {8, 6, 2, 7, 3},
                {8, 7, 6, 6, 6}
            };

            int[,] expectedArray = {
                {3, 1, 1, 1, 1},
                {1, 7, 1, 1, 1},
                {3, 1, 1, 1, 1},
                {1, 1, 1, 7, 3},
                {1, 7, 1, 1, 1}
            };

            int[,] result = ds.Calculate(inputArray);

            CollectionAssert.AreEqual(expectedArray, result);
        }
    }
}

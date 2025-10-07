using System;
using Tyuiu.BiryukovAY.Sprint4.Task5.V6.Lib;
namespace Tyuiu.BiryukovAY.Sprint4.Task5.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] inputArray = {
                {-1, 3, -2, 5, 0},
                {2, -3, 4, 1, -1},
                {0, 2, -2, 3, 4},
                {-3, 1, 2, 0, 5},
                {4, -1, -2, 3, 2}
            };

            int[,] expectedArray = {
                {-1, 1, -2, 1, 0},
                {1, -3, 1, 1, -1},
                {0, 1, -2, 1, 1},
                {-3, 1, 1, 0, 1},
                {1, -1, -2, 1, 1}
            };

            int[,] result = ds.Calculate(inputArray);

            CollectionAssert.AreEqual(expectedArray, result);
        }
    }
}

using System;
using Tyuiu.BiryukovAY.Sprint4.Task3.V30.Lib;
namespace Tyuiu.BiryukovAY.Sprint4.Task3.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] array = {
                {2, 4, 3, 5, 1},
                {6, 6, 1, 2, 6},
                {3, 3, 2, 1, 5},
                {6, 4, 1, 3, 3},
                {5, 1, 1, 6, 4}
            };

            int result = ds.Calculate(array);

            Assert.AreEqual(5, result); 
        }
    }
}

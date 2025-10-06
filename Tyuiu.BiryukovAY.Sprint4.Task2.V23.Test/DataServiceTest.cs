using System;
using Tyuiu.BiryukovAY.Sprint4.Task2.V23.Lib;
namespace Tyuiu.BiryukovAY.Sprint4.Task2.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 3, 4, 5, 6, 7, 8, 3, 4, 5, 6, 7, 8, 3, 4, 5 };
            int result = ds.Calculate(array);
            Assert.AreEqual(40, result);
        }
    }
}

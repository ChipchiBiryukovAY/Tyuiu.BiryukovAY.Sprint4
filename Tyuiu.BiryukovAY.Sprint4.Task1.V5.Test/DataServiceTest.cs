using System;
using Tyuiu.BiryukovAY.Sprint4.Task1.V5.Lib;
namespace Tyuiu.BiryukovAY.Sprint4.Task1.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 9, 6, 6, 9, 7, 8, 5, 9, 6, 6, 8, 6, 8, 6, 7 };
            int result = ds.Calculate(array);
            Assert.AreEqual(54, result);
        }
    }
}

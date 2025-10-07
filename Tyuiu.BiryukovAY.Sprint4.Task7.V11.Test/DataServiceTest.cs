using System;
using Tyuiu.BiryukovAY.Sprint4.Task7.V11.Lib;
namespace Tyuiu.BiryukovAY.Sprint4.Task7.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int rows = 4;
            int columns = 2;
            string str = "56789012";

            int result = ds.Calculate(rows, columns, str);

            Assert.AreEqual(4, result); 
        }
    }
}

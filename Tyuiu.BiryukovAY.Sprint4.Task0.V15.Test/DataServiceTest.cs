using System;
using Tyuiu.BiryukovAY.Sprint4.Task0.V15.Lib;
namespace Tyuiu.BiryukovAY.Sprint4.Task0.V15.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 9, 8, 7, 6, 5, 7, 3, 2, 7, 3 };

            int result = ds.GetMultOddArrEl(array);

            Assert.AreEqual(138915, result);
        }
    }
}

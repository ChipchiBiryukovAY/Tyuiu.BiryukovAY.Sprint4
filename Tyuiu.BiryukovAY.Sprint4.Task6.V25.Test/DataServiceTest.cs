using System;
using Tyuiu.BiryukovAY.Sprint4.Task6.V25.Lib;
namespace Tyuiu.BiryukovAY.Sprint4.Task6.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] array = { "Теннис", "Футбол", "Крикет", "Баскетбол", "Бейсбол", "Регби", "Хоккей" };

            int result = ds.Calculate(array);

            Assert.AreEqual(2, result);
        }
    }
}

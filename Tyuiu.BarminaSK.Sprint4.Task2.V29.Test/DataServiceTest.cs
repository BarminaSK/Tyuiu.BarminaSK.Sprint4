using Tyuiu.BarminaSK.Sprint4.Task2.V29.Lib;

namespace Tyuiu.BarminaSK.Sprint4.Task2.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = { 2, 4, 3, 6, 2, 8, 1, 4, 5, 6, 2 };

            int result = ds.Calculate(array);
            int wait = 2 * 4 * 6 * 2 * 8 * 4 * 6 * 2;

            Assert.AreEqual(wait, result);
        }
        [TestMethod]
        public void ValidCalculateWithSpecificArray()
        {
            DataService ds = new DataService();

            int[] array = { 2, 4, 6, 8, 4, 6, 2, 8, 4, 6, 2 };

            int result = ds.Calculate(array);
            int wait = 2 * 4 * 6 * 8 * 4 * 6 * 2 * 8 * 4 * 6 * 2;

            Assert.AreEqual(wait, result);
        }
    }
}

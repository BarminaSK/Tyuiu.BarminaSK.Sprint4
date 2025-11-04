using Tyuiu.BarminaSK.Sprint4.Task1.V16.Lib;

namespace Tyuiu.BarminaSK.Sprint4.Task1.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = { 4, 3, 7, 3, 7, 4, 3, 3, 4, 4, 8, 3, 4 };

            int result = ds.Calculate(array);
            int wait = 11907;

            Assert.AreEqual(wait, result);
        }
    }
}

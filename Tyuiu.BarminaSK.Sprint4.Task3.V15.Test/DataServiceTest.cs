using Tyuiu.BarminaSK.Sprint4.Task3.V15.Lib;

namespace Tyuiu.BarminaSK.Sprint4.Task3.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] array = new int[5, 5] {
                {7, 4, 2, 5, 3},
                {4, 3, 2, 5, 6},
                {6, 3, 4, 7, 5},
                {5, 7, 4, 3, 8},
                {7, 8, 8, 5, 6}
            };

            int res = ds.Calculate(array);
            int wait = 13;

            Assert.AreEqual(wait, res);
        }
    }
}

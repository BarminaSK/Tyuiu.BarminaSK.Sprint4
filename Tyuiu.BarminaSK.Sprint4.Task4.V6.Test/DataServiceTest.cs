using Tyuiu.BarminaSK.Sprint4.Task4.V6.Lib;

namespace Tyuiu.BarminaSK.Sprint4.Task4.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5] {
                {7, 6, 6, 6, 9},
                {4, 4, 4, 9, 4},
                {5, 5, 5, 6, 5},
                {4, 9, 5, 9, 7},
                {6, 9, 5, 6, 7}
            };

            int[,] res = ds.Calculate(matrix);
            int[,] wait = new int[5, 5] {
                {0, 6, 6, 6, 0},
                {4, 4, 4, 0, 4},
                {0, 0, 0, 6, 0},
                {4, 0, 0, 0, 0},
                {6, 0, 0, 6, 0}
            };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}

using Microsoft.ApplicationInsights;
using Tyuiu.BarminaSK.Sprint4.Task5.V13.Lib;

namespace Tyuiu.BarminaSK.Sprint4.Task5.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5]
            {
                { 1, -2, 3, -1, 4 },
                { 5, 0, -2, 2, 3 },
                { -1, 4, 5, -2, 1 },
                { 2, 3, 4, 5, 0 },
                { -2, 1, 3, 4, 5 }
            };

            int[,] result = ds.Calculate(matrix);

            int[,] wait = new int[5, 5]
            {
                { 1, 0, 3, 0, 4 },
                { 5, 0, 0, 2, 3 },
                { 0, 4, 5, 0, 1 },
                { 2, 3, 4, 5, 0 },
                { 0, 1, 3, 4, 5 }
            };

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Assert.AreEqual(wait[i, j], result[i, j]);
                }
            }
        }
    }
}

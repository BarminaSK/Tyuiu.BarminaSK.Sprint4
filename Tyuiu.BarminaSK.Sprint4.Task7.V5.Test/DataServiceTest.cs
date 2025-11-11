using Tyuiu.BarminaSK.Sprint4.Task7.V5.Lib;

namespace Tyuiu.BarminaSK.Sprint4.Task7.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            int n = 3;
            int m = 3;
            int[,] mtrx = new int[n, m];
            string str = "246813579";
            DataService ds = new DataService();
            int res = ds.Calculate(n, m, str);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}

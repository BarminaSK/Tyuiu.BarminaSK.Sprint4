using Tyuiu.BarminaSK.Sprint4.Task6.V1.Lib;

namespace Tyuiu.BarminaSK.Sprint4.Task6.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string[] array = { "Яблоко", "Банан", "Вишня", "Драгонфрут", "Бузина", "Инжир", "Виноград" };

            int result = ds.Calculate(array);
            int wait = 2;

            Assert.AreEqual(wait, result);
        

        }
    }
}

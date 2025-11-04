using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.BarminaSK.Sprint4.Task0.V2.Lib
{
    public class DataService : ISprint4Task0V2
    {
        public int GetSumOddArrEl(int[] array)
        {
            int sum = 0;
            foreach (int num in array)
            {
                if (num % 2 != 0)
                {
                    sum += num;
                }
            }
            return sum;
        }
    }
}

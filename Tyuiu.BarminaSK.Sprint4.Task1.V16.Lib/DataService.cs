using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.BarminaSK.Sprint4.Task1.V16.Lib
{
    public class DataService : ISprint4Task1V16
    {
        public int Calculate(int[] array)
        {
            int product = 1;
            bool hasOdd = false;

            foreach (int num in array)
            {
                if (num % 2 != 0)
                {
                    product *= num;
                    hasOdd = true;
                }
            }

            return hasOdd ? product : 0;
        }
    }
}

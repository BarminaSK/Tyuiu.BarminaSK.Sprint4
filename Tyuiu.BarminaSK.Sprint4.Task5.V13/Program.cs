using Tyuiu.BarminaSK.Sprint4.Task5.V13.Lib;

namespace Tyuiu.BarminaSK.Sprint4.Task5.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random random = new Random();

            int[,] matrix = new int[5, 5];

            Console.Title = "Спринт #4 | Выполнила: Бармина С.К. | ПИНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Задание #4                                                               *");
            Console.WriteLine("* Вариант #6                                                             *");
            Console.WriteLine("* Выполнила: Бармина София Константиновна | ПИНб-25-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = random.Next(-2, 6);
                    Console.Write($"{matrix[i, j],4}");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int[,] resultMatrix = ds.Calculate(matrix);

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"{resultMatrix[i, j],4}");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();

            int negativeCount = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        negativeCount++;
                    }
                }
            }

            Console.WriteLine($"Количество замененных отрицательных элементов: {negativeCount}");
            Console.WriteLine($"Диапазон значений в исходном массиве: от -2 до 5");

            Console.ReadKey();
        }    
    }
}

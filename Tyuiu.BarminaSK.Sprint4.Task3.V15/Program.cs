using Tyuiu.BarminaSK.Sprint4.Task3.V15.Lib;

namespace Tyuiu.BarminaSK.Sprint4.Task3.V15
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Title = "Спринт #4 | Выполнила: Бармина С.К. | ПИНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Задание #3                                                               *");
            Console.WriteLine("* Вариант #15                                                            *");
            Console.WriteLine("* Выполнила: Бармина София Константиновна | ПИНб-25-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] array = new int[5, 5] {
                {7, 4, 2, 5, 3},
                {4, 3, 2, 5, 6},
                {6, 3, 4, 7, 5},
                {5, 7, 4, 3, 8},
                {7, 8, 8, 5, 6}
            };

            Console.WriteLine("Массив:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int result = ds.Calculate(array);

            Console.WriteLine($"Количество нечетных элементов в массиве = {result}");
            Console.ReadKey();
        }
    }
}

using Tyuiu.BarminaSK.Sprint4.Task4.V6.Lib;

namespace Tyuiu.BarminaSK.Sprint4.Task4.V6
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Title = "Спринт #4 | Выполнила: Бармина С.К. | ПИНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Задание #4                                                               *");
            Console.WriteLine("* Вариант #6                                                             *");
            Console.WriteLine("* Выполнила: Бармина София Константиновна | ПИНб-25-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] matrix = new int[5, 5] {
                {7, 6, 6, 6, 9},
                {4, 4, 4, 9, 4},
                {5, 5, 5, 6, 5},
                {4, 9, 5, 9, 7},
                {6, 9, 5, 6, 7}
            };

            Console.WriteLine("Исходный массив:");
            PrintMatrix(matrix);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int[,] resultMatrix = ds.Calculate(matrix);

            Console.WriteLine("Массив после замены нечетных элементов на 0:");
            PrintMatrix(resultMatrix);

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }

        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}

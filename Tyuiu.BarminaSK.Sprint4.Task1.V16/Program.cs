using Tyuiu.BarminaSK.Sprint4.Task1.V16.Lib;

namespace Tyuiu.BarminaSK.Sprint4.Task1.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int[] array = { 4, 3, 7, 3, 7, 4, 3, 3, 4, 4, 8, 3, 4 };

            Console.Title = "Спринт #3 | Выполнила: Бармина С.К. | ПИНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт Ревью                                                            *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнила: Бармина София Константиновна | ПИНб-25-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Массив: { " + string.Join(", ", array) + " }");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine();
            Console.WriteLine("Нечетные элементы: 3, 7, 3, 7, 3, 3, 3");
            Console.WriteLine("Произведение: 3 * 7 * 3 * 7 * 3 * 3 * 3 = 11907");

            Console.ReadKey();

        }
    }
}

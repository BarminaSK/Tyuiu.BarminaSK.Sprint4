using Tyuiu.BarminaSK.Sprint4.Task2.V29.Lib;

namespace Tyuiu.BarminaSK.Sprint4.Task2.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random random = new Random();
            int[] array = new int[11];

            Console.Title = "Спринт #3 | Выполнила: Бармина С.К. | ПИНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт Ревью                                                            *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнила: Бармина София Константиновна | ПИНб-25-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Массив: { ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 9); // от 1 до 8 включительно
                Console.Write(array[i]);
                if (i < array.Length - 1)
                    Console.Write(", ");
            }
            Console.WriteLine(" }");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            int result = ds.Calculate(array);
            Console.WriteLine("Произведение четных элементов массива = " + result);

            Console.WriteLine();
            Console.Write("Четные элементы: ");
            int product = 1;
            bool firstElement = true;

            foreach (int num in array)
            {
                if (num % 2 == 0)
                {
                    if (!firstElement)
                        Console.Write(" * ");
                    Console.Write(num);
                    product *= num;
                    firstElement = false;
                }
            }

            if (product == 1 && !firstElement)
            {
                Console.WriteLine(" = " + result);
            }
            else if (firstElement)
            {
                Console.WriteLine("четных элементов нет");
            }

            Console.ReadKey();

        }
    }
}
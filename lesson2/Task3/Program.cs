using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //ЗАДАНИЕ 3
            //С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
            //Сержов Михаил

            Console.WriteLine("Вводите числа.\nПрограмма подсчитает сумму всех введёных Вами нечётных положительных чисел.\nВведите 0 для окончания ввода чисел.");
            long number, sumNumber = 0;
            do
            {
                Console.WriteLine("Ведите число");
                number = long.Parse(Console.ReadLine());
                if (number % 2 != 0)
                {
                    sumNumber = sumNumber + number;

                }
            } while (number != 0);

            Console.WriteLine(string.Format("Сумма введённых Вами нечётных положительных чисел равна:" + sumNumber));

        }
    }
}

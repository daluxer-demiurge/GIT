using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ЗАДАНИЕ 2
            //Написать метод подсчета количества цифр числа.
            //Сержов Михаил

            Console.WriteLine("Введите целое число.\nНе более 18 цифр.");
            long num = long.Parse(Console.ReadLine());

            long simbCount = NumberOfDigits(ref num);

            Console.WriteLine(string.Format("Количество цифр вашего числа: " + simbCount));
        }

        private static long NumberOfDigits(ref long num)
        {
            long simbCount = 0;
            while (num > 0)
            {
                num = num / 10;
                simbCount++;

            }

            return simbCount;
        }
    }
}

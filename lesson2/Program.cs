using System;

namespace lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ЗАДАНИЕ 1
            //Написать метод, возвращающий минимальное из трех чисел.
            //Сержов Михаил

            Console.WriteLine("Введите три целых числа");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int min = FindMinNumber(a, b, c);

            Console.WriteLine(String.Format("Наименьшее из введёных чисел: " + min));

        }

        private static int FindMinNumber(int a, int b, int c)
        {
            int min = 0;
            if (b > a && a < c)
            {
                min = a;

            }
            else if (b > c)
            {
                min = c;
            }
            else min = b;
            return min;
        }
    }
}

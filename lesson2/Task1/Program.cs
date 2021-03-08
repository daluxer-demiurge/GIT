using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ЗАДАНИЕ 1
            //Написать метод, возвращающий минимальное из трех чисел.
            //Сержов Михаил

            Console.WriteLine("Введите три целых числа. \nПосле ввода каждого числа подтверждайте ввод клавишей Enter.");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int min;

            Console.WriteLine("Минимальное из введеных Вами трёх чисел: ");
            min = FindMin(a, b, c);

            Console.Write(min);
        }

        public static int FindMin(int a, int b, int c)
        {
            int min;
            if (a < b && a < c)
            {
                min = a;
            }
            else if (b < c)
            {
                min = b;
            }
            else min = c;
            return min;
        }
    }
}

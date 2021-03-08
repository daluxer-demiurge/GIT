using System;

namespace Task7
{
    class Program

        //ЗАДАНИЕ 7
        //7. a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b);
        //б) * Разработать рекурсивный метод, который считает сумму чисел от a до b.
        //Сержов Михаил
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите последнее число");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Последовательность чисел: ");
            Loop(a, b);
            Console.WriteLine("Сумма чисел: " + Sum(a, b));          
            
        }


        static void Loop(int c, int d)
        {
            Console.Write("{0,3} ", c);
            if (c < d) Loop(c + 1, d);
        }


        static int Sum(int c, int d)
        {
            if (c > d) return 0;
            return c + Sum(c + 1, d);
            
        }


    }
}


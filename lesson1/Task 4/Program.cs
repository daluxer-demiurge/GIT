using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //ЗАДАНИЕ 4
            //Написать программу обмена значениями двух переменных.
            //а) с использованием третьей переменной;
            //б) *без использования третьей переменной.
            //Сержов Михаил

            //Решение а)
            Console.WriteLine("Решение а)");
            Console.WriteLine("Введите значение первой переменной a:");
                int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение второй переменной b:");
                int b = int.Parse(Console.ReadLine());
                   
            int c = 0;
            c = a;
            a = b;
            b = c;

            Console.WriteLine(string.Format("Решение а): После обмена переменные имеют следующие значения: " + "a=" + a + ", " + "b=" + b));                   

            //Решение б)
            Console.WriteLine("\n" + "Решение б)");
            Console.WriteLine("Введите значение первой переменной x:");
                int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение второй переменной y:");
                int y = int.Parse(Console.ReadLine());

            x = x + y;
            y = x - y;
            x = x - y;

            Console.Write(string.Format("Решение б): После обмена переменные имеют следующие значения: " + "x=" + x + ", " + "y=" + y));

        }
    }
}

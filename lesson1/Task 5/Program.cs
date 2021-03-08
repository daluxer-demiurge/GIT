using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //ЗАДАНИЕ 5
            //а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            //б) Сделать задание, только вывод организуйте в центре экрана
            //в) *Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y)
            //Сержов Михаил

            //Решение а)
            Console.WriteLine("Михаил Сержов, Самара");
            System.Threading.Thread.Sleep(4000);

            //Решение б)
            Console.WriteLine("А теперь тоже самое, но по центру экрана!");
            System.Threading.Thread.Sleep(4000);
            Console.Clear();
           
            string text = "Михаил Сержов, Самара";
            int coordX = (Console.WindowWidth / 2) - (text.Length / 2);
            int coordY = (Console.WindowHeight / 2) - 1;
            Console.SetCursorPosition(coordX, coordY);
            Console.WriteLine(text);
            System.Threading.Thread.Sleep(4000);


        }
    }
}

using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //ЗАДАНИЕ 3
            //а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
            //б) *Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода; 
            //Сержов Михаил


            Console.WriteLine("Введите координаты по оси Х для первой точки");
                double x1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координаты по оси Y для первой точки");
                double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координаты по оси Х для второй точки");
                double x2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координаты по оси Y для второй точки");
                double y2 = double.Parse(Console.ReadLine());


            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            
            Console.WriteLine($"Расстояние между точками с координатами x1, y1 и x2,y2: {r:F2}");

 


        }
    }
}

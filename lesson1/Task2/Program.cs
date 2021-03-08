using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ЗАДАНИЕ 2
            //Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах
            //Сержов Михаил

            Console.WriteLine("Введите вес в килограммах, для разделения целого используйте запятую");
            double w = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите рост в метрах, для разделения целого используйте запятую");
                double h = double.Parse(Console.ReadLine());

            double i = w / (h * h);

            Console.WriteLine(String.Format("Индекс массы тела: " + i));
            

        }
    }
}

using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            //ЗАДАНИЕ 5
            //а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
            //б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
            //Сержов Михаил

            double imt = 0;
            Console.WriteLine("Введите вес");
            double m = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите рост");
            double h = double.Parse(Console.ReadLine());
            imt = m / (h * h);
            double OKmin = 18.5 * (h * h);
            double OKmax = 25 * (h * h);
            double resultMax = OKmin - m;
            double resultMin = OKmax - m;
            if (imt <= 16)
            {
                Console.WriteLine("У Вас выраженный дефицит массы тела");
                Console.WriteLine(string.Format("Наберите от " + resultMax + " до " + resultMin + " кг веса"));
            }
            else if (imt < 18.5)
            {
                Console.WriteLine("У Вас недостаточная масса тела");
                Console.WriteLine(string.Format("Наберите от " + resultMax + " до " + resultMin + " кг веса"));
            }
            else if (imt < 25)
            {
                Console.WriteLine("У Вас норма");
            }
            else if (imt < 35)
            {
                Console.WriteLine("У Вас ожирение");
                Console.WriteLine(string.Format("Нужно скинуть от " + resultMin + " до " + resultMax + " кг веса"));
            }
            else if (imt < 40)
            {
                Console.WriteLine("У Вас резкое ожирение");
                Console.WriteLine(string.Format("Нужно скинуть от " + resultMin + " до " + resultMax + " кг веса"));
            }
            else if (imt >= 40)
            {
                Console.WriteLine("У Вас очень резкое ожирение");
                Console.WriteLine(string.Format("Нужно скинуть от " + resultMin + " до " + resultMax + " кг веса"));
            }


            






        }
    }
}

using System;

namespace lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ЗАДАНИЕ 1
            //Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку.
            //а) используя склеивание;
            //б) используя форматированный вывод;
            //в) *используя вывод со знаком $.
            //Сержов Михаил


            Console.WriteLine ("Введите фамилию: ");
                string sname = Console.ReadLine();

            Console.WriteLine("Введите имя: ");
                string name = Console.ReadLine();

            Console.WriteLine("Введите возраст: ");
                int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите рост: ");
                int hight = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите вес: ");
                int wight = int.Parse(Console.ReadLine());

            //решение а)
            Console.WriteLine(String.Format(sname + " " + name + " " + age + " " + hight + " " + wight));

            //решение б)
            Console.WriteLine(String.Format("{0} {1} {2} {3} {4}", sname, name, age, hight, wight));

            //решение в)
            Console.WriteLine($"{sname} {name} {age} {hight} {wight}");

            

        }
    }
}

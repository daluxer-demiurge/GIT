using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            //ЗАДАНИЕ 6
            //*Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000.
            //Хорошим называется число, которое делится на сумму своих цифр.
            //Реализовать подсчет времени выполнения программы, используя структуру DateTime.
            //Сержов Михаил


            int numberMin = 1;
            int numberMax = 1000000000;
            int goodNumbers = 0, countNumbers = 0;

            Console.WriteLine("Количество чисел, которые делятся на сумму своих цифр в интервале от 1 до 1 000 000 000");
            DateTime start = DateTime.Now; 
            for (int i = numberMin; i < numberMax; i++)
                {
                countNumbers = calculateNumbers(i);
                    if ((i % countNumbers) == 0)
                    goodNumbers++;
                }
            Console.WriteLine("составило {0:N0} штук", goodNumbers);
            DateTime finish = DateTime.Now;
            Console.Write("Время выполнения программы: ");
            Console.WriteLine(finish - start);



            static int calculateNumbers(int i)
            {
                int count = 0;
                while (i > 0)
                {
                    i = i / 10;
                    count++;
                }
                return count;
            }
        }
    }
}

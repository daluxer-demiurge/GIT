using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ЗАЛАНИЕ 2
            //а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке).
            //Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse;
            //б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные.
            //При возникновении ошибки вывести сообщение.Напишите соответствующую функцию;

            Console.WriteLine("Вводите числа.\nПрограмма подсчитает сумму всех введёных Вами нечётных положительных чисел.\nВведите 0 для окончания ввода чисел.\n");
            int number, sum = default;
            string totalLine = default;
            do
            {
                Console.WriteLine("Введите число");
                string input = Console.ReadLine();
                bool result = Int32.TryParse(input, out number);

                if (number > 0 && number % 2 != 0)
                {
                    totalLine = totalLine + ", " + input;
                    sum = sum + number;
                }
                else if (result == false || number < 0) number = ErrorInput(number);
            } while (number != 0);
               
                Console.WriteLine(string.Format("Сумма нечётных положительных чисел" + totalLine + " равна " + sum));







        }

        public static int ErrorInput(int number)
        {
            
                Console.WriteLine("Неправильный ввод, повторите.");
                number = 1; //для предотвращения выхода по while !=0 
                        return number; 
        }
    }
}

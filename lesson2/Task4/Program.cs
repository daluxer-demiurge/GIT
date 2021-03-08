using System;

namespace Task4
{
    class Program
    {






        static void Main(string[] args)
        {
            //ЗАДАНИЕ 4
            //Реализовать метод проверки логина и пароля. На вход подается логин и пароль. 
            //На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
            //Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
            //С помощью цикла do while ограничить ввод пароля тремя попытками.
            //Сержов Михаил

            int tryCount = 0;
            int maxTryCount = 3;
            string login = "root";
            string pass = "GeekBrains";

            do
            {
                Console.WriteLine("Введите логин");
                string userLogin = Console.ReadLine();
                Console.WriteLine("Введите пароль");
                string userPass = Console.ReadLine();
                if (userLogin == login && userPass == pass)
                {
                    Console.WriteLine("Аторизация пройдена успешно.");
                    break;
                }
                else
                {
                    Console.WriteLine("Неверный логин и/или пароль.");
                    tryCount++;
                }
            } while (tryCount < maxTryCount);





        }
    }
}
 
    

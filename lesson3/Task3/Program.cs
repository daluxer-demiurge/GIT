using System;

namespace Task3
{

    //ЗАДАНИЕ 3
    //*Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел.
    //Предусмотреть методы сложения, вычитания, умножения и деления дробей.
    //Написать программу, демонстрирующую все разработанные элементы класса.
    //Достаточно решить 2 задачи. Все программы сделать в одном решении.
    //** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0"); Добавить упрощение дробей.
    //Сержов Михаил

    class Fraction
    {
        public int Num;
        public int Denom;


        public Fraction Plus(Fraction x)
        {
            Fraction z = new Fraction();
            z.Denom = this.Denom * x.Denom;     
            z.Num = this.Num * x.Denom + x.Num * this.Denom;    
            return z;
        }

        public Fraction Minus(Fraction x)
        {
            Fraction z = new Fraction();
            z.Denom = this.Denom * x.Num;
            z.Num = this.Num * x.Denom;
            return z;
        }

        public Fraction Multi(Fraction x)
        {
            Fraction z = new Fraction();
            z.Denom = this.Denom * x.Denom;
            z.Num = this.Num * x.Num;
            return z;
        }
       
        public Fraction Division(Fraction x)
        {
            Fraction z = new Fraction();
            z.Denom = this.Denom * x.Num;
            z.Num = this.Num * x.Denom;
            return z;
        }

        public string ToString()
        {
            return Num + "/" + Denom;
        }

    }
        


    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите первую дробь. После ввода числителя или знаменателя подтвердите ввод клавишей Enter.");
            //int a = );
            //Console.Write("/");
            //int b = ;

            Fraction FractNumber1 = new Fraction();
            FractNumber1.Num = 1;
            FractNumber1.Denom = 2;

            Fraction FractNumber2 = new Fraction();
            FractNumber2.Num = 3;
            FractNumber2.Denom = 4;

            Fraction result = FractNumber1.Plus(FractNumber2);
            Console.WriteLine(result.ToString());
            result = FractNumber1.Minus(FractNumber2);
            Console.WriteLine(result.ToString());
            result = FractNumber1.Multi(FractNumber2);
            Console.WriteLine(result.ToString());
            result = FractNumber1.Division(FractNumber2);
            Console.WriteLine(result.ToString());
        }
    }
}

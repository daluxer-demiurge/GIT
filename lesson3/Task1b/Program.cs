using System;

//ЗАДАНИЕ 1 b
//Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса;
//Сержов Михаил


class Complex
{
    // Все методы и поля публичные. Мы можем получить доступ к ним из другого класса.
    public double im;
    public double re;

    public Complex Plus(Complex x2)
    {
        Complex x3 = new Complex();
        x3.im = x2.im + this.im;     //В методичке неправильно! для суммы не критично расположение, но в вычитании даст ошибку.
        x3.re = this.re + x2.re;     //Правильно вот так.
        return x3;
    }

    //Метод вычитания двух комплексных чисел
    public Complex Minus(Complex x2)
    {
        Complex x3 = new Complex();
        x3.im = this.im - x2.im;
        x3.re = this.re - x2.re;
        return x3;

    }

    //Произведения двух комплексных чисел
    public Complex Multi(Complex x2)
    {
        Complex x3 = new Complex();
        x3.re = this.re * x2.re - this.im * x2.im;
        x3.im = this.re * x2.im + this.im * x2.re;
        return x3;
    }

    public string ToString()
    {
            if (im < 0) return re + "-" + (- im) + "i;";
            else return re + "+" + im + "i";
        }
}

class Program
{
    static void Main(string[] args)
    {
        Complex complex1 = new Complex();
        complex1.re = 1;
        complex1.im = 1;

        Complex complex2 = new Complex();
        complex2.re = 2;
        complex2.im = 2;

        Complex result = complex1.Plus(complex2);
        Console.WriteLine(result.ToString());
        result = complex1.Minus(complex2);
        Console.WriteLine(result.ToString());
        result = complex1.Multi(complex2);
        Console.WriteLine(result.ToString());
    }
}


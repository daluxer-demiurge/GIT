using System;

//ЗАДАНИЕ 1 a
//Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры;
//Сержов Михаил



struct Complex
{
    public double im;
    public double re;
    //  в C# в структурах могут храниться также действия над данными
    public Complex Plus(Complex x)
    {
        Complex y;
        y.im = im + x.im;
        y.re = re + x.re;
        return y;
    }
    //  Пример произведения двух комплексных чисел
    public Complex Multi(Complex x)
    {
        Complex y;
        y.im = re * x.im + im * x.re;
        y.re = re * x.re - im * x.im;
        return y;
    }

    //Метод вычитания двух комплексных чисел
    public Complex Minus(Complex x)
    {
        Complex y;
        y.im = im - x.im;
        y.re = re - x.re;
        return y;
    }
    public string ToString()
    {
        if (im < 0) return re + "-" + (-im) + "i";
        else return re + "+" + im + "i";
    }
}
class Program
{
    static void Main(string[] args)
    {
        Complex complex1;
        complex1.re = 1;
        complex1.im = 1;

        Complex complex2;
        complex2.re = 2;
        complex2.im = 2;
               
        Complex result = complex1.Plus(complex2);
        Console.WriteLine(result.ToString());
        result = complex1.Multi(complex2);
        Console.WriteLine(result.ToString());
        result = complex1.Minus(complex2);
        Console.WriteLine(result.ToString());

    }
}



using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(6);
        Fraction f3 = new Fraction(6, 7);

        Console.WriteLine($"{f1.GetTop()} {f1.GetBottom()}");
        Console.WriteLine($"{f2.GetTop()} {f2.GetBottom()}");
        Console.WriteLine($"{f3.GetTop()} {f3.GetBottom()}");

        f1.SetTop(4);
        f1.SetBottom(3);

        Console.WriteLine($"{f1.GetTop()} {f1.GetBottom()}");

        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetFractionValue());

        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetFractionValue());

    }
}
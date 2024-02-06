using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFraction());
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction(6);
        Console.WriteLine(f2.GetFraction());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(6,7);
        Console.WriteLine(f3.GetFraction());
        Console.WriteLine(f3.GetDecimalValue());

        Fraction f4 = new Fraction();
        f4.SetTopFraction();
        f4.SetBottomFraction();
        Console.WriteLine(f4.GetFraction());
        Console.WriteLine(f4.GetDecimalValue());
    }
}
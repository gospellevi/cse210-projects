using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning03 World!");

        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        Fraction fraction2 = new Fraction(6);
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        Fraction fraction3 = new Fraction(6, 7);
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());

        // fraction1.Display();
        // fraction2.Display();
        // fraction3.Display();

        // fraction2.SetTop(1);
        // fraction2.SetBottom(1);

        // Console.WriteLine(fraction2.GetTop() + "/" + fraction2.GetBottom());
    }

}
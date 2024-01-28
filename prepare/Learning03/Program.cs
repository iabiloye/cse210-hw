using System;

class Program
{
    static void Main()
    {
        // Create instances of Fraction using different const.
        Fraction fraction1 = new Fraction(1);       // 1
        Fraction fraction2 = new Fraction(5);      // 5
        Fraction fraction3 = new Fraction(3, 4);   // 3/4
        Fraction fraction4 = new Fraction(1, 3);   // 1/3

        // Display representations of fractions
        DisplayFraction(fraction1);
        DisplayFraction(fraction2);
        DisplayFraction(fraction3);
        DisplayFraction(fraction4);
    }

    static void DisplayFraction(Fraction fraction)
    {
        // Display the fraction and its decimal value
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetDecimalValue());
        Console.WriteLine();
    }
}

// using System;
public class Fraction
{
    private int numerator;
    private int denominator;

    // Constr. with no par., initializes the fraction to 1/1 call automatically when an object is created
    public Fraction()
    {
        numerator = 1;
        denominator = 1;
    }

    // Constr. with one par. for the top, initializes the den. to 1
    public Fraction(int top)
    {
        numerator = top;
        denominator = 1;
    }

    // Constr. with two par. for the top and the bottom
    public Fraction(int top, int bottom)
    {
        numerator = top;
        denominator = bottom;
    }

    // Getters and setters for num. and den. :create methods to get and set the value. ensures that the class still controls access to the variables and that the variables themselves are hidden.
    public int GetNumerator() => numerator;
    public int GetDenominator() => denominator;
    public void SetNumerator(int top) => numerator = top;
    public void SetDenominator(int bottom) => denominator = bottom;

    // Mtd to return the fract. rep.
    public string GetFractionString() => $"{numerator}/{denominator}";

    // Mtd(member functions) to return the decimal 
    public double GetDecimalValue() => (double)numerator / denominator;
}

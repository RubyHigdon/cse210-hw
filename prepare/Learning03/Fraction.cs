using System.Data;
using System.Transactions;

public class Fraction
{
    private int _top;
    private int _bottom;
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    public int SetTopFraction()
    {
        Console.Write("Enter the numerator: ");
        _top = int.Parse(Console.ReadLine());
        return _top;
    }
    public int SetBottomFraction()
    {
        Console.Write("Enter the denominator: ");
        _bottom = int.Parse(Console.ReadLine());
        return _bottom;
    }
    public string GetFraction()
    {
        string fraction = $"{_top}/{_bottom}";
        return fraction;
    }
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}
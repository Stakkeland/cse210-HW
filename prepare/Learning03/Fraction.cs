using System;

class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int _top)
    {
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionString()
    {//returns fraction string
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {//returns double or float that results in the fraction division
        return (double)_top / (double)_bottom;
    }
}
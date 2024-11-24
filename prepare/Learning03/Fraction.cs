using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    // Constructions
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
    
    // Setters
    public void SetTop(int top)
    {
        _top = top;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }
    // Getters
    public string GetTop()
    {
        return _top.ToString();
    }

    public string GetBottom()
    {
        return  _bottom.ToString();
    }
   
    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }
    public double GetDecimalValue()
    {
        return (double)_top/(double)_bottom;
    }
}
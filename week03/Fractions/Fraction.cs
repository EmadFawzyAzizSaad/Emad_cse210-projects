public class Fraction
{
    private int _top;  // privte variable for the numerator
    private int _bottom; // private variable for the denominator

    // first constructor
    public Fraction()  
    {
        _top = 1;
        _bottom = 1;
    }
    // second constructor
    // It asks for only one number (numerator) and the denominator is automatically 1.
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    // third constructor
    // It asks for both the numerator and denominator.
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
// Guards top number
    public int GetTop()
    {
        return _top;
    }
    public void SetTop(int top)
    {
        _top = top;
    }

    // Guards bottom number
    public int GetBottom()
    {
        return _bottom;
    }   
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }
    // A function that returns the fraction as text.
    public string GetFractionString()
    {
        string text = _top +"/"+ _bottom;
        return text;
    }
    // A function that divides the numerator by the denominator and returns a decimal number.
    public double GetDecimalValue()
    {
        
        return (double)_top / (double)_bottom;
    }

}
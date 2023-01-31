public class Fractions
{
    //Attributes created
    private int _top;
    private int _bottom;

//-----------------------Constructors-----------------------
//    public Fractions()
//    {
//        _top = 1;
//        _bottom = 1;

//        Console.WriteLine($"{_top}/{_bottom}");
//    }

//    public Fractions(int top)
//    {
//        _top = top;
//        _bottom = 1;

//        Console.WriteLine($"{_top}/{_bottom}");
//    }

//    public Fractions(int top, int bottom)
//    {
//        _top = top;
//        _bottom = bottom;

//        Console.WriteLine($"{_top}/{_bottom}");
//    }


//-----------------------Setters & Getters-----------------------
    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

        public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public void GetFractionString(int _top, int _bottom)
    {
        Console.WriteLine($"{_top}/{_bottom}");
    }

    public void GetDecimalValue(double _top, double _bottom)
    {
        double value = _top/_bottom;
        Console.WriteLine($"{value}");
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> _list = new List<Shape>{};

        Square sq = new Square("black", 4);
        Rectangle rec = new Rectangle("red",4,5);
        _list.Add(sq);
        _list.Add(rec);

    }
}
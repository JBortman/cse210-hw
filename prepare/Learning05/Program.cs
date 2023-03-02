using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> _list = new List<Shape>{};

        Square sq = new Square("black", 4);
        _list.Add(sq);

    }
}
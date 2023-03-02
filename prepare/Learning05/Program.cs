using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> _list = new List<Shape>{};

        Square sq = new Square("Black", 4);
        Rectangle rec = new Rectangle("Red",4,5);
        Circle cir = new Circle("Yellow",3);
        _list.Add(sq);
        _list.Add(rec);
        _list.Add(cir);

        foreach (Shape i in _list){
        Console.WriteLine(i.GetColor());
        Console.WriteLine(i.GetArea());
        Console.WriteLine();
        }

    }
}
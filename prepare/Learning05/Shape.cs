public class Shape {
    string _color;

    public string GetColor(string v)
    {
        return _color;
    }

    public Shape(string color){
        _color = color;
    }

    public virtual double GetArea() {
        return 0;
    }
}
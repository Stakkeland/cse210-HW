public class Rectangle : Shape
{
    //varibales
    private double _length;
    private double _width;

    //constructor
    public Rectangle(string color) : base(color)
    {

    }

    //functions
    public override double GetArea()
    {
        return _length * _width;
    }
}
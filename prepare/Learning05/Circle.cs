public class Circle : Shape
{
    //varibales
    private double _radius;

    //constructor
    public Circle(string color) : base(color)
    {

    }

    //functions
    public override double GetArea()
    {
        return 3.14 * (_radius * 2);
    }
}
public class Square : Shape
{
    //varibales
    private double _side;

    //functions
    public override double GetArea()
    {
        return _side * _side;
    }
}
public class Shape
{
    //variables
    private string _color;

    //constructor
    Shape(string color)
    {
        _color = color;
    }

    //functions
    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        color = _color;
    }

    public virtual double GetArea()
    {
        return 10;
    }
}
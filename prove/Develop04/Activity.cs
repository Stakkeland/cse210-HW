
class Activity
{
    //attributes
    protected string _name;
    protected string _description;
    protected int _duration;

    //constructor
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    //methods
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}."
        + " "
        + $"{_description}"
        + " "
        + "How long in seconds, would you like for your sesion? ");
    }
    public void DisplayEndingMessage()
    {
        
    }
    public void ShowSpinner()
    {
        
    }
    public void ShowCountDown()
    {
        
    }

}

class BreathingActivity : Activity
{

    //constructor
    public BreathingActivity(string name, string description, int duration) : base(name,description,duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    //methods
    public void Run()
    {
        DisplayStartingMessage();
        string answerInText = Console.ReadLine();
        _duration = int.Parse(answerInText);

    }
    
}
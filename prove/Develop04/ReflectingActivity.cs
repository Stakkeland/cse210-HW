
class ReflectingActivity : Activity
{
    //attributes
    private List<string> _prompts;
    private List<string> _questions;

    //constructor
    public ReflectingActivity(List<string> prompts, List<string> questions, string name, string description, int duration) : base(name, description,duration)
    {
        _prompts = prompts;
        _questions = questions;
    }

    //methods
    public void Run()
    {

    }
    public string GetRandomPrompt()
    {
        return " ";
    }
    public string GetRandomQuestion()
    {
        return " ";
    }
    public void DisplayPrompt()
    {

    }
    public void DisplayQuestions()
    {

    }
    
}
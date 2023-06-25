
class ListingActivity : Activity
{
    //attributes
    private int _count;
    private List<string> _prompts;

    //constructor
    public ListingActivity(int count, List<string> prompts, string name, string description, int duration) : base(name, description, duration)
    {
        _count = count;
        _prompts = prompts;
    }

    //methods
    public void Run()
    {

    }
    public void GetRandomPrompt()
    {
        
    }
    public void GetListFromUser() //List<string>
    {

    }
    
}
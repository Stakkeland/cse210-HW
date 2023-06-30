
class ListingActivity : Activity
{
    //attributes
    private int count;
    private List<string> prompts;
    private List<string> answers;

    //constructor
    public ListingActivity()
    {

        this.SetActivityName("Listing Activity");
        this.SetDescription("This activity will help you reflect on the good things in your life by having you" +
        "list as many things as you can in a certain area.");

        prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
        };

        answers = new List<string>
        {

        };
    }

    //methods
    public void Run()
    {
        DisplayStartingMessage();
        int timer = GetDuration();
        Console.WriteLine("List as many responses you can to the following prompt:");
        DisplayPrompt();
        Console.WriteLine("You may begin in:");
        ShowCountDown(5);

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(timer);
        Thread.Sleep(2000);
        DateTime currentTime = DateTime.Now;

        while (currentTime < futureTime)
        {
            Console.WriteLine(">");
            string newAnswer = Console.ReadLine();
            answers.Add(newAnswer);
            currentTime = DateTime.Now;
        }

        count = answers.Count();
        Console.WriteLine($"You listed {count} items!");
        Console.WriteLine(" ");

        DisplayEndingMessage();

    }
    public string GetRandomPrompt()
    {
        string randomPrompt = "";
        int randomIndex = new Random().Next(prompts.Count);

        randomPrompt = prompts[randomIndex];

        return randomPrompt;
    }
    public void DisplayPrompt()
    {
        string prompt = new ReflectingActivity().GetRandomPrompt();
        Console.WriteLine($"---{prompt}---");
    }
    public void GetCount()
    {

    }
    
}

class ReflectingActivity : Activity
{
    //attributes
    private List<string> prompts;
    private List<string> questions;

    //constructor
    public ReflectingActivity() 
    {
        this.SetActivityName("Reflecting Activity");
        this.SetDescription("This activity will help you reflect on times in your life when" +
        "you have shown strength and resilience. This will help you recognize the power" +
        "you have and how you can use it in other aspects of your life.");

         prompts = new List<string>
        {
            "Think of a time you did something very difficult",
            "Ponder on your greatest triumph",
            "Think of the importance of your family",
            "Ponder on your greatest failure",
            "Think of how you could be better",
            "Ponder on a time you felt best about yourself",
        };

         questions = new List<string>
        {
            "How did you feel about this experience",
            "what is your favorite things about this experience",
            "How would you be different without this experience",
            "How have you grown from this",
            "What got you to accomplish/experience this?",
        };
    }

    //methods
    public void Run()
    {
        DisplayStartingMessage();
        int interval = GetDuration();
        DisplayPrompt();
        DisplayQuestions(interval);
        DisplayEndingMessage();
    }
    public string GetRandomPrompt()
    {
        string randomPrompt = "";
        int randomIndex = new Random().Next(prompts.Count);

        randomPrompt = prompts[randomIndex];


        return randomPrompt;
    }
    public string GetRandomQuestion()
    {
        string randomQuestion = "";
        int randomIndex = new Random().Next(questions.Count);

        randomQuestion = questions[randomIndex];


        return randomQuestion;
    }
    public void DisplayPrompt()
    {
        string userInput = "no";

        Console.WriteLine("Consider the following prompt:");
        string prompt = new ReflectingActivity().GetRandomPrompt();
        Console.WriteLine($"---{prompt}---");

        while (userInput != "continue")
        {
            Console.WriteLine("When you have something in mind, type continue to move on.");
            userInput = Console.ReadLine();
        }
    }
    public void DisplayQuestions(int time)
    {
        Console.WriteLine("Now ponder on each of the following questions as they relate to the experience.");
        Console.WriteLine("You may begin in:");
        ShowCountDown(3);

        while (time > 0)
        {
            string question = new ReflectingActivity().GetRandomQuestion();
            Console.WriteLine($">{question}");
            ShowSpinner(5);

            time -= 5;
        }
    }
    
}
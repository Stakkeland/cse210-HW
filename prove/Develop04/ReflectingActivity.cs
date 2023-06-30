
class ReflectingActivity : Activity
{
    //attributes
    private List<string> prompts;
    private List<string> questions;

    //constructor
    public ReflectingActivity() 
    {
        this.SetActivityName("Reflecting Activity");
        string multiline = 
        @"This activity will help you reflect on times in your life when
you have shown strength and resilience. This will help you recognize the power
you have and how you can use it in other aspects of your life.";
        this.SetDescription(multiline);

        prompts = new List<string>
        {
            "Think of a time you did something very difficult",
            "Ponder on your greatest triumph",
            "Think of the importance of your family",
            "Ponder on your greatest failure",
            "Think of a time when you did something really difficult.",
            "Think of a time when you stood up for someone else.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
        };

        questions = new List<string>
        {
            "How did you feel about this experience",
            "what is your favorite things about this experience",
            "How would you be different without this experience",
            "How have you grown from this",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?",
        };
    }

    //methods
    public void Run()
    {
        DisplayStartingMessage();
        int timer = GetDuration();
        DisplayPrompt();
        DisplayQuestions(timer);
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
        string prompt = GetRandomPrompt();
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
            string question = GetRandomQuestion();
            Console.WriteLine($">{question}");
            ShowSpinner(5);

            time -= 5;
        }
    }
    
}
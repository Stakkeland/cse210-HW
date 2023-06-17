
class Prompts
{
    List<string> prompts;

    public Prompts()
    {
        prompts = new List<string>
        {
            "Who was the most interesting person I intereacted with today?",
            "What was ther best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "How have you accomplished your dreams today?",
            "What was your best family moment today?",
            "How did you stay healthy today?",
        };
    }

    public string GetRandomPrompt()
    {
        string randomPrompt = "";
        int randomIndex = new Random().Next(prompts.Count);

        randomPrompt = prompts[randomIndex];


        return randomPrompt;
    }
}
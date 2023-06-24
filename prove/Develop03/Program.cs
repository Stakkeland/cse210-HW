using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";
        Reference _reference = new Reference("1st Nephi", 1, 12);
        Scripture scripture = new Scripture(_reference, "And it came to pass that as he read, he was filled with the Spirit of the Lord.");
        List<int> usedNums = new List<int>();
        
        while (userInput != "quit")
        {
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish");
            userInput = Console.ReadLine();
            scripture.HideRandomWords();
            scripture.IsCompletelyHidden();
        }
    }
}
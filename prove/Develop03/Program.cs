using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";
        Reference _reference2 = new Reference("Proverbs", 3, 5, 2, 6);
        Scripture scripture2 = new Scripture(_reference2, "Trust in the lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.");

        Reference _reference = new Reference("1st Nephi", 1, 12);
        Scripture scripture = new Scripture(_reference, "And it came to pass that as he read, he was filled with the Spirit of the Lord.");
        while (userInput != "quit")
        {
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish");
            userInput = Console.ReadLine();
            scripture.HideRandomWords();

        }
    }
}
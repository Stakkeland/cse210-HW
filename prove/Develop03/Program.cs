using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";
        Reference _reference = new Reference("Proverbs", 3, 5, 2, 6);
        Scripture scripture = new Scripture(_reference, "Trust in the lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.");

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
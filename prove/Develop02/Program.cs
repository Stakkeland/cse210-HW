using System;

class Program
{
    static void Main(string[] args)
    {
        int answer = 0;
        Journal journal = new Journal();
        while (answer != 5)
        {
            string multiline = @"Please select one of the following:
            1.Write new entry
            2.Display journal
            3.Save
            4.Load journal
            5.Quit
            What would you like to do? ";
            Console.WriteLine(multiline);
            string answerInText = Console.ReadLine();
            answer = int.Parse(answerInText);

            if (answer == 1)
            {
                string prompt = new Prompts().GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");
                string response = Console.ReadLine();
                string date = DateTime.Now.Date.ToString("MMM dd, yyyy");

                Entry entry = new Entry(date, prompt, response);
                journal.AddEntry(entry);
            }
            else if (answer == 2)
            {
                journal.DisplayAll();
            }
            else if (answer == 3)
            {
                Console.WriteLine("Name of file to load?");
                string fileName = Console.ReadLine();
                journal.LoadFromFile(fileName);
            }
            else if (answer == 4)
            {
                Console.WriteLine("Name of file to save?");
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
            }
            else if (answer == 5)
            {
                return;
            }
            else 
            {
                Console.WriteLine("Sorry that is not an option please try again.");
            }
        }
    }
}
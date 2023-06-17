using System;

class Program
{
    static void Main(string[] args)
    {
        int answer = 0;
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
                return;
            }
            else if (answer == 2)
            {
                //journal class
                return;
            }
            else if (answer == 3)
            {
                //journal class
                return;
            }
            else if (answer == 4)
            {
                //journal class
                return;
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
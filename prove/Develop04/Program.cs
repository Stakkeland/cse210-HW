using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput = " ";
        string multiline = 
        @"Menu Options:
        1.Start breathing activity
        2.Start reflecting activity
        3.Start listing activity
        4.Quit
        Select a choice from the menu:";
        
        while (userInput != "4")
        {
            Console.Clear();
            Console.WriteLine(multiline);
            userInput = Console.ReadLine();

            if (userInput == "1")
            {
                BreathingActivity bl1 = new BreathingActivity();
                bl1.Run();
            }

            else if (userInput == "2")
            {
                break;
            }

            else if (userInput == "3")
            {
                break;
            }

            else if (userInput == "4")
            {
                Console.WriteLine("Goodbye!");
            }

            else
            {
                break;
            }
        }
    }
}
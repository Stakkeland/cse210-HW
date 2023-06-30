using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput = " ";
        string multiline = 
        @"Menu Options:
        1.Start Breathing Activity
        2.Start Reflecting Activity
        3.Start Listing Activity
        4.Quit
        Select a choice from the menu:";
        
        while (userInput != "4")
        {
            Console.Clear();
            Console.WriteLine(multiline);
            userInput = Console.ReadLine();
            Console.Clear();

            if (userInput == "1")
            {
                
                BreathingActivity ba1 = new BreathingActivity();
                ba1.Run();
            }

            else if (userInput == "2")
            {
                ReflectingActivity ra1 = new ReflectingActivity();
                ra1.Run();
            }

            else if (userInput == "3")
            {
                ListingActivity la1 = new ListingActivity();
                la1.Run();
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
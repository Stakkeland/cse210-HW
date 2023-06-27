using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput = " ";
        
        while (userInput != "4")
        {
            Console.WriteLine("Menu Options:"
            + "1.Start breathing activity"
            + "2.Start reflecting activity"
            + "3.Start listing activity"
            + "4.Quit"
            + "Select a choice from the menu: ");
            userInput = Console.ReadLine();

            if (userInput == "1")
            {
                BreathingActivity bl1 = new BreathingActivity("Breathing Activity", "This activitiy will help you relax by walking you through breathing in and out slowly", 30);
                bl1.Run();
            }

            else if (userInput == "2")
            {
                //ReflectingActivity rl1 = new ReflectingActivity("Breathing Activity", "This activitiy will help you relax by walking you through breathing in and out slowly", 30);
            }

            else if (userInput == "3")
            {
                //ListingActivity ll1 = new ListingActivity("Breathing Activity", "This activitiy will help you relax by walking you through breathing in and out slowly", 30);
            }

            else if (userInput == "4")
            {
                Console.WriteLine("Goodbye!");
            }

            else
            {
                
            }
        }
    }
}
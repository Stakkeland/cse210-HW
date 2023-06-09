using System;

class Program
{
     static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("What is your name? ");
        string userName = Console.ReadLine();

        return userName;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number: ");
        string numInText = Console.ReadLine();
        int userNumber = int.Parse(numInText);

        return userNumber;
    }

    static int SquareNumber(int first)
    {
        int square = first * first;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}
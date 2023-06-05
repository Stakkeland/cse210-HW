using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradeInText = Console.ReadLine();
        int grade = int.Parse(gradeInText);


        if (grade >= 90)
        {
            Console.WriteLine("You have an A");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("You have a B");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("You have a C");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("You have a D");
        }
        else
        {
            Console.WriteLine("You have an F");
        }

        
        if (grade >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}
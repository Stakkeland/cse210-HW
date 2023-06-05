using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int num = randomGenerator.Next(1, 101);

        int guess = 0;

        while (guess != num)
        {
            Console.WriteLine("What is your guess? ");
            string guessInText = Console.ReadLine();
            guess = int.Parse(guessInText);

            if (guess == num)
            {
                Console.WriteLine("You guessed it!");
            }
            else if (guess > num)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Higher");
            }
        }

    }

}
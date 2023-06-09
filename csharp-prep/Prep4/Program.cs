using System;

class Program
{
    static void Main(string[] args)
    {
        double num = 1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<double> numbers = new List<double>();

        while (num != 0)
        {
            Console.WriteLine("Enter number: ");
            string guessInText = Console.ReadLine();
            num = int.Parse(guessInText);

            numbers.Add(num);

        }
        
        //pop 0 off
        numbers.RemoveAt(numbers.Count - 1);

        //sum
        double sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");

        //average
        double average = numbers.Average();
        Console.WriteLine($"The average is: {average}");

        //largest
        double max = numbers.Max();
        Console.WriteLine($"The largest number is: {max}");

    }
}
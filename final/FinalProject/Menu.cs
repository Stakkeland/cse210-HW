public class Menu
{
    private int _largeB;
    private int _smallB;

    public Menu()
    {

    }

    public void Run()
    {
        string userInput = " ";

        string multiline = 
        @"Killian Korn Ship Aide:
        1.Use
        2.Exit
        >";
        

        while (userInput != "2")
        {

            Console.Clear();
            Console.Write(multiline);
            userInput = Console.ReadLine();

            if (userInput != "2")
            {
                Console.Clear();
                Console.WriteLine("Enter Bag Amount");
                Console.Write("11 oz bag quantity >");
                int largeBString = Convert.ToInt32(Console.ReadLine());
                _largeB = largeBString;
                Console.Write("5 oz bag quantity >");
                int smallBString = Convert.ToInt32(Console.ReadLine());
                _smallB = smallBString;
            }

            else
            {
                return;
            }


        }
    }

    public int GetLargeB()
    {
        return _largeB;
    }
    public int GetSmallB()
    {
        return _smallB;
    }
}
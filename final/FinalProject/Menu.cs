public class Menu 
{
    protected int _largeB;
    protected int _smallB;

    public Menu(int largeB, int smallB)
    {
        _largeB = largeB;
        _smallB = smallB;
    }

    public void Run()
    {
        string userInput = " ";

        string multiline = 
@"

Killian Korn Ship Aide:
-Press Enter to start
-Type 'quit' to end
>";
        

        while (userInput != "quit")
        {

            Console.Write(multiline);
            userInput = Console.ReadLine();

            if (userInput != "quit")
            {
                Console.Clear();
                Console.WriteLine("Enter Bag Amount");
                Console.Write("11 oz bag quantity >");
                int largeBString = Convert.ToInt32(Console.ReadLine());
                _largeB = largeBString;
                Console.Write("5 oz bag quantity >");
                int smallBString = Convert.ToInt32(Console.ReadLine());
                _smallB = smallBString;

                Formula f1 = new Formula(_largeB, _smallB);
                f1.GetBags();
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
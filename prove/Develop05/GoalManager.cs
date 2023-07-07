public class GoalManager
{
    //variables
    private List<Goal> _goals;
    private int _score;

    //constructor
    public GoalManager()
    {

    }

    //methods
    public void Start()
    {
        string userInput = " ";

        string multiline = 
        @"Menu Options:
        1.Create New Goal
        2.List Goals
        3.Save Goals
        4.Load Goals
        5.Record Event
        6.Quit
        Select a choice from the menu:";
        

        while (userInput != "6")
        {
            Console.Clear();
            Console.WriteLine($"You have {_score} points.");
            Console.WriteLine(" ");
            Console.WriteLine(multiline);
            userInput = Console.ReadLine();
            
            if (userInput == "1")
            {
                string userInputGoal = " ";
                string multiline1 = 
                @"Menu Options:
                1.Simple Goal
                2.Eternal Goal
                3.Checklist Goal
                Which type of goal would you like to create?: ";

                Console.WriteLine(multiline1);
                userInputGoal = Console.ReadLine();
                Console.WriteLine("What is the name of your goal?");
                string usN = Console.ReadLine();
                Console.WriteLine("What is a short description of it?");
                string usD = Console.ReadLine();
                Console.WriteLine("What is the amount of point associated with this goal?");
                string usP = Console.ReadLine();

                if (userInputGoal == "1")
                {
                    SimpleGoal sg1 = new SimpleGoal(usN, usD, usP);
                    sg1.RecordEvent();

                }
                else if (userInputGoal == "2")
                {
                    
                }
                else if (userInputGoal == "3")
                {
                    
                }

            }

            else if (userInput == "2")
            {
                
            }

            else if (userInput == "3")
            {

            }

            else if (userInput == "4")
            {

            }

            else if (userInput == "5")
            {

            }

            else if (userInput == "6")
            {
                break;
            }

            else
            {
                break;
            }
        }
    }
    public void DisplayPlayerInfo()
    {
        
    }
    public void ListGoalNames()
    {
        
    }
    public void ListGoalDetails()
    {
        
    }
    public void CreateGoal()
    {
        
    }
    public void RecordEvent()
    {
        
    }
    public void SaveGoals()
    {
        
    }
    public void LoadGoals()
    {
        
    }

}
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
            Console.WriteLine($"You have {_score} points.");
            Console.WriteLine(" ");
            Console.Write(multiline);
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

                Console.Write(multiline1);
                userInputGoal = Console.ReadLine();
                Console.Write("What is the name of your goal?");
                string usN = Console.ReadLine();
                Console.Write("What is a short description of it?");
                string usD = Console.ReadLine();
                Console.Write("What is the amount of point associated with this goal?");
                string usP = Console.ReadLine();

                if (userInputGoal == "1")
                {
                    SimpleGoal sg1 = new SimpleGoal(usN, usD, usP, false);
                    sg1.RecordEvent();

                }
                else if (userInputGoal == "2")
                {
                    EternalGoal eg1 = new EternalGoal(usN, usD, usP);
                    eg1.RecordEvent();
                }
                else if (userInputGoal == "3")
                {
                    Console.Write("What is the target amount of times to accomplish this goal?");
                    int usT = Convert.ToInt32(Console.ReadLine());
                    Console.Write("What is the amount of bonus points for accomplishing this goal?");
                    int usB = Convert.ToInt32(Console.ReadLine());

                    ChecklistGoal cg1 = new ChecklistGoal(usN, usD, usP, usT, usB);
                    cg1.RecordEvent();
                }

            }

            else if (userInput == "2")
            {
                GoalManager gmdetail = new GoalManager();
                gmdetail.ListGoalDetails();
            }

            else if (userInput == "3")
            {
                GoalManager gmsave = new GoalManager();
                gmsave.SaveGoals();
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
        Console.WriteLine("The goals are:");
        string filename = "points.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string name = parts[0];
            string description = parts[1];
            string target = parts[4];
            bool present = target.Contains(" ");
            if (present == true)
            {
                Console.WriteLine($"- [ ] {name} ({description})");
            }
            else
            {
                Console.WriteLine($"- [ ] {name} ({description}) -- Currently completed: 0/{target}");
            }

        }


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
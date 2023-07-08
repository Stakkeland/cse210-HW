using System.IO; 
public class GoalManager
{
    //variables
    private List<Goal> _goals;
    private string _score;
    private string[] lines2;

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
            lines2 = System.IO.File.ReadAllLines(@"C:\Users\Sawyer Stakkeland\OneDrive\Documents\BYUI\2023 Spring\Classes\cse210-HW\prove\Develop05\pointcounter.txt");
            string convertedscore = lines2[0].ToString();
            _score = convertedscore;
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

                    ChecklistGoal cg1 = new ChecklistGoal(usN, usD, usP, usT, usB, 0);
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
                GoalManager gmload = new GoalManager();
                gmload.LoadGoals();
            }

            else if (userInput == "5")
            {
                GoalManager gmrecord = new GoalManager();
                gmrecord.RecordEvent();
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
            string completions = parts[4];
            string target = parts[5];
            bool present = target.Contains("placeholder");
            if (present == true)
            {
                Console.WriteLine($"- [ ] {name} ({description})");
            }
            else
            {
                Console.WriteLine($"- [ ] {name} ({description}) -- Currently completed: {completions}/{target}");
            }

        }


    }
    public void CreateGoal()
    {
        
    }
    public void RecordEvent()
    {
        string recordedevent;

        Dictionary<string,string> addingPoints = new Dictionary<string,string>();

        Console.WriteLine("The goals are:");
        string filename = "points.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string name = parts[0];
            string points = parts[2];
            string completions = parts[4];
            addingPoints.Add(name, points);

            Console.WriteLine($"- {name}");
        }

        Console.Write("What goal do you want to accomplish?");
        recordedevent = Console.ReadLine();

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string name = parts[0];
            string completions = parts[4];
            if (completions == "placeholder")
            {
                
            }
            else
            {
                int completionsInt = Convert.ToInt32(completions);

                if (name == recordedevent)
                {
                    int  newCompletions = completionsInt + 1;
                    string convertedCompletions = newCompletions.ToString();
                    //string text = File.ReadAllText("points.txt");
                    //line.Replace(completions, convertedCompletions);
                    //File.WriteAllText(@"C:\Users\Sawyer Stakkeland\OneDrive\Documents\BYUI\2023 Spring\Classes\cse210-HW\prove\Develop05\points.txt", line);

                    string str = File.ReadAllText(@"C:\Users\Sawyer Stakkeland\OneDrive\Documents\BYUI\2023 Spring\Classes\cse210-HW\prove\Develop05\points.txt");
                    str = str.Replace(completions,convertedCompletions);
                    File.WriteAllText(@"C:\Users\Sawyer Stakkeland\OneDrive\Documents\BYUI\2023 Spring\Classes\cse210-HW\prove\Develop05\points.txt", str);
                }
            }
        }

        foreach(KeyValuePair<string, string> ele1 in addingPoints)
        {
            if (recordedevent == ele1.Key)
            {
                string beforeParse = ele1.Value;
                int addedpoints = Convert.ToInt32(beforeParse);

                string[] lines1 = System.IO.File.ReadAllLines(@"C:\Users\Sawyer Stakkeland\OneDrive\Documents\BYUI\2023 Spring\Classes\cse210-HW\prove\Develop05\pointcounter.txt");
                int convertedpointcounter = Convert.ToInt32(lines1[0]);
                int finalnum = addedpoints + convertedpointcounter;
                string myString = finalnum.ToString();
                lines1[0] = myString;
                System.IO.File.WriteAllLines(@"C:\Users\Sawyer Stakkeland\OneDrive\Documents\BYUI\2023 Spring\Classes\cse210-HW\prove\Develop05\pointcounter.txt", lines1);

                Console.WriteLine();
                Console.WriteLine($"Congratulations! you have earned {addedpoints} points");
            }
        }
    }
    public void SaveGoals()
    {
        Console.Write("You have saved your goals");
    }
    public void LoadGoals()
    {
        Console.Write("You have loaded your goals");
    }

}
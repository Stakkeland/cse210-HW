using System.IO; 
public class ChecklistGoal : Goal
{
    //variables
    private int _target;
    private int _bonus;
    private int _completions;

    //constructor
    public ChecklistGoal(string name, string description, string points, int target, int bonus, int completions) : base(name, description,points)
    {
        _target = target;
        _bonus = bonus;
        _completions = completions;
    }

    //methods
    public override void RecordEvent()
    {
        List<string> records = new List<string>();
        string entryAsCSV = ($"{GetName()}|{GetDescription()}|{GetPoints()}|false|{_completions}|{_target}|{_bonus}");
        records.Add(entryAsCSV);


        File.AppendAllLines(@"C:\Users\Sawyer Stakkeland\OneDrive\Documents\BYUI\2023 Spring\Classes\cse210-HW\prove\Develop05\points.txt", records);
    }

    public void CompleteChecklist()
    {
        string filename = "points.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string checklistGoalCounter = parts[5];
            string checklistGoalTotal = parts[6];
            string bonusPoints = parts[7];

            if (checklistGoalCounter == "placeholder")
            {
                return;
            }
            else if (checklistGoalTotal == "placeholder")
            {
                return;
            }
            else
            {
                int cgc = Convert.ToInt32(checklistGoalCounter);
                int cgt = Convert.ToInt32(checklistGoalTotal);
                int bp = Convert.ToInt32(bonusPoints);
                if (cgc < cgt)
                {
                    return;
                }
                else if (cgc == cgt)
                {
                    string str1 = File.ReadAllText(@"C:\Users\Sawyer Stakkeland\OneDrive\Documents\BYUI\2023 Spring\Classes\cse210-HW\prove\Develop05\points.txt");
                    str1 = str1.Replace("[c]","[X]");
                    File.WriteAllText(@"C:\Users\Sawyer Stakkeland\OneDrive\Documents\BYUI\2023 Spring\Classes\cse210-HW\prove\Develop05\points.txt", str1);

                    string[] lines1 = System.IO.File.ReadAllLines(@"C:\Users\Sawyer Stakkeland\OneDrive\Documents\BYUI\2023 Spring\Classes\cse210-HW\prove\Develop05\pointcounter.txt");
                    int convertedpointcounter = Convert.ToInt32(lines1[0]);
                    int finalnum = bp + convertedpointcounter;
                    string myString = finalnum.ToString();
                    lines1[0] = myString;
                    System.IO.File.WriteAllLines(@"C:\Users\Sawyer Stakkeland\OneDrive\Documents\BYUI\2023 Spring\Classes\cse210-HW\prove\Develop05\pointcounter.txt", lines1);
                }
            
            }
        }
    }
    public override bool IsComplete()
    {
        return true;
    }
    public override string GetDetailsString()
    {
        return " ";
    }
    public override string GetStringRepresentation()
    {
        return " ";
    }
}
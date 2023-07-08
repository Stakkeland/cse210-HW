public class ChecklistGoal : Goal
{
    //variables
    private int _target;
    private int _bonus;

    //constructor
    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description,points)
    {
        _target = target;
        _bonus = bonus;
    }

    //methods
    public override void RecordEvent()
    {
        List<string> records = new List<string>();
        string entryAsCSV = ($"{GetName()}|{GetDescription()}|{GetPoints()}|false|{_target}|{_bonus}");
        records.Add(entryAsCSV);


        File.AppendAllLines(@"C:\Users\Sawyer Stakkeland\OneDrive\Documents\BYUI\2023 Spring\Classes\cse210-HW\prove\Develop05\points.txt", records);
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
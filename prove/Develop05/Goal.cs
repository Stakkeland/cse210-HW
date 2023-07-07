public class Goal 
{
    //variables
    private string _shortName;
    private string _description;
    private string _points;

    //constructor
    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    //methods
    public virtual void RecordEvent()
    {
        List<string> records = new List<string>();
        string entryAsCSV = $"{_shortName}|{_description}|{_points}";
        records.Add(entryAsCSV);


        File.WriteAllLines(@"C:\Users\Sawyer Stakkeland\OneDrive\Documents\BYUI\2023 Spring\Classes\cse210-HW\prove\Develop05\points.txt", records);
    }
    public virtual bool IsComplete()
    {
        return true;
    }
    public virtual string GetDetailsString()
    {
        return " ";
    }
    public virtual string GetStringRepresentation()
    {
        return " ";
    }
}
public class ChecklistGoal : Goal
{
    //variables
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    //constructor
    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description,points)
    {
        
    }

    //methods
    public override void RecordEvent()
    {

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
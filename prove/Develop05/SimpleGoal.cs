public class SimpleGoal : Goal
{
    //variables
    private bool _isComplete;

    //constructor
    public SimpleGoal(string name, string description, string points, bool IsComplete) : base(name, description,points)
    {
        IsComplete = _isComplete;
    }

    //methods
    //public override void RecordEvent()
    //{

    //}
    public override bool IsComplete()
    {
        return true;
    }
    public override string GetStringRepresentation()
    {
        return " ";
    }
}
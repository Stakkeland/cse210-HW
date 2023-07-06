public class EternalGoal : Goal
{

    //constructor
    public EternalGoal(string name, string description, string points) : base(name, description,points)
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
    public override string GetStringRepresentation()
    {
        return " ";
    }
}
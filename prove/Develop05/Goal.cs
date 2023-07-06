public class Goal 
{
    //variables
    private string _shortName;
    private string _description;
    private string _points;

    //constructor
    public Goal(string name, string description, string points)
    {

    }

    //methods
    public virtual void RecordEvent()
    {

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
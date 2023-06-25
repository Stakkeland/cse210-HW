
public class MathAssignment : Assignment
{
    //attributes
    private string _textBookSection;
    private string _problems;

    //constructor
    public MathAssignment(string studentName, string topic, string textBookSection, string problems) : base(studentName, topic)
    {
        _textBookSection    = textBookSection;
        _problems           = problems;    
    }

    //methods
    public string GetHomeworkList()
    {
        return ($"Section {_textBookSection} Problems {_problems}");
    }
}

class Reference
{
    //variables
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    

    //constructor
    public Reference (string book, int chapter, int verse)
    {
        _book       = book;
        _chapter    = chapter;
        _verse      = verse;
    }

    public Reference (string book, int chapter, int verse, int startVerse, int endVerse)
    {
        _book       = book;
        _chapter    = chapter;
        _verse      = verse;
        _endVerse   = endVerse;
    }

    //methods
    public string GetDisplayText()
    {
        string _reference = "";

        if (_endVerse != 0)
        {
            _reference = $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
        else
        {
            _reference = $"{_book} {_chapter}:{_verse}";
        }

        return _reference;
    }
}
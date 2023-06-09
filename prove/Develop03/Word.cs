
class Word
{
    //variables
    private string _text;
    public bool _isHidden;

    //constructor
    public Word (string text)
    {
        _text = text;
    }

    //methods
    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        return _text;
    }
}
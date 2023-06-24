
class Scripture
{
    //variables
    private Reference _reference;
    private List<Word> _words;

    //constructor
    public Scripture (Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        List<string> allWords = text.Split(' ').ToList();
        foreach(string wordString in allWords)
        {
            Word newWord = new Word(wordString);
            _words.Add(newWord);
        }
    }

    //methods
    public void HideRandomWords()
    {
        var random = new Random();
        for (int i = 0; i < 3; i++) 
        {
            
        }
        
    }

    public string GetDisplayText()
    {
        string scriptureText = "";

        foreach (Word word in _words)
        {
            if(word.IsHidden() == false)
            {
                scriptureText += word.GetDisplayText() + " ";
            }
            else
            {
                scriptureText += new string('_', word.GetDisplayText().Length) + " ";
            }
        }
        return ($"{_reference.GetDisplayText()} {scriptureText}");
    }

    public bool IsCompletelyHidden()
    {
        return true;
    }
}
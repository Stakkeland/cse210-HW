
class Scripture
{
    //variables
    private Reference _reference;
    private List<Word> _words;
    private List<int> usedNums = new List<int>();

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
            int reloop = 0;
            while (reloop == 0)
            {
                int index = random.Next(_words.Count);

                if (usedNums.Contains(index) == false)
                {
                    _words[index].Hide();
                    usedNums.Add(index);
                    reloop = 1; 
                }
                else
                {
                    reloop = 0;
                }
            }
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
        if (usedNums.Count() == 18)
        {
            Console.Clear();
            return true;
        }
        else
        {
            return false;
        }
    }
}
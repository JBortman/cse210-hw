public class Scripture
{

    private List<string> _words = new List<string>{};
    static List<string> _hiddenWords = new List<string>{};
    private string _text = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";

    //-----Creates the list-----
    public void AddToList()
    {
        string[] split = _text.Split(" ");
        foreach (string i in split)
        {
            _words.Add(i);
        }

    }

    //-----prints full scripture and reference-----
    public void FullScripture()
    {
        Reference r1 = new Reference();
        string refer = r1.FullReference("1 Nephi", 3, 7);
        Console.Clear();
        Console.WriteLine($"{refer} " + string.Join(" ", _words));
    }

    //-----take random words, hides them, and determines if words are still visible-----
    public bool HideWord()
    {
        //Starting Variables and calls
        int _count = 0;
        string ch = "_";
        char[] delimiters = new char[] {' ', '\r', '\n', '_', ':', '.', ','};
        Random _ran = new Random();
        Reference r1 = new Reference();
        string refer = r1.FullReference("1 Nephi", 3, 7);

        //Remove random words and place them in the hidden words list
        while (_count < 5)
        {
            int _index = _ran.Next(_words.Count);
            _hiddenWords.Add(_words[_index]);
            _words[_index] = ch;
            _count++;
        }

        //Word count, once it hits 0 program terminates
        int _wordCount = string.Join(" ", _words).Split(delimiters,StringSplitOptions.RemoveEmptyEntries).Length;

        //Line is written
        Console.Clear();
        Console.WriteLine($"{refer} " + string.Join(" ", _words));

        //Determines whether or not to terminate the program
        if(_wordCount == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    //-----Resets the scripture-----
    public void Reset()
    {
        _words.Clear();
    }

    public List<string> HiddenWordList()
    {
        return _hiddenWords;
    }

}
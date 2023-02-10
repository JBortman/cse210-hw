public class Scripture
{

    private List<string> _words = new List<string>();
    private string _text = "And it came to pass that I, Nephi, said unto my father";

    //-----Creates the lsit-----
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

    //-----take random word and hides it-----
    public void HideWord()
    {
        Random _ran = new Random();
        int _index = _ran.Next(_words.Count);
        _words[_index] = "-";
        Reference r1 = new Reference();
        string refer = r1.FullReference("1 Nephi", 3, 7);
        Console.Clear();
        Console.WriteLine($"{refer} " + string.Join(" ", _words));

    }

}
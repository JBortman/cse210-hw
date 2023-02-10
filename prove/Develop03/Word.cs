public class Word
{

    Scripture hidden = new Scripture();

    public void HiddenList()
    {
        char[] delimiters = new char[] { ' ', '\r', '\n', '_', ':', '.', ',' };
        Console.Clear();
        List<string> _hiddenWords = hidden.HiddenWordList();
        int _wordCount = string.Join(" ", _hiddenWords).Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Length;
        Console.WriteLine($"{_wordCount} words hidden: " + string.Join(" ", _hiddenWords));
    }

    public void ClearList()
    {
        List<string> _hiddenWords = hidden.HiddenWordList();
        _hiddenWords.Clear();
    }

}
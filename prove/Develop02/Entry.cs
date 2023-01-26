public class Entry
{

    public List<string> _entries = new List<string>();
    public string _userInput = "";

    public void JournalEntry()
    {
        PromptGen generate = new PromptGen();
        generate.GenPrompt();
        Console.Write(">");
        _userInput = Console.ReadLine();
        Console.WriteLine(_userInput);
    }

}
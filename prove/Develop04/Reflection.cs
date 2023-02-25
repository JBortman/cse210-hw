public class Reflection : Activity
{

    private List<string> _deepThink = new List<string>{
        "What emotions do you feel with this experience?",
        "Who else was with you at this time?",
        "Is this something you think about often?",
        "How did this change you?",
        "Was the spirit present?",
        "What made you think of this experience?",
        "What did you learn from it?",
        "Have you shared this with anyone else? If not, should you?",
        "How did you feel afterwards?",
        "What led to this experience?"
    };
    private int _questionAmount;
    public Reflection(string activity) : base(activity)
    {
    }
    
    private void GetDeeperPrompt()
    {
        Random _ran = new Random();
        int _index = _ran.Next(_deepThink.Count);
        string _prompt = _deepThink[_index];
        Console.Write($"> {_prompt} ");
    }

    public void Think()
    {
        OneMoment(3);
        Console.WriteLine("Ponder an experience based on the following:");
        Console.WriteLine("");
        Console.Write("---> ");
        Console.WriteLine("");
        Console.WriteLine(GetPrompt());
        Console.Write("Prepare your thoughts, and press enter to begin.");
        Console.ReadLine();
        ThinkActivity();
    }

    public void ThinkActivity()
    {
        _questionAmount = PromptNumber(_activityTime);
        while (_questionAmount > 0)
        {
            GetDeeperPrompt();
            Timer(10);
            Console.WriteLine("");
            _questionAmount--;
        }
    }
}
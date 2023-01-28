public class PromptGen
{

    //Default list options--------------------
    public string GenPrompt()
    {//Manual list
        List<string> _prompts = new List<string> { "Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?" };
        Random _rnd = new Random();
        int _rngIndex = _rnd.Next(_prompts.Count);
        string _random = _prompts[_rngIndex];
        Console.WriteLine(_random);
        return _random;
    }

}
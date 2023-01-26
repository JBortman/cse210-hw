public class PromptGen
{

    //Default list options--------------------
    public void GenPrompt()
    {//Manual list
        List<string> _prompts = new List<string> { "Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?" };
        Random rnd = new Random();
        int rngIndex = rnd.Next(_prompts.Count);
        string random = _prompts[rngIndex];
        Console.WriteLine(random);
    }

}
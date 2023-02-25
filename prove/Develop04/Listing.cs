public class Listing : Activity
{
    private string _prompt;
    private int _total;
    private List<string> _entries = new List<string> { };
    public Listing(string activity) : base(activity)
    {
    }

    public void List()
    {
        OneMoment(3);
        _prompt = GetPrompt();
        Console.WriteLine("Write as many responses as you can to the following prompt:");
        Console.WriteLine("");
        Console.WriteLine($"---> {_prompt}");
        Ready();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_activityTime);
        while (startTime < futureTime)
        {
            Console.Write("> ");
            string _input = Console.ReadLine();
            _entries.Add(_input);
            startTime = DateTime.Now;
            _total++;
        }

        Console.WriteLine($"Time is up! You entered {_total} items!");
        Console.Write("Would you like to view your answers (y/n)? ");
        string _confirm = Console.ReadLine();
        if (_confirm == "y" || _confirm == "Y")
        {
            Console.WriteLine($"Prompt: {_prompt}");
            foreach (string i in _entries)
            {
                Console.WriteLine(i);
            }
            Console.Write("Press enter to continue.");
            Console.ReadLine();
        }

        else if (_confirm == "n" || _confirm == "N")
        {
            Console.WriteLine("");
        }

        else
        {
            Console.Write("Unkown Command, see results (y/n)?");
        }
    }

    public void Ready()
    {
        int _ready = 9;
        Console.Write("Staring in...");
        while (_ready > 0)
        {
            Console.Write(_ready);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            _ready--;
        }
        Console.WriteLine("Go!");
    }

}
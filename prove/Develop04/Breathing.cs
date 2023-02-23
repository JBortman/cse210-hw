public class Breathing : Activity
{

    int _inTime;
    int _outTime;
    int _breaths;
    public Breathing(string activity) : base(activity)
    {
    }

    public int GetBreaths()
    {
        _breaths = _activityTime / 10;
        return _breaths;
    }

    public void Begin()
    {
        Console.Clear();
        Console.Write("When you are ready, please press enter.");
        Console.ReadLine();
        Console.Write("Beginning in ");
        _seconds = 3;
        while (_seconds > 0)
        {
            Console.Write(_seconds);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            _seconds--;
        }
        Console.Clear();
        GetBreaths();
        while (_breaths > 0)
        {
            _inTime = 4;
            _outTime = 6;
            Console.Write("Breathe in...");
            while (_inTime > 0)
            {
                Console.Write(_inTime);
                Thread.Sleep(1000);
                Console.Write("\b \b");
                _inTime--;
            }
            Console.WriteLine();

            Console.Write("Breathe out...");
            while (_outTime > 0)
            {
                Console.Write(_outTime);
                Thread.Sleep(1000);
                Console.Write("\b \b");
                _outTime--;
            }
            Console.WriteLine();
            Console.WriteLine();
            _breaths--;
        }
    }

}
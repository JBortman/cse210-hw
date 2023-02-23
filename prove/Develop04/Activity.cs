public class Activity
{
    protected string _activityTitle;
    protected int _activityTime;
    protected int _seconds;
    private List<string> _genericPrompts = new List<string>();
    public Activity(string activity)
    {
        _activityTitle = activity;
    }

    public void StartMessage()
    {
        Console.WriteLine($"Welcome to the {_activityTitle} Activity!");
    }

    public int ActivityTime()
    {
        Console.Write("How long, in seconds, would you like this activity to run?: ");
        _activityTime = int.Parse(Console.ReadLine());
        return _activityTime;
    }

    public void FinishMessage()
    {
        Console.WriteLine($"Great job! Thank you for participating in the {_activityTitle} Activity!");
        Console.WriteLine($"You completed {_activityTime} seconds!");
    }

    public void FinishTime()
    {
        Console.Write("Returning to the main menu ");
        _seconds = 5;
        while (_seconds > 0)
        {
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
            _seconds--;
        }
        Console.Clear();
    }

    public void Description()
    {
        if (_activityTitle == "Breathing")
        {
            Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
            Console.WriteLine("");
        }

        else if (_activityTitle == "Reflection")
        {
            Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
            Console.WriteLine("");
        }

        else if (_activityTitle == "Listing")
        {
            Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
            Console.WriteLine("");
        }
    }

}
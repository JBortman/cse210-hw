using System;

class Program
{
    static void Main(string[] args)
    {
        Activity job = new Activity();
        Running run = new Running();
        Cycling bike = new Cycling();
        Swimming swim = new Swimming();
        List<string> _activities = new List<string>{};

        //-----Running-----
        run.CalcSpeed(30, 2); // (time, distance)
        run.CalcPace();
        _activities.Add(run.CollectInfo("Running"));

        //-----Cycling-----
        bike.SetTime(20); // (time)
        bike.CalcDistance(5); // (speed)
        bike.CalcPace();
        _activities.Add(bike.CollectInfo("Cycling"));

        //-----Swimming-----
        swim.CalcSpeed(15, 30); // (time, laps)
        swim.CalcPace();
        _activities.Add(swim.CollectInfo("Swimming"));

        //-----Iterate and show items from list-----
        string[] acts;
        Console.Clear();
        foreach (string i in _activities)
        {
            acts = i.Split(",");
            job.GetSummary(acts[0], acts[1], acts[2], acts[3], acts[4], acts[5]);
            Console.WriteLine();
        }
    }
}
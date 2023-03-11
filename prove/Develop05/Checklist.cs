public class Checklist : Goal {

    protected int _initialProgress;

        public override string CreateGoal() {
        Console.Clear();
        _goalType = "Checklist";
        Console.WriteLine("Checklist goals have a set amount of times to complete.");
        Console.WriteLine("Once you've done the goal enough times, it completes and awards bonus points.");
        Console.WriteLine();

        Console.Write("Please describe your goal: ");
        _goalDescription = Console.ReadLine();

        Console.Write("How many points will each completion be worth?: ");
        _pointValue = int.Parse(Console.ReadLine());

        Console.Write("How many times must this goal be completed?: ");
        _completeProgress = int.Parse(Console.ReadLine());

        Console.Write("How many bonus points will be awarded once the goal is complete?: ");
        _bonus = int.Parse(Console.ReadLine());
        
        return $"{_goalType},{_goalDescription},{_pointValue},{_initialProgress},{_completeProgress},{_bonus},{_complete}";
    }


    public override void ShowGoal(string[] line)
    {
// Checklist goal format: 0 Goal Type, 1 Description, 2 PointValue, 3 InitialProgress, 4 CompleteProgress, 5 Bonus, 6 Completed?
        Console.WriteLine($"{line[1]} - {line[2]} points - Progress: {line[3]}/{line[4]}");
    }

}
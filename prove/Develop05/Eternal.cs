public class Eternal : Goal {

    private int _milestone;

    public override string CreateGoal() {
        Console.Clear();
        _goalType = "Eternal";
        Console.WriteLine("Eternal goals are completed multiple times and have no end, earning points after each completion.");
        Console.WriteLine("(Bonus points received after milestones are reached)");
        Console.WriteLine();

        Console.Write("Please describe your goal: ");
        _goalDescription = Console.ReadLine();

        Console.Write("How many points will each completion be worth?: ");
        _pointValue = int.Parse(Console.ReadLine());

        Console.Write("How many times must this goal be completed to earn bonus points?: ");
        _milestone = int.Parse(Console.ReadLine());

        Console.Write("How much are bonuses worth?: ");
        _bonus = int.Parse(Console.ReadLine());

        _completeProgress = 0;
        
        return $"{_goalType},{_goalDescription},{_pointValue},{_completeProgress},{_milestone},{_bonus}";
    }
    
        public override void ShowGoal(string[] line)
    {
// Eternal goal format: 0 Goal Type, 1 Description, 2 PointValue, 3 CompleteProgress, 4 Milestone, 5 Bonus?
        Console.WriteLine($"{line[1]} - {line[2]} points - Progress to next milestone: {line[3]}/{line[4]}");
    }

}
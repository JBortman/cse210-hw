public class Simple : Goal
{

    bool check;
    public override string CreateGoal()
    {
        Console.Clear();
        _goalType = "Simple";
        Console.WriteLine("Simple goals are completed once, and then award points.");
        Console.WriteLine();
        Console.Write("Please describe your goal: ");
        _goalDescription = Console.ReadLine();
        Console.Write("How many points will this goal be worth?: ");
        _pointValue = int.Parse(Console.ReadLine());
        _completeProgress = 0;
        _complete = false;

        return $"{_goalType},{_goalDescription},{_pointValue},{_completeProgress},{_complete}";
    }

    public override void ShowGoal(string[] line)
    {
        // Simple goal format: 0 Goal Type, 1 Description, 2 PointValue, 3 CompleteProgress, 4 Complete?
        check = bool.Parse(line[4]);
        if(check == false){
            Console.WriteLine($"{line[1]} - {line[2]} points - Not Complete Yet");
        }
        else {
            Console.WriteLine($"{line[1]} - {line[2]} points - Complete!");
        }

    }

}
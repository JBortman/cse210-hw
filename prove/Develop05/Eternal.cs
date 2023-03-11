public class Eternal : Goal
{

    private int _milestone;
    private int _total;

    public override string CreateGoal()
    {
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
        _total = 0;

        return $"{_goalType},{_goalDescription},{_pointValue},{_completeProgress},{_milestone},{_total},{_bonus}";
    }

    public override void ShowGoal(string[] line)
    {
        // Eternal goal format: 0 Goal Type, 1 Description, 2 PointValue, 3 CompleteProgress, 4 Milestone, 5 Total, 6 Bonus?
        Console.WriteLine($"{line[1]} - {line[2]} points - Times completed {line[5]} - Progress to next milestone: {line[3]}/{line[4]}");
    }

    public override int MarkProgress(List<string> list, int index)
    {
        if (list.Count() == 0)
        {
            Console.WriteLine("List is currently empty, please add goals or load from a previous file.");
            Thread.Sleep(3000);
        }

        else
        {

            _selSplit = list[index].Split(",");
            int _pointValue = int.Parse(_selSplit[2]);
            int _completeProgress = int.Parse(_selSplit[3]);
            int _milestone = int.Parse(_selSplit[4]);
            int _total = int.Parse(_selSplit[5]);
            int _bonus = int.Parse(_selSplit[6]);
            _completeProgress += 1;

            if (_completeProgress != _milestone)
            {
                _total += 1;
                Console.WriteLine($"{_selSplit[1]} - Completed {_total} times - Milestone Progress {_completeProgress}/{_milestone}");
                Console.WriteLine($"Well done! You've made some progress! {_pointValue} points to you!");
                _userPoints += _pointValue;
            }

            else if (_completeProgress == _milestone)
            {
                _total += 1;
                _completeProgress = 0;
                Console.WriteLine($"{_selSplit[1]} - Milestone Reached! {_bonus} bonus points added. Milestone progress reset: {_completeProgress}/{_milestone}");
                _userPoints += _pointValue;
                _userPoints += _bonus;
            }

            else
            {
                Console.WriteLine($"{_selSplit[1]} - Completed {_total} times - Milestone Progress {_completeProgress}/{_milestone} - Goal Already Completed");
            }


            _newString = $"{_selSplit[0]},{_selSplit[1]},{_selSplit[2]},{_completeProgress},{_milestone},{_total},{_bonus}";
            list[index] = _newString;
        }
        Console.WriteLine("Press enter to continue");
        Console.ReadLine();
        return _userPoints;
    }

}
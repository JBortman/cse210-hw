public class Checklist : Goal
{

    protected int _initialProgress;

    public override string CreateGoal()
    {
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
        if(line[3] == line[4])
        {
        Console.WriteLine($"{line[1]} - {line[2]} points - Progress: {line[3]}/{line[4]} - Complete!");
        }

        else{
        Console.WriteLine($"{line[1]} - {line[2]} points - Progress: {line[3]}/{line[4]} - Incomplete");
        }
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
            int _progressCheck = int.Parse(_selSplit[3]);
            int _progressFinish = int.Parse(_selSplit[4]);
            int _bonus = int.Parse(_selSplit[5]);
            check = bool.Parse(_selSplit[6]);
            if (check == false)
            {
                _progressCheck += 1;

                if (_progressCheck != _progressFinish)
                {
                    Console.WriteLine($"{_selSplit[1]} - Progress {_progressCheck}/{_selSplit[4]}");
                    Console.WriteLine($"Well done! You've made some progress! {_pointValue} points to you!");
                    _userPoints += _pointValue;
                }

                else if (_progressCheck == _progressFinish)
                {
                    Console.WriteLine($"{_selSplit[1]} - Progress {_progressCheck}/{_selSplit[4]}");
                    Console.WriteLine($"Goal completed! Great job! {_pointValue} points added and {_selSplit[5]} bonus points added.");
                    _userPoints += _pointValue;
                    _userPoints += _bonus;
                    check = true;
                }
            }

            else
            {
                Console.WriteLine($"{_selSplit[1]} - Progress {_selSplit[3]}/{_selSplit[4]} - Goal Already Completed");
            }


            _newString = $"{_selSplit[0]},{_selSplit[1]},{_selSplit[2]},{_progressCheck},{_selSplit[4]},{_selSplit[5]},{check}";
            list[index] = _newString;
        }
        Console.WriteLine("Press enter to continue");
        Console.ReadLine();
        return _userPoints;
    }

}
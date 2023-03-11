public class Simple : Goal
{

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
        _complete = false;

        return $"{_goalType},{_goalDescription},{_pointValue},{_complete}";
    }

    public override void ShowGoal(string[] line)
    {
        // Simple goal format: 0 Goal Type, 1 Description, 2 PointValue, 3 CompleteProgress, 4 Complete?
        check = bool.Parse(line[3]);
        if (check == false)
        {
            Console.WriteLine($"{line[1]} - Not Complete Yet");
        }
        else
        {
            Console.WriteLine($"{line[1]} - {line[2]} points - Complete!");
        }

    }

    public override int MarkProgress(List<string> list, int index)
    {
        _selSplit = list[index].Split(",");
        if (list.Count() == 0)
        {
            Console.WriteLine("List is currently empty, please add goals or load from a previous file.");
            Thread.Sleep(3000);
        }
        else
        {
            check = bool.Parse(_selSplit[3]);
            if (check == false)
            {
                Console.WriteLine($"Current goal selected: {_selSplit[1]} - Not Complete Yet");
                Console.WriteLine("1. Mark Complete");
                Console.WriteLine("2. Cancel");
                Console.Write("What would you like to do? ");
                _answer = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (_answer)
                {
                    case 1:
                        _selSplit[3] = "True";
                        Console.WriteLine($"Current goal selected: {_selSplit[1]} - Complete!");
                        _userPoints += int.Parse(_selSplit[2]);
                        Console.WriteLine($"{_selSplit[2]} points added to your score!");
                        Console.Write("Press enter to continue");
                        Console.ReadLine();
                        break;

                    case 2:
                        Console.Clear();
                        break;

                    default:
                        break;
                }
                _newString = $"{_selSplit[0]},{_selSplit[1]},{_selSplit[2]},{_selSplit[3]}";
                list[index] = _newString;
            }

            else if (check == true)
            {
                Console.WriteLine($"Current goal selected: {_selSplit[1]} - Already Completed");
                Thread.Sleep(3000);
            }


        }

        return _userPoints;
    }

}
using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<string> _goals = new List<string> { };

        string _newSimple;
        string _newEternal;
        string _newChecklist;
        string select = null;
        int _userPoints = 0;
        int _index = 0;

        Console.Clear();
        Console.WriteLine("Welcome to Eternal Quest! Select from the menu below");
        Console.WriteLine("and begin your journey! Or load a previous journey");
        Console.WriteLine("and continue where you left off.");
        Console.WriteLine("");
        while (select != "6")
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Score and Current Goals");
            Console.WriteLine("3. Mark Complete");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Previous Goals");
            Console.WriteLine("6. Quit");
            Console.Write("Your choice --> ");
            select = Console.ReadLine();

            if (select == "1")
            {
                Console.Clear();
                Console.WriteLine("1. Simple");
                Console.WriteLine("2. Eternal");
                Console.WriteLine("3. Checklist");
                Console.Write("What type of goal are you creating?: ");
                int type = int.Parse(Console.ReadLine());
                switch (type)
                {
                    case 1:
                        Simple s = new Simple();
                        //Console.WriteLine(s.createGoal()); //FOR TROUBLESHOOTING
                        _newSimple = s.CreateGoal();
                        _goals.Add(_newSimple);
                        break;
                    case 2:
                        Eternal e = new Eternal();
                        //Console.WriteLine(e.CreateGoal()); //FOR TROUBLESHOOTING
                        _newEternal = e.CreateGoal();
                        _goals.Add(_newEternal);
                        break;
                    case 3:
                        Checklist c = new Checklist();
                        //Console.WriteLine(c.CreateGoal()); //FOR TROUBLESHOOTING
                        _newChecklist = c.CreateGoal();
                        _goals.Add(_newChecklist);
                        break;

                    default:
                        break;
                }
            }

            else if (select == "2")
            {
                Console.Clear();
                Simple ss = new Simple();
                Eternal se = new Eternal();
                Checklist sc = new Checklist();
                Console.Write($"Current Score: {_userPoints}");
                Console.WriteLine();
                string[] ws;
                foreach (string line in _goals)
                {
                    ws = line.Split(",");
                    switch (ws[0])
                    {
                        case "Simple":
                            ss.ShowGoal(ws);
                            break;

                        case "Eternal":
                            se.ShowGoal(ws);
                            break;

                        case "Checklist":
                            sc.ShowGoal(ws);
                            break;

                        default:
                            break;
                    }
                }

                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
                Console.Clear();
            }

            else if (select == "3")
            {
                Simple ms = new Simple();
                //Eternal me = new Eternal();
                Checklist mc = new Checklist();
                int _count = 1;
                Simple ss = new Simple();
                Eternal se = new Eternal();
                Checklist sc = new Checklist();
                Console.WriteLine();
                string[] ws;

                foreach (string line in _goals)
                {
                    ws = line.Split(",");
                    switch (ws[0])
                    {
                        case "Simple":
                            Console.Write($"{_count}. ");
                            ss.ShowGoal(ws);
                            _count++;
                            break;

                        case "Eternal":
                            Console.Write($"{_count}. ");
                            se.ShowGoal(ws);
                            _count++;
                            break;

                        case "Checklist":
                            Console.Write($"{_count}. ");
                            sc.ShowGoal(ws);
                            _count++;
                            break;

                        default:
                            break;
                    }
                }

                Console.Write("Which goal would you like to progress?: ");
                _index = int.Parse(Console.ReadLine()) - 1;
                Console.WriteLine();
                ws = _goals[_index].Split(",");

                switch (ws[0])
                {
                    case "Simple":
                        _userPoints += ms.MarkProgress(_goals, _index);
                        break;

                    case "Eternal":

                        break;

                    case "Checklist":
                        _userPoints += mc.MarkProgress(_goals, _index);
                        break;

                }
                Console.Clear();
            }

            else if (select == "4")
            {
                SaveLoad save = new SaveLoad();
                save.Save(_goals, _userPoints);
                Console.WriteLine("Progress saved");
                Thread.Sleep(2000);
                Console.Clear();
            }

            else if (select == "5")
            {
                SaveLoad load = new SaveLoad();
                _userPoints = load.Load(_goals);
                Console.WriteLine("Load Successfull");
                Thread.Sleep(1000);
                Console.Clear();
            }

            else if (select == "6")
            {
                string saveProg;
                Console.Write("Save your progress? (y/n) --> ");
                saveProg = Console.ReadLine();
                if (saveProg == "y")
                {
                    SaveLoad save = new SaveLoad();
                    save.Save(_goals, _userPoints);
                    Console.WriteLine("Progress saved");
                    Console.WriteLine();
                }
                else if (saveProg == "n")
                {
                    Console.WriteLine();
                }

                Console.WriteLine("Today's journey, has ended!");
                Console.WriteLine();
                break;
            }

            else
            {
                Console.WriteLine("Invalid Entry, only select 1-6");
            }

        }
    }
}
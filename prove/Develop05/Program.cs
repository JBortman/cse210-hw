using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<string> _goals = new List<string> {
            "Simple,Test simple,250,0,False",
            "Simple,Test simple2,100,1,True",
            "Eternal,Test eternal,50,0,5,250",
            "Checklist,Test checklist,50,0,5,250,False"
        };
        string _newSimple;
        string _newEternal;
        string _newChecklist;
        string select = null;
        int _userPoints = 75;

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
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Previous Goals");
            Console.WriteLine("5. Mark Complete");
            Console.WriteLine("6. Quit");
            Console.Write("Your choice --> ");
            select = Console.ReadLine();

            if (select == "1")
            {
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
                    switch(ws[0])
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
                SaveLoad save = new SaveLoad();
                save.Save(_userPoints, _goals);
                Console.WriteLine("Progress saved");
                Console.WriteLine();
            }
            else if (select == "4")
            {
                SaveLoad load = new SaveLoad();
                load.Load(_userPoints, _goals);
                Console.Clear();
            }
            else if (select == "5")
            {
                Console.WriteLine("Mark");
            }
            else if (select == "6")
            {
                string saveProg;
                Console.Write("Save your progress? (y/n) --> ");
                saveProg = Console.ReadLine();
                if (saveProg == "y")
                {
                    SaveLoad save = new SaveLoad();
                    save.Save(_userPoints, _goals);
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
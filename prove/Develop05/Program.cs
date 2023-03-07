using System;

class Program
{
    static void Main(string[] args)
    {
        string select=null;

        Console.Clear();
        Console.WriteLine("Welcome to Eternal Quest! Select from the menu below");
        Console.WriteLine("and begin your journey! Or load a previous journey");
        Console.WriteLine("and continue where you left off.");
        Console.WriteLine("");
        while (select != "6")
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Current Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Previous Goals");
            Console.WriteLine("5. Mark Complete");
            Console.WriteLine("6. Quit");
            Console.Write("Your choice --> ");
            select = Console.ReadLine();

            if (select == "1")
            {
                Console.WriteLine("Create");
            }
            else if (select == "2")
            {
                Console.WriteLine("List");
            }
            else if (select == "3")
            {
                Console.WriteLine("Save");
            }
            else if (select == "4")
            {
                Console.WriteLine("Load");
            }
            else if (select == "5")
            {
                Console.WriteLine("Mark");
            }
            else if (select == "6")
            {
                string saveProg;
                Console.Write("Save your progress (y/n) --> ");
                saveProg = Console.ReadLine();
                if (saveProg == "y"){
                    Console.WriteLine("Progress saved");
                    Console.WriteLine();
                }
                else if (saveProg == "n") {
                Console.WriteLine();
                }

                Console.WriteLine("Your journey, has ended!");
                Console.WriteLine();
                break;
            }

            else {
                Console.WriteLine("Invalid Entry, only select 1-6");
            }

        }
    }
}
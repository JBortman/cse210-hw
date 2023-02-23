using System;

class Program
{
    static void Main(string[] args)
    {
        string input = String.Empty;
        while (input != "4")
        {

            Console.WriteLine("");
            Console.WriteLine("Main Menu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Please make a selection (1-4): ");

            input = Console.ReadLine();
            if (input == "1")
            {
                Console.Clear();
                Breathing breathe = new Breathing("Breathing");
                breathe.StartMessage();
                breathe.Description();
                breathe.ActivityTime();
                breathe.Begin();
                breathe.FinishMessage();
                breathe.FinishTime();

            }

            else if (input == "2")
            {
                Console.Clear();
                Activity reflection = new Activity("Reflection");
                reflection.StartMessage();
                reflection.Description();
                reflection.ActivityTime();
                reflection.FinishMessage();
                reflection.FinishTime();
            }

            else if (input == "3")
            {
                Console.Clear();
                Activity list = new Activity("List");
                list.StartMessage();
                list.Description();
                list.ActivityTime();
                list.FinishMessage();
                list.FinishTime();
            }

            else if (input == "4")
            {
                break;
            }

            else
            {
                Console.WriteLine("Invalid input, please try again.");
            }
        };


    }

}
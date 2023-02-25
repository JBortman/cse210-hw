using System;

class Program
{
    static void Main(string[] args)
    {
        string input = String.Empty;
        while (input != "5")
        {

            Console.WriteLine("");
            Console.WriteLine("Main Menu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Add Custom Prompt");
            Console.WriteLine("5. Quit");
            Console.Write("Please make a selection (1-4): ");

            input = Console.ReadLine();
            if (input == "1")
            {
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
                Reflection reflect = new Reflection("Reflection");
                reflect.StartMessage();
                reflect.Description();
                reflect.ActivityTime();
                reflect.Think();
                reflect.FinishMessage();
                reflect.FinishTime();
            }

            else if (input == "3")
            {
                Listing list = new Listing("List");
                list.StartMessage();
                list.Description();
                list.ActivityTime();
                list.List();
                list.FinishMessage();
                list.FinishTime();
            }

            //Added the ability to add your own prompt to the existing list if desired
            else if (input == "4")
            {
                Activity prompt = new Activity("");
                prompt.AddPrompt();
            }

            else if (input == "5")
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
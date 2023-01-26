using System;

class Program
{
    static void Main(string[] args)
    {

        //Initial menu options--------------------
        int? select = null;
        while (select != 5)
        {
            Console.WriteLine("");
            Console.WriteLine("Please select one of the following:");
            Console.WriteLine("1. New Journal Entry");
            Console.WriteLine("2. Display Current Entries");
            Console.WriteLine("3. Load Previous File");
            Console.WriteLine("4. Save Current File");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do?: ");
            select = int.Parse(Console.ReadLine());

            //Jounral entry--------------------
            if (select == 1)
            {
                PromptGen generate = new PromptGen();
                generate.GenPrompt();
                Console.WriteLine("Jounral Entry");
                select = null;
            }

            else if (select == 2)
            {
                Console.WriteLine("Display");
                select = null;
            }

            else if (select == 3)
            {
                Console.WriteLine("Load");
                select = null;
            }

            else if (select == 4)
            {
                Console.WriteLine("Save");
                select = null;
            }

            else if (select == 5)
            {

            }

            //If input is under 1 or over 5--------------------
            else
            {
                Console.WriteLine("Invalid entry, please only enter a number between 1-5.");
                select = null;
            }

        }
    }
}
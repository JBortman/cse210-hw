using System;

class Program
{
    static void Main(string[] args)
    {
        //Initial menu options--------------------

        int select = 1;
        while (select != 5)
        {
            if (select <= 0)
            {
                Console.WriteLine("Invalid entry, please only enter a number between 1-5.");
                Console.WriteLine("What would you like to do?: ");
                select = int.Parse(Console.ReadLine());
            }

            else if (select >= 6)
            {
                Console.WriteLine("Invalid entry, please only enter a number between 1-5.");
                Console.Write("What would you like to do?: ");
                select = int.Parse(Console.ReadLine());
            }

            else
            {
                Console.WriteLine("Please select one of the following:");
                Console.WriteLine("1. New Journal Entry");
                Console.WriteLine("2. Display Current Entries");
                Console.WriteLine("3. Load Previous File");
                Console.WriteLine("4. Save Current File");
                Console.WriteLine("5. Quit");
                Console.Write("What would you like to do?: ");
                select = int.Parse(Console.ReadLine());
            }
        }
        //Prompt selection--------------------



        //Jounral entry--------------------
    }
}
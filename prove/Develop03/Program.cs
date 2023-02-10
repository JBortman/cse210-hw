using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scrip = new Scripture();
        string input = String.Empty;
        scrip.AddToList();
        scrip.FullScripture();

        while (input != "quit")
        {
            if (input == String.Empty)
            {
                Console.WriteLine();
                Console.WriteLine("Press enter to remove a word, or type quit to stop. ");
                input = Console.ReadLine();
                scrip.HideWord();
            }

            else
            {
                Console.WriteLine();
                Console.Write("Please press enter or type quit. ");
                input = Console.ReadLine();
            }
        }
    }
}
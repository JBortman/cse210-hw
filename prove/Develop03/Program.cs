using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scrip = new Scripture();
        Word check = new Word();
        string input = String.Empty;
        scrip.AddToList();
        scrip.FullScripture();
        bool _check = false;

        while (_check == false)
        {
            Console.WriteLine();
            Console.WriteLine("Enter: Remove words");
            Console.WriteLine("1. Resets all the words");
            Console.WriteLine("2. View hidden words");
            Console.WriteLine("3. Quit the program");
            Console.Write("Please select an option: ");
            input = Console.ReadLine();
            if (input == String.Empty)
            {
                _check = scrip.HideWord();
            }

            else if (input == "1")
            {
            scrip.Reset();
            scrip.AddToList();
            scrip.FullScripture();
            check.ClearList();
            input=String.Empty;
            }

            else if (input == "2")
            {
                check.HiddenList();
                input=string.Empty;
            }

            else if (input == "3")
            {
                break;
            }
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        string date = DateTime.Now.ToString("MM/dd/yyyy");
        List<string> _entries = new List<string>();

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
                Entry newEntry = new Entry();
                PromptGen promptEntry = new PromptGen();
                string prompt = promptEntry.GenPrompt();
                string entry = newEntry.JournalEntry();
                _entries.Add($"{date} - {prompt}: {entry}");
                select = null;
            }

            else if (select == 2)
            {
                foreach (string i in _entries)
                {
                    Console.WriteLine(i);
                }
            }

            else if (select == 3)
            {
                SaveLoad load = new SaveLoad();
                List<string> loadedList = load.LoadFile();
                _entries.Clear();
                foreach (string l in loadedList)
                {
                    _entries.Add(l);
                }
                Console.WriteLine("Load");
                select = null;
            }

            else if (select == 4)
            {
                SaveLoad nameFile = new SaveLoad();
                string name = nameFile.NameFile();
                using (TextWriter tw = new StreamWriter(name))
                {
                    foreach (string s in _entries)
                        tw.WriteLine(s);
                }
                Console.WriteLine($"Successfully saved {name}");
                select = null;
            }

            else if (select == 5)
            {
                Console.WriteLine("Program terminated. Thank you!");
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
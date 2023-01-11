using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the magic number?");
        Random rnd = new Random();
        int magicNum = rnd.Next(1, 101);

        int userInput = 0;
        while (userInput != magicNum)
        {
            Console.Write("What is your guess? ");
            string input = Console.ReadLine();
            userInput = int.Parse(input);

            if (magicNum == userInput)
            { Console.WriteLine("That is correct!"); }

            else if (magicNum < userInput)
            { Console.WriteLine("Go lower"); }

            else if (magicNum > userInput)
            { Console.WriteLine("Go higher"); }

            else
            { Console.WriteLine("Input not recognized"); }
        }

    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int favNumber = PropmtUserNumber();
        int favSquared = SquareNumber(favNumber);

        DisplayResult(userName, favSquared);

        //Welcome function//
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");

        }

        //Prompt name//
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        //Favorite number//
        static int PropmtUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        //Square Number//
        static int SquareNumber(int number)
        {
            int squared = number * number;
            return squared;
        }

        //Display the result//
        static void DisplayResult(string name, int squared)
        {
            Console.WriteLine($"{name}, the square root of your favorite number is {squared}");
        }

    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        int input = 1;

        while (input != 0)
        {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());
            numbers.Add(input);
        }
        //Get the sum of the list//
        int total = 0;
        float count = 0;
        foreach (int i in numbers)
        {
            count++;
            total += i;
        }

        //Calculate the average//
        float average = total / (count - 1);

        //Calculate largest number//
        int large = numbers[0];
        for (int l = 1;
                l < count; l++)
            if (numbers[l] > large)
                large = numbers[l];

        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {large}");
    }
}
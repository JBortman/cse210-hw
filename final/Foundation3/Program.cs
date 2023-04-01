using System;

class Program
{
    static void Main(string[] args)
    {
        Lectures lect = new Lectures("A Look to the Stars", "What can the stars reveal about you? Listen to a famous astronomer talk about it!", "February 29, 2023", "7:30pm", "Lecture", "Merlin", "200");
        Outdoor outd = new Outdoor("Wildfires","Wildfires are very dangerous. Learn how to be responsible for your campsites and trails!","April 31, 2023","12:00am","Outdoor","75F Overcast - Slightly Breezy");
        Receptions rec = new Receptions("Fireman's Lunch","Show appreciation for our firefighters at this special lunch dedicated to them! Space is limited, RSVP required.","12/12/2023","11:47am","Reception","notspam@totallylegit.aol");
        
        Console.Clear();
        lect.GetAddress();
        Console.WriteLine(lect.ShortDesc());
        Console.WriteLine();
        Console.WriteLine(lect.StandardDesc());
        Console.WriteLine();
        Console.WriteLine(lect.GetLectureInfo());
        Console.WriteLine("------------------------------");//separates each even in terminal

        outd.GetAddress();
        Console.WriteLine(outd.ShortDesc());
        Console.WriteLine();
        Console.WriteLine(outd.StandardDesc());
        Console.WriteLine();
        Console.WriteLine(outd.GetOutdoorInfo());
        Console.WriteLine("------------------------------");

        rec.GetAddress();
        Console.WriteLine(rec.ShortDesc());
        Console.WriteLine();
        Console.WriteLine(rec.StandardDesc());
        Console.WriteLine();
        Console.WriteLine(rec.GetReceptionInfo());
        Console.WriteLine("------------------------------");
    }
}
// Jayton Crockett and Michael Torres
// Once this activity is selected the user is asked to relax and breath and out in for 5 seconds each
using System;

public class Breathing : Activity
{
    public Breathing() : base()
    {

        _name = "Breathing";
        _description = "This activity is meant to help clear your mind and relax";
    }

    public void displayActivity()
    {
        Console.WriteLine(_description);
        DateTime end_time = DateTime.Now;
        end_time = end_time.AddSeconds(_duration);
        DateTime now = DateTime.Now;
        while(now < end_time){
            // This more of a fluid countdown where there the number before will disappear
            Console.WriteLine("Breathe in...");
            Console.Write("5");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("4");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("3");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("2");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("1");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.WriteLine("And breathe out");
            Console.Write("5");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("4");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("3");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("2");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("1");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            now = DateTime.Now;
        }
        Console.WriteLine(_finishingMessage);
        Console.WriteLine("You did the breathing activity for "+_duration+" seconds");
    }

}
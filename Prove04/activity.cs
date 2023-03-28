// Jayton Crockett and Michael Torres
using System;

public class Activity
{
    protected string _activityMessage = "Welcome to the your selected activity.";
    protected int _duration = 1;
    protected string _name = "";
    protected string _description = "";
    protected string _finishingMessage  = "Thanks for participating in the activity!";

    public Activity()
    {
        Console.WriteLine("How long would you like to perform the activity for? (In seconds)");
        string userInput = Console.ReadLine();
        int duration = int.Parse(userInput);
        _duration = duration;
    }

    public void displayWelcomeMessage()
    {
        Console.WriteLine(_activityMessage);
        Console.WriteLine(_name);
        Console.WriteLine(_description);
    }

    public void displayEndingMessage()
    {
        Console.WriteLine(_finishingMessage);
    }
}
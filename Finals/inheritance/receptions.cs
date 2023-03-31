// Jayton Crockett
using System;
public class Receptions:Event{
    protected string _email;
    public void getFDetails(){
        Console.WriteLine("<Full Details>");
        getSDetails();
        Console.WriteLine($"To RSVP email {_email}");
    }
    public void getSDescription(){
        Console.WriteLine($"Type: Reception\n'{_title}' \nDate: {_date}");
    }
    public Receptions(){
        _address = new Address();
        Console.WriteLine("Please fill out the info for the event below:\n");
        Console.Write("Title: ");
        _title = Console.ReadLine();

        Console.Write("Description: ");
        _description = Console.ReadLine();

        Console.Write("Date: ");
        _date = Console.ReadLine();

        Console.Write("Time: ");
        _time = Console.ReadLine();

        Console.Write("RSVP Email: ");
        _email = Console.ReadLine();
    }
}
// Jayton Crockett
using System;
public class Outdoor:Event{
    protected string _weather;
    public void getFDetails(){
        Console.WriteLine("<Full Details>");
        getSDetails();
        Console.WriteLine($"During this event the weather will be: {_weather}");
    }
    public void getSDescription(){
        Console.WriteLine($"Type: Outdoor Gathering\n'{_title}' \nDate: {_date}");
    }
    public Outdoor(){
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

        Console.Write("Weather: ");
        _weather = Console.ReadLine();
    }
}
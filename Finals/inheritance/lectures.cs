// Jayton Crokett
using System;
public class Lectures:Event{
    protected string _speaker;
    protected int _capacity = 1;
    public void getFDetails(){
        Console.WriteLine("<Full Details>");
        getSDetails();
        Console.WriteLine($"Speaker: {_speaker} \nCapacity: {_capacity}");
    }
    public void getSDescription(){
        Console.WriteLine($"Type: Lecture \n'{_title}' \nDate: {_date}");
    }
    public Lectures(){
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

        Console.Write("Speaker: ");
        _speaker = Console.ReadLine();
        
        Console.Write("Capacity: ");
        _capacity = int.Parse(Console.ReadLine());
    }

}
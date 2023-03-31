// Jayton Crockett
using System;
public class Event{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;
    public void getSDetails(){
        Console.WriteLine($"{_title} \n{_date}, {_time} \n{_address.getAddress()} \n{_description}");
    }
}
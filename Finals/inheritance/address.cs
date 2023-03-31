// Jayton Crockett
using System;

public class Address{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    public Address(){
        Console.WriteLine("Please fill out your address below:");
        Console.Write("Street Name: ");
        _street = Console.ReadLine();
        
        Console.Write("City: ");
        _city = Console.ReadLine();
        
        Console.Write("State: ");
        _state = Console.ReadLine();

        Console.Write("Country: ");
        _country = Console.ReadLine();
    }
    public string getAddress(){
        return $"{_street}\n {_city}, {_state} {_country}";
    }
}
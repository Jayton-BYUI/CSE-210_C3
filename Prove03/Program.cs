// Jayton Crockett and Michael Torres
// Runs the program getting the users scripture
using System;
class Program
{
    static void Main(string[] args)
    {
        string userResponse = "0";
        while (userResponse != "quit")
        {
            Console.WriteLine("Welcome to the scripture hiding app!");
            // Asks the user what scripture they want
            Console.Write("Enter a scripture reference (e.g. John 3:16): ");
            string reference = Console.ReadLine();
            // Pulls the scripture from the csv file
            Scripture scripture = new Scripture(reference);

            Console.WriteLine(scripture.scriptureString());
        }
    }
}
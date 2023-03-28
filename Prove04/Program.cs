// Jayton Crockett and Michael Torres
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello! Welcome to our activites program. Which activity would you like to do, \n1: Breathing \n2: Reflection \n3: Listening ");
        // string userResponse = Console.ReadLine();
        int userInput = int.Parse(Console.ReadLine());
        
        // Breathing activity
        if (userInput == 1)
        {
            Breathing breathing = new Breathing();
            breathing.displayActivity();
        }
        // Reflection activity
        else if (userInput == 2)
        {
            Reflection reflection = new Reflection();
            reflection.displayActivity();
        }
        // Listing activity
        else if (userInput == 3)
        {
            Listing listing = new Listing();
            listing.displayActivity();
        }
        else
        {
            Console.Write("Oops! You might have typed something wrong. Trying the program again.");
        }
    }
}
using System;
// Jayton Crockett
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the program! Which activity would you like to do, type 1 for Breathing, type 2 for Reflection, or type 3 for Listening? ");
        string userResponse = Console.ReadLine();
        int userInput = int.Parse(userResponse);

        if (userInput == 1)
        {
            Breathing breathing = new Breathing();
            breathing.displayActivity();
        }
        else if (userInput == 2)
        {
            Reflection reflection = new Reflection();
            reflection.displayActivity();
        }
        else if (userInput == 3)
        {
            Listening listening = new Listening();
            listening.displayActivity();
        }
        else
        {
            Console.Write("Sorry that is not an option, please try the program again!");
        }
    }
}
// Jayton Crockett and Michael Torres

using System;

public class Listing : Activity
{
    public Listing() : base()
    {
        _description = "This activity will help you appreciate the good people and things in your life.";
        _name = "Listing";
    }

    protected List<string> main_prompt = new List<string>{
        "Think of the acts of service you have receved this week.",
        "Who have you been able to help today?",
        "What are some things that you can do this week to improve yourself spiritually?",
        "What are a few complements you can give to people today?",
        "What are some blessing that you have had this week?"
    };

    protected List<string> prompt_answers = new List<string>{};

    public void displayActivity()
    {
        Console.WriteLine(_description);
        Random random = new Random();
        Console.WriteLine(main_prompt[random.Next(0, 4)]);
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
        Console.Write("Go!");
        Console.WriteLine();

        DateTime end_time = DateTime.Now;
        end_time = end_time.AddSeconds(_duration);
        DateTime now = DateTime.Now;
        while(now < end_time){
            string answer = Console.ReadLine();
            prompt_answers.Add(answer);

            now = DateTime.Now;
        }
        Console.WriteLine("Time's Up!");
        Thread.Sleep(1000);
        Console.WriteLine("Your answers were:");
        foreach (string ans in prompt_answers){
            Console.WriteLine(ans);
        }
        Console.WriteLine(_finishingMessage);
        Console.WriteLine("You did the Listing activity for "+_duration+" seconds");
    }
    
}
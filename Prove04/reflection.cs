using System;
// Jayton Crockett, Micheal Torres, and Austin Reeves

public class Reflection : Activity
{
    public Reflection() : base() 
    {
        _name = "Reflection";
        _description = "This activity will prompt you with a question you can ponder and reflect on in your life.\n";
    }

    protected List<string> main_prompt = new List<string>{
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    protected List<string> questions = new List<string>{
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    
    public void displayActivity()
    {
        Console.WriteLine(_description);
        int do_main_prompt = 1;
        Random random = new Random();
        DateTime end_time = DateTime.Now;
        end_time = end_time.AddSeconds(_duration);
        DateTime now = DateTime.Now;
        while(now < end_time){
            if(do_main_prompt == 1){
                int prompt_index = random.Next(0, 3);
                Console.WriteLine(main_prompt[prompt_index]);
                do_main_prompt = 0;
            }
            else{
                int question_index = random.Next(0, 8);
                Console.WriteLine(questions[question_index]);
            }
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write(@"\");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write(@"\");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write(@"\");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write(@"\");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write(@"\");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("|");
            Console.Write("\b \b");
            Console.WriteLine();

            now = DateTime.Now;
        
        }
        Console.WriteLine(_finishingMessage);
        Console.WriteLine("You did the reflection activity for "+_duration+" seconds");
    }
}
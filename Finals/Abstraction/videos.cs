// Jayton Crockett
using System;
public class Videos{
    private string? _title;
    private string? _actors;
    private string? _time;

    private List<Comments> comment = new List<Comments>();
    private List<string> video = new List<string>();
    private List<string> title = new List<string>(){
        "How to get a job",
        "Fastest way to solve a rubix cube",
        "10 EASY steps to improve your hygiene",
        "Best date ideas for the first date"
    };
    private List<string> actors = new List<string>(){
        "Jack Black",
        "Ryan Reynolds",
        "Hugh Jackman",
        "Ana de Armas"
    };
    private List<int> time = new List<int>(){
        5,
        21,
        30,
        12
    };
    public void videoMethod(){
        _title = title[(new Random().Next(title.Count))];
        _actors = actors[new Random().Next(actors.Count)];
        _time = time[new Random().Next(time.Count)].ToString();

        for (int i = 0; i < 5; i++){
            Comments c = new Comments();
            c.comments();
            comment.Add(c);
        }
    }
    public int getCommentCount()
    {
        return comment.Count;
    }

    public void Display()
    {
        Console.WriteLine($"Playing {_title} \n by {_actors} - {_time} minutes long");
        Console.WriteLine($"View {getCommentCount()} comments");

        Console.WriteLine("View ^");
        foreach (Comments c in comment){
            c.Display();
        }
        Console.WriteLine("");
    }

}
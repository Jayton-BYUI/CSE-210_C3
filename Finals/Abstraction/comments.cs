// Jayton Crockett
using System;
public class Comments{
    private string? _username;
    private string? _comments;
    private List<string> usernames = new List<string>(){
        "JaytonC",
        "TheMan<3",
        "SuperDude_03",
        "CrispyComments"
    };
    private List<string> comment = new List<string>(){
        "I got my first job!",
        "I'm a rubix cube wizard now",
        "What is that smell?",
        "She ghosted me..."
    };
    public void comments(){
        _username = usernames[(new Random().Next(usernames.Count))];
        _comments = comment[new Random().Next(comment.Count)];
    }
    public void Display(){
        Console.WriteLine($"{_username} \n{_comments}");
    }
}
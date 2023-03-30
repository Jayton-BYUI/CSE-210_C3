// Jayton Crockett
using System;
class Program{
    static void Main(string[] args){
        List<Videos> video = new List<Videos>(){
            new Videos(),
            new Videos(),
            new Videos(),
            new Videos()
        };
        foreach (Videos i in video){
            i.videoMethod();
            i.Display();
        }
    }
}

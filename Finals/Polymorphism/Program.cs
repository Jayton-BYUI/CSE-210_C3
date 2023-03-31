// Jayton Crockett
class Program{
    static void Main(string[] args){
        List<Activity> _activities = new List<Activity>(){
            new Cycling(),
            new Running(),
            new Swimming()
        };
        foreach(Activity i in _activities){
            i.getSummary();
        }
    }
}
class Program{
    static void Main(string[] args){
        Console.WriteLine("------------------------------------");
        Lectures lecture = new Lectures();
        lecture.getSDetails();
        lecture.getFDetails();
        lecture.getSDescription();
        Console.WriteLine("------------------------------------");

        Receptions reception = new Receptions();
        reception.getSDetails();
        reception.getFDetails();
        reception.getSDescription();
        Console.WriteLine("------------------------------------");

        Outdoor outdoor = new Outdoor();
        outdoor.getSDetails();
        outdoor.getFDetails();
        outdoor.getSDescription();
        Console.WriteLine("------------------------------------");
    }
}
using System;
public class Running:Activity{
    protected float _distance = 1;
    public Running(){
        _type = "Running";
        _date = DateTime.Now;

        Console.Write("Running ~\n What was the distance you ran: ");
        _distance = Convert.ToInt16(Console.ReadLine());

        Console.Write("Time Ran: ");       
        _time = Convert.ToInt16(Console.ReadLine());
    }
    public override float calculateDistance(){
        return _distance;
    }
    public override float calculateSpeed(){
        return _distance / _time * 60;
    }
}
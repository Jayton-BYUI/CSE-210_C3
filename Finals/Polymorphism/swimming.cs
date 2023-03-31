// Jayton Crockett
using System;
public class Swimming:Activity{
    protected float _laps = 1;
    protected float _distance = 1;
    public Swimming(){
    _type = "Swimming";
    _date = DateTime.Now;

    Console.Write("Swimming ~ \nNumber of laps swam: ");
    _laps = Convert.ToInt16(Console.ReadLine());
    
    Console.Write("Time swam: ");
    _laps = Convert.ToInt16(Console.ReadLine());
}
    public override float calculateDistance(){
        return (float)(_laps * 50 / 1000 * .62);
    }
    public override float calculateSpeed(){
        return calculateDistance() / _distance * 60;
    }
}
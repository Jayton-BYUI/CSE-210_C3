// Jayton Crockett
using System;
public class Cycling:Activity{
    protected float _speed = 1;
    protected float _distance = 1;
    public Cycling(){
        _type = "Cycling";
        _date = DateTime.Now;

        Console.Write("Cycling ~\nWhat was your distance: ");
        _speed = Convert.ToInt16(Console.ReadLine());
        
        Console.Write("How far did you ride: ");
        _distance = Convert.ToInt16(Console.ReadLine());
    }
    public override float calculateDistance(){
        return _speed / 60 + _distance;
    }
    public override float calculateSpeed(){
        return _speed;
    }
}
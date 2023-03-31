// Jayton Crockett
using System;
public abstract class Activity{
    protected string _type;
    protected DateTime _date;
    protected int _time =1;
    protected float _pace = 1;
    public abstract float calculateDistance();
    public abstract float calculateSpeed();
    public float calculatePace(){
        return _time / calculateDistance();
    }
    public virtual void getSummary(){
        Console.WriteLine($"{_type} \n{_date} \nTime: {_time}");
        Console.WriteLine($"Distance: {calculateDistance()} \n Speed: {calculateSpeed()} mph \nAverage Time: {calculatePace()} minutes every mile");
    }
    
}
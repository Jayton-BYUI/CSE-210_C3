// Jayton Crockett, Austin Reeves, Jacob Strong, Michael Torres, and Kyle Guo
public class Eternal:Goals{
   public Eternal(string name, string type, int point):base(name,type,point){}
   public override void Display(int i){
      Console.WriteLine($"The goals are:\n{i} [ ] {_jc_name} ({_jc_type})");
   }
   public override string Saveformat(){
      return $"Eternal Goals:{_jc_name},{_jc_type},{_jc_point}";
   }
   public override int CompletedGoals(){
      return _jc_point;
   }    
}
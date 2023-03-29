// Jayton Crockett, Austin Reeves, Jacob Strong, Michael Torres, and Kyle Guo
public class Checklist:Goals{
   public int _jc_goalCount;
   public int _jc_currentCount;
   public int _jc_bonusPoint;
   List<Goals> menuList= new List<Goals>();
   public Checklist(string name, string type, int point,int currentCount,int goalCount,int bonus):base(name,type,point){
      _jc_goalCount = goalCount;
      _jc_bonusPoint = bonus;
      _jc_currentCount = currentCount;
   }

   public override void Display(int i){
      if (isChecked){
         Console.WriteLine($"The goals are:\n{i} [x] {_jc_name} ({_jc_type})");
         Console.WriteLine($"Points completed:{_jc_currentCount}/{_jc_goalCount}");
         Console.WriteLine($"You have {_jc_point} points!");
      }    
      else{
         Console.WriteLine($"The goals are:\n{i} [x] {_jc_name} ({_jc_type})");
         Console.WriteLine($"Points completed:{_jc_currentCount}/{_jc_goalCount}");
      }               
   }
   public override string Saveformat(){
      return $"Checklist:{_jc_name},{_jc_type},{_jc_point},{_jc_currentCount},{_jc_goalCount},{_jc_bonusPoint}";
   }
   public override int CompletedGoals(){
      if (isChecked == false) {
         _jc_currentCount += 1;
      if ( _jc_currentCount == _jc_goalCount){
         isChecked = true;
         Console.WriteLine("!!!");
         return _jc_point + _jc_bonusPoint; 
      }else{
         return _jc_point;
      }}else{
         return 0;
      }    
   }
}

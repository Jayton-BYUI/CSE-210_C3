// Jayton Crockett, Austin Reeves, Jacob Strong, Michael Torres, and Kyle Guo
public class Goals
{
      public bool isChecked = false;
      public string _ar_name = "";
      public string _ar_type = "";
      public int _ar_point = 0;

   public Goals(string name, string type, int point){
      _ar_name = name;
      _ar_type = type;
      _ar_point = point;
   }
   public virtual void Display(int i){}
   public virtual int CompletedGoals(){
      if(isChecked == false){
         isChecked = true;
         return _point;
      }
      else{
         return 0;
      }
   }
   public virtual string Saveformat(){
      return "";
   }
}
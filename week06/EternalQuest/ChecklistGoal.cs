public class ChecklistGoal : Goal {
   private int _amountCompleted;
   private int _target;
   private int _bonus;

   public ChecklistGoal(string name, string description, string points, int target, int amountCompleted, int bonus) : base(name, description, points) {
      _amountCompleted = amountCompleted;
      _target = target;
      _bonus = bonus;
   }

   public override void RecordEvent() {
      if (!IsComplete()) {
         _amountCompleted += 1;
      }
   }
   public override bool IsComplete() {
      if (_amountCompleted >= _target) {
         return true;
      }
      else {
         return false;
      }
   }
   public override string GetDetailsString() {
      
      return $"{_shortName},{_description},{_points},{_target},{_amountCompleted},{_bonus}";
   }
   public override string GetStringRepresentation() {
      return $"ChecklistGoal:{GetDetailsString()}";
   }
}
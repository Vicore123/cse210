public class SimpleGoal : Goal {
   private bool _isComplete;

   public SimpleGoal(string name, string description, string points, bool isComplete) : base(name, description, points) {
      _isComplete = isComplete;
   }

   public override void RecordEvent() {
      _isComplete = true;
   }
   public override bool IsComplete() {
      return _isComplete;
   }
   public override string GetStringRepresentation() {
      return $"SimpleGoal:{GetDetailsString()},{_isComplete}";
      
   }
}
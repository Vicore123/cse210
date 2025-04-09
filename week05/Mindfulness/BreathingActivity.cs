public class BreathingActivity : Activity {
   
   public BreathingActivity() : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.") {}

   public void Run() {
      DisplayStartingMessage();
      for (int i=0; i<(int)Math.Ceiling((double)_duration / 10); i++) {
         Console.Write("Breathe in...");
         ShowCountDown(4);
         Console.WriteLine();
         Console.Write("Now Breathe out...");
         ShowCountDown(6);
         Console.WriteLine("\n");
      }
      DisplayEndingMessage();
   }
}
public class Activity {
   protected string _name;
   protected string _description;
   protected int _duration;

   public Activity(string name, string description) {
      _name = name;
      _description = description;
   }

   public void DisplayStartingMessage() {
      Console.Clear();
      Console.Write($"Welcome to the {_name} Activity \n\n{_description} \n\nHow long, in seconds, would you like for your session? ");
      _duration =  int.Parse(Console.ReadLine());
      Console.Clear();
      Console.WriteLine("Get ready...");
      ShowSpinner(5);
      Console.WriteLine();
   }

   public void DisplayEndingMessage() {
      Console.WriteLine("\nWell done!!");
      ShowSpinner(3);
      Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name} Activity");
      ShowSpinner(3);
   }

   public void ShowSpinner(int seconds) {
      
      for(int i = 0; i < seconds; i++) {
         Console.Write("-");
         Thread.Sleep(250);
         Console.Write("\b \b");
         Console.Write("\\");
         Thread.Sleep(250);
         Console.Write("\b \b");
         Console.Write("|");
         Thread.Sleep(250);
         Console.Write("\b \b");
         Console.Write("/");
         Thread.Sleep(250);
         Console.Write("\b \b");
      }
   }

   public void ShowCountDown(int seconds) {

      for(int i = seconds; i != 0; i--) {
         Console.Write(i);
         Thread.Sleep(1000);
         Console.Write("\b \b");
      }
   }

}
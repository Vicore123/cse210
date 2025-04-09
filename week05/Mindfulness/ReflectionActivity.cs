using System.Security.Cryptography;

public class ReflectingActivity : Activity {

   private List<string> _prompts;
   private List<string> _questions;

   public ReflectingActivity() : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.") {
      _prompts = [
         "Think of a time when you stood up for someone else.",
         "Think of a time when you did something really difficult.",
         "Think of a time when you helped someone in need.",
         "Think of a time when you did something truly selfless."
      ];
      _questions = [
         "Why was this experience meaningful to you? ",
         "Have you ever done anything like this before? ",
         "How did you get started? ",
         "How did you feel when it was complete? ",
         "What made this time different than other times when you were not as successful? ",
         "What is your favorite thing about this experience? ",
         "What could you learn from this experience that applies to other situations? ",
         "What did you learn about yourself through this experience? ",
         "How can you keep this experience in mind in the future? "         
      ];
   }

   public void Run() {

      DisplayStartingMessage();
      DisplayPrompt();
      Console.Write("Now ponder on each of the following questions as they related to this experience. \nYou may begin in: ");
      ShowCountDown(5);
      Console.Clear();
      for (int i=0; i<(int)Math.Ceiling((double)_duration / 15); i++) {
         DisplayQuestion();
      }
      DisplayEndingMessage();
   }

   public string GetRandomPrompt() {
      Random random = new Random();
      int RandomNumber = random.Next(_prompts.Count);
      return _prompts[RandomNumber];
   }

   public string GetRandomquestion() {
      Random random = new Random();
      int RandomNumber = random.Next(_questions.Count);
      return _questions[RandomNumber];
   }

   public void DisplayPrompt() {
      Console.WriteLine("Consoder the following prompt:\n");
      Console.WriteLine($" --- {GetRandomPrompt()} ---\n");
      Console.WriteLine("When you have something in mind, press enter to continue");
      Console.ReadLine();
   }

   public void DisplayQuestion() {
     Console.Write(GetRandomquestion());
     ShowSpinner(15);
     Console.WriteLine();
   }

}
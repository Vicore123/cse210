public class ListingActivity : Activity {

   private int _count;
   private List<string> _prompts;
   public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") {
      _prompts = [
         "Who are people that you appreciate?",
         "What are personal strengths of yours?",
         "Who are people that you have helped this week?",
         "When have you felt the Holy Ghost this month?",
         "Who are some of your personal heroes?"];
   }

   public void Run() {
      DisplayStartingMessage();

      Console.WriteLine("List as many responses you can to the following prompt:");
      GetRandomPrompt();
      Console.Write("You may begin in: ");
      ShowCountDown(5);
      Console.WriteLine();
      DateTime endtime = DateTime.Now.AddSeconds(_duration);
      while(DateTime.Now < endtime) {
         Console.ReadLine();
         _count++;
      }
      Console.WriteLine($"You listed {_count} items!");

      DisplayEndingMessage();
   }

   public void GetRandomPrompt() {
      Random random = new Random();
      int RandomNumber = random.Next(_prompts.Count);
      Console.WriteLine($" --- {_prompts[RandomNumber]} ---");
   }

   // public List<string> GetListFromUser() {
      
   //    return
   // }
}
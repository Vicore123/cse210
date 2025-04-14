using System.IO;

public class GoalManager {
   private List<Goal> _goals = new List<Goal>();
   private int _score = 0;
   
   public GoalManager() {}

   public void Start() {
      // Console.Clear();
      DisplayPlayerInfo();
      Console.WriteLine("Menu Options:");
      Console.WriteLine("  1. Create New Goal");
      Console.WriteLine("  2. List Goals");
      Console.WriteLine("  3. Save Goals");
      Console.WriteLine("  4. Load Goals");
      Console.WriteLine("  5. Record Event");
      Console.WriteLine("  6. Quit");
      Console.Write("Select a choice from the menu: ");

   }
   public void DisplayPlayerInfo() {
      Console.WriteLine($"\nYou have {_score} points.\n");
   }
   public void ListGoalNames() {
      int i = 1;
      Console.WriteLine("The goals are:");
      foreach (Goal goal in _goals) {
         Console.WriteLine($" {i}. {goal.GetDetailsString().Split(",")[0]}");
         i++;
      }
   }
   public void ListGoalDetails() {
      Console.WriteLine("The goals are:");
      int i = 1;

      foreach (Goal goal in _goals) {
         string[] details = goal.GetDetailsString().Split(",");
         string shortName = details[0];
         string description = details[1];
         string points = details[2];

         string completedIcon = "[ ]";
         if (goal.IsComplete()) {
            completedIcon = "[x]";
         }

         if (details.Length < 6) {
            Console.WriteLine($"{i}. {completedIcon} {shortName} ({description})");
         }
         else {
            string target = details[3];
            string amountCompleted = details[4];
            string bonus = details[5];
            Console.WriteLine($"{i}. {completedIcon} {shortName} ({description}) -- Currently completed: {amountCompleted}/{target}");
         }
         i++;
      }
   }
   public void CreateGoal() {
      Console.WriteLine("The tyes of Gals are:");
      Console.WriteLine("  1. Simple Goal");
      Console.WriteLine("  2. Eternal Goal");
      Console.WriteLine("  3. Checklist Goal");
      Console.Write("Which type of goal would you like to create? ");
      int choice = int.Parse(Console.ReadLine());
      

      Console.Write("What is the name of your goal? ");
      string name = Console.ReadLine();
      Console.Write("What is a short description of it? ");
      string description = Console.ReadLine();
      Console.Write("What is the amount of points associated with this goal? ");
      string points = Console.ReadLine();

      if (choice == 1) {
         SimpleGoal goal = new SimpleGoal(name, description, points, false);
         _goals.Add(goal);
      }
      else if (choice == 2) {
         EternalGoal goal = new EternalGoal(name, description, points);
         _goals.Add(goal);
      }
      else if (choice == 3) {
         Console.Write("How many times does this goal need to be accomplished for a bonus? ");
         int target = int.Parse(Console.ReadLine());
         Console.Write("What is the bonus for accomplishing it that many times? ");
         int bonus = int.Parse(Console.ReadLine());

         ChecklistGoal goal = new ChecklistGoal(name, description, points, target, 0, bonus);
         _goals.Add(goal);
      }
      else {
         Console.WriteLine("Invalid answer, please try again");
      }
   }
   public void RecordEvent() {
      int choice;
      ListGoalNames();
      Console.Write("Which goal did you accomplish? ");
      choice = int.Parse(Console.ReadLine()) -1;
      string[] details = _goals[choice].GetDetailsString().Split(",");

      if (!_goals[choice].IsComplete()) {
         _goals[choice].RecordEvent();
         _score += int.Parse(details[2]);

         if (details.Count() >= 6) {
            if (int.Parse(details[4]) >= int.Parse(details[3])-1) {
               _score += int.Parse(details[5]);
            }
         }
      }
      else {
         Console.WriteLine("This goal was already complited");
      }
   }
   public void SaveGoals() {
      Console.Write("What is the filename for the goal file? ");
      string fileName = Console.ReadLine();

      using (StreamWriter outputFile = new StreamWriter(fileName))
      {
         outputFile.WriteLine(_score);
         foreach (Goal goal in _goals) {
            outputFile.WriteLine(goal.GetStringRepresentation());
         }
      }
   }
   public void LoadGoals() {
      Console.Write("What is the filename for the goal file? ");
      string fileName = Console.ReadLine();
      string[] lines = System.IO.File.ReadAllLines(fileName);
      _score = int.Parse(lines[0]);
      _goals.Clear();

      foreach (string line in lines.Skip(1)) {

         string goalType = line.Split(":")[0];
         string[] parts = line.Split(":")[1].Split(",");

         if (goalType == "SimpleGoal") {
            SimpleGoal goal = new SimpleGoal(parts[0], parts[1], parts[2], bool.Parse(parts[3]));
            _goals.Add(goal);
         }
         if (goalType == "EternalGoal") {
            EternalGoal goal = new EternalGoal(parts[0], parts[1], parts[2]);
            _goals.Add(goal);
         }
         if (goalType == "ChecklistGoal") {
            ChecklistGoal goal = new ChecklistGoal(parts[0], parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
            _goals.Add(goal);
         }
         
      }
   }
};
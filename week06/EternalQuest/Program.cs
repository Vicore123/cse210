// I added some error treatment inside the menus, it is not complete, but I cover almost all input erros I could think of

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        int choice = 0;

        while (choice != 6) {
            goalManager.Start();
            try {
                choice = int.Parse(Console.ReadLine());
            } catch {
                Console.WriteLine("Type a number");
            }
            

            if (choice == 1) {
                goalManager.CreateGoal();
            }
            else if (choice == 2) {
                goalManager.ListGoalDetails();
            }
            else if (choice == 3) {
                goalManager.SaveGoals();
            }
            else if (choice == 4) {
                goalManager.LoadGoals();
            }
            else if (choice == 5) {
                goalManager.RecordEvent();
            }
            else {
                Console.WriteLine("Please, type a valid answer.");
            }
        }
    }
}
// For the Showing Creativity and Exceeding Requirements I added a functionality where now you can keep track of how many activities you have done so far

using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectingActivity reflectingActivity = new ReflectingActivity();
        ListingActivity listingActivity = new ListingActivity();    
        int choice = 0;
        int activities = 0;

        while (choice != 4) {
            Console.Clear();
            Console.WriteLine($"You performed {activities} activities in this session\n");
            Console.WriteLine("Menu options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. quit");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1) {
                breathingActivity.Run();
                activities++;
            }
            else if (choice == 2) {
                reflectingActivity.Run();
                activities++;
            }
            else if (choice == 3) {
                listingActivity.Run();
                activities++;
            }
            else if (choice == 4) {
                Console.WriteLine("See you next time!");
            }
            else {
                Console.Write("Please select a valid option. ");
                breathingActivity.ShowSpinner(4);
            }
        }
    }
}
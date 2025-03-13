using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        Journal journal = new Journal();

        while (choice != 5) {
        Console.WriteLine("Welcome to Journal program! Please select the desired option:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Save");
        Console.WriteLine("4. Load");
        Console.WriteLine("5. Quit");
        Console.Write("What you would like to do? ");
        choice = int.Parse(Console.ReadLine());

        if (choice == 1) {
            Entry entry = new Entry();
            Console.WriteLine(entry._promptText);
            entry._entryText = Console.ReadLine();
            journal.AddEntry(entry);
        }
        else if (choice == 2) {
            journal.DisplayAll();
        }
        else if (choice == 3) {
            Console.Write("file name: ");
            journal.SaveToFile(Console.ReadLine());
        }
        else if (choice == 4) {
            Console.Write("file name: ");
            journal.LoadFromFile(Console.ReadLine());
        }
    }  
        
    }
}
using System;
using System.Net.Quic;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart and lean not unto thine own understanding; In all thy ways acknowledge him, and he shall direct thy paths.");

        string entry = "";

        Console.Write(reference.GetDisplayText());
        Console.WriteLine(scripture.GetDisplayText() + "\n");
        
        Console.WriteLine("Press enter to continue or type 'quit' to finish:");
        entry = Console.ReadLine();

        while (entry != "quit" && !scripture.IsCompletelyHidden()) {
            
            Console.Clear();
            scripture.HideRandomWords(3);
            Console.Write(reference.GetDisplayText());
            Console.WriteLine(scripture.GetDisplayText() + "\n");
            
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            entry = Console.ReadLine();
        }
    }
}
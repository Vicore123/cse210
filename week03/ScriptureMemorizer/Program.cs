using System;
using System.Net.Quic;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart and lean not unto thine own understanding; In all thy ways acknowledge him, and he shall direct thy paths.");

        string entry = "";

        Console.Clear();
        Console.Write(reference.GetDisplayText());
        Console.WriteLine(scripture.GetDisplayText() + "\n");
        
        Console.WriteLine("Hide more words: Press enter\nShow all Words: Press 1\nQuit: type 'quit'");
        entry = Console.ReadLine();

        while (entry != "quit" && !scripture.IsCompletelyHidden()) {
            
            Console.Clear();
            if (entry == "1") {
                scripture.ShowAll();
            }
            else {
                scripture.HideRandomWords(3);
            }

            Console.Write(reference.GetDisplayText());
            Console.WriteLine(scripture.GetDisplayText() + "\n");
            
            Console.WriteLine("Hide more words: Press enter\nShow all Words: Press 1\nQuit: type 'quit'");
            entry = Console.ReadLine();
        }
    }
}
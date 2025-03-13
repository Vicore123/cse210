public class Entry
{ 
    public string _date;
    public string _promptText;
    public string _entryText;
    
    public Entry ()
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        _promptText = promptGenerator.GetRandomPrompt();

        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();
    }
    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}\n{_entryText}\n");
    }
}

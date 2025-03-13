public class PromptGenerator
{ 
    public Random random;
    public List<string> _prompts;
    
    public string GetRandomPrompt()
    {
        random = new Random();
        _prompts = new List<string>
        {
            "What made you happy today?",
            "What did you eat today?",
            "Did you learn something new?",
            "How do you feel right now?",
            "What was the best part of your day?",
            "What do you want to do tomorrow?",
            "What is your favorite thing about today?",
            "What is something you are grateful for?"
        };
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}

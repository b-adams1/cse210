
public class PromptGenerator
{
    public List<string> _prompts = [
        "What is the best thing that happened to you today?",
        "What is one mistake you made today?",
        "What is your favorite conversation you had today?",
        "What is one thing that frustrated you today?",
        "How did you help someone today?"
    ];

    public string Prompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string rPrompt = _prompts[index];
        return rPrompt;
    }
}

public class Prompt
{
    //Create lists for each type of prompt
    public List<string> _quickPrompts = new List<string> {"Describe today in 3 words or less.",
    "What is one thing you're looking forward to in the next 24 hours?",
    "What emotion are you feeling right now?","If you had to pick a song to describe your day, it would be...",
    "Write the first word that comes to mind."};
    public List<string> _reflectivePrompts = new List<string> {"What did you learn about yourself today?",
    "How did you see the Lord's hand in your life today?","How did you improve today, and how can you improve tomorrow?",
    "How did you serve others today?","How well did you manage your emotions today?"};
    public List<string> _creativePrompts = new List<string> {"Write a haiku that describes today.",
    "If you could relive today but you had one super power, what super power would you chose and why?",
    "Write about your day as if it had taken place in your favorite fictional universe.",
    "Imagine you had lived this day as someone you interacted with. Write a journal entry from their perspective.",
    "Write to your younger self about how your day was."};

    //Create a random instance
    public Random random = new Random();

    //Display a random quick prompt
    public string GenerateQuickPrompt()
    {
        int randomIndex = random.Next(_quickPrompts.Count);
        return _quickPrompts[randomIndex];
    }

    //Display a random reflective prompt
    public string GenerateReflectivePrompt()
    {
        int randomIndex = random.Next(_reflectivePrompts.Count);
        return _reflectivePrompts[randomIndex];
    }

    //Display a random fun prompt
    public string GenerateCreativePrompt()
    {
        int randomIndex = random.Next(_creativePrompts.Count);
        return _creativePrompts[randomIndex];
    }
}

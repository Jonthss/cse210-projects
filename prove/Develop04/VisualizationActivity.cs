class VisualizationActivity : BaseActivity
{
    public VisualizationActivity(int duration, ActivityLog log) : base(duration, log)
    {
    }

    public void StartActivity()
    {
        DisplayStartingMessage();

        // Countdown for visualization activity
        Countdown(3);

        // Display visualization prompts
        VisualizePrompts();

        DisplayEndingMessage();
    }

    private void VisualizePrompts()
    {
        List<string> prompts = new List<string>
        {
            "Imagine yourself on a peaceful beach...",
            "Visualize a serene mountain landscape...",
            "Picture a calm and quiet forest...",
            "Envision a beautiful sunset over a tranquil lake..."
        };

        for (int i = 0; i < durationInSeconds; i++)
        {
            DisplayVisualizationPrompt(prompts[i % prompts.Count]);
            Thread.Sleep(1000);
        }
    }

    private void DisplayVisualizationPrompt(string prompt)
    {
        Console.Clear();
        Console.WriteLine("=====================================");
        Console.WriteLine("  Visualization Activity         ");
        Console.WriteLine("=====================================");
        Console.WriteLine($"This activity will guide you through visualization, helping you create a mental image for relaxation.\n");

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.SetCursorPosition((Console.WindowWidth - prompt.Length) / 2, Console.WindowHeight / 2);
        Console.WriteLine(prompt.PadLeft((Console.WindowWidth + prompt.Length) / 2));
        Console.ResetColor();
    }

    private void DisplayEndingMessage()
    {
        Console.WriteLine("\n=====================================");
        Console.WriteLine(" Visualization Activity Complete ");
        Console.WriteLine($"Total time: {durationInSeconds} seconds");
        Thread.Sleep(3000); // Pause for 3 seconds

        // Log the completion of the activity
        activityLog.LogActivity("Visualization Activity");
    }
}

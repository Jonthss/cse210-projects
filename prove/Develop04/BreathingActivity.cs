class BreathingActivity
{
    private int durationInSeconds;
    private ActivityLog activityLog;

    public BreathingActivity(int duration, ActivityLog log)
    {
        this.durationInSeconds = duration;
        this.activityLog = log;
    }

    public void StartActivity()
    {
        DisplayStartingMessage();

        // Countdown for breathing activity
        Countdown(3);

        // Display breathing messages
        BreatheMessages();

        DisplayEndingMessage();
    }

    private void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine("=====================================");
        Console.WriteLine("      Breathing Activity         ");
        Console.WriteLine("=====================================");
        Console.WriteLine($"This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.\n");
    }

    private void Countdown(int seconds)
    {
        Console.WriteLine($"Prepare to begin in {seconds} seconds...\n");
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"  {i}...");
            Thread.Sleep(1000); // Pause for 1 second
            Console.SetCursorPosition(Console.CursorLeft - 4, Console.CursorTop);
        }
        Console.WriteLine("\nBegin breathing!\n");
    }

private void BreatheMessages()
{
    for (int i = 0; i < durationInSeconds; i++)
    {
        double progress = (double)i / durationInSeconds;

        // Quadratic easing for smoother animation
        double easing = Math.Pow(progress - 0.5, 2) * 4;

        int fontSize = CalculateFontSize(progress);
        DisplayBreathingMessage("Breathe in...", fontSize);
        Thread.Sleep(1500);  // Ajuste o valor para tornar a animação mais lenta

        DisplayBreathingMessage("Breathe out...", fontSize);
        Thread.Sleep(1500);  // Ajuste o valor para tornar a animação mais lenta
    }
}

    private int CalculateFontSize(double progress)
    {
        int maxFontSize = 30;
        int minFontSize = 10;

        // Quadratic easing for smoother animation
        double easing = Math.Pow(progress - 0.5, 2) * 4;

        int fontSizeRange = maxFontSize - minFontSize;
        int fontSize = minFontSize + (int)(easing * fontSizeRange);

        return fontSize;
    }

        private void DisplayBreathingMessage(string message, int fontSize)
    {
        Console.Clear();
        Console.WriteLine("=====================================");
        Console.WriteLine("      Breathing Activity         ");
        Console.WriteLine("=====================================");
        Console.WriteLine($"This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.\n");

        Console.ForegroundColor = ConsoleColor.Green;

        // Simula um efeito de digitação
        for (int i = 0; i <= message.Length; i++)
        {
            int leftPadding = 2;  // Ajuste conforme necessário
            int topPadding = Console.WindowHeight / 2;

            Console.SetCursorPosition(leftPadding, topPadding);
            Console.Write(message.Substring(0, i));
            Console.ResetColor();

            Thread.Sleep(50);  // Ajuste o valor para controlar a velocidade da digitação
        }
    }

    private void DisplayEndingMessage()
    {
        Console.WriteLine("\n=====================================");
        Console.WriteLine("    Breathing Activity Complete     ");
        Console.WriteLine($"Total time: {durationInSeconds} seconds");
        Thread.Sleep(3000); // Pause for 3 seconds

        // Log the completion of the activity
        activityLog.LogActivity("Breathing Activity");
    }
}
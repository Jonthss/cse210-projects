class ReflectionActivity
{
    private int durationInSeconds;
    private ActivityLog activityLog;

    public ReflectionActivity(int duration, ActivityLog log)
    {
        this.durationInSeconds = duration;
        this.activityLog = log;
    }

    public void StartActivity()
    {
        DisplayStartingMessage();

        // Countdown for reflection activity
        Countdown(3);

        // Display reflection prompts
        ReflectOnPrompts();

        DisplayEndingMessage();
    }

    private void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine("=====================================");
        Console.WriteLine("      Reflection Activity         ");
        Console.WriteLine("=====================================");
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.\n");
    }

    private void Countdown(int seconds)
    {
        Console.WriteLine($"Prepare to begin in {seconds} seconds...\n");
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"  {i}...");
            Thread.Sleep(1000); // Pause for 1 second
        }
        Console.WriteLine("\nBegin reflection!\n");
    }

    private void ReflectOnPrompts()
    {
        for (int i = 0; i < durationInSeconds; i++)
        {
            double progress = (double)i / durationInSeconds;
            int fontSize = CalculateFontSize(progress);

            string prompt = GetRandomPrompt();
            DisplayReflectionPrompt(prompt, fontSize);

            string question = GetRandomQuestion();
            ReflectOnQuestion(question);

            Thread.Sleep(1000);
        }
    }

    private void DisplayReflectionPrompt(string prompt, int fontSize)
    {
        Console.Clear();
        Console.WriteLine("=====================================");
        Console.WriteLine("    Reflection Activity         ");
        Console.WriteLine("=====================================");
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.\n");

        Console.ForegroundColor = ConsoleColor.Cyan;

        // Simula um efeito de digitação
        for (int i = 0; i <= prompt.Length; i++)
        {
            int leftPadding = 2;  // Ajuste conforme necessário
            int topPadding = Console.WindowHeight / 2;

            Console.SetCursorPosition(leftPadding, topPadding);
            Console.Write(prompt.Substring(0, i));
            Console.ResetColor();

            Thread.Sleep(50);  // Ajuste o valor para controlar a velocidade da digitação
        }

        Console.WriteLine();  // Adiciona uma nova linha após a mensagem digitada
    }

    private void ReflectOnQuestion(string question)
    {
        // Simula um efeito de digitação para a pergunta
        for (int i = 0; i <= question.Length; i++)
        {
            int leftPadding = 2;  // Ajuste conforme necessário
            int topPadding = Console.WindowHeight / 2 + 2;

            Console.SetCursorPosition(leftPadding, topPadding);
            Console.Write(question.Substring(0, i));
            Console.ResetColor();

            Thread.Sleep(50);  // Ajuste o valor para controlar a velocidade da digitação
        }

        Console.WriteLine();  // Adiciona uma nova linha após a pergunta digitada
    }

    private string GetRandomPrompt()
    {
        List<string> prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        // Return a random prompt
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }

    private string GetRandomQuestion()
    {
        List<string> questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        // Return a random question
        Random random = new Random();
        int index = random.Next(questions.Count);
        return questions[index];
    }

    private void DisplayEndingMessage()
    {
        Console.WriteLine("\n=====================================");
        Console.WriteLine("    Reflection Activity Complete     ");
        Console.WriteLine($"Total time: {durationInSeconds} seconds");
        Thread.Sleep(3000); // Pause for 3 seconds

        // Log the completion of the activity
        activityLog.LogActivity("Reflection Activity");
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
}
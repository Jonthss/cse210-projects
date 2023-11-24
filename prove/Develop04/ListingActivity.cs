class ListingActivity
{
    private int durationInSeconds;
    private ActivityLog activityLog;

    public ListingActivity(int duration, ActivityLog log)
    {
        this.durationInSeconds = duration;
        this.activityLog = log;
    }

    public void StartActivity()
    {
        DisplayStartingMessage();

        // Countdown for listing activity
        Countdown(3);

        // Display listing prompts
        List<string> listedItems = ListItems();

        DisplayEndingMessage(listedItems);
    }

    private void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine("=====================================");
        Console.WriteLine("      Listing Activity         ");
        Console.WriteLine("=====================================");
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n");
    }

    private void Countdown(int seconds)
    {
        Console.WriteLine($"Prepare to begin in {seconds} seconds...\n");
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"  {i}...");
            Thread.Sleep(1000); // Pause for 1 second
        }
        Console.WriteLine("\nBegin listing!\n");
    }

    private List<string> ListItems()
    {
        List<string> listedItems = new List<string>();
        Console.WriteLine("Think about:");

        // Display random prompt
        string prompt = GetRandomPrompt();
        Console.WriteLine($"- {prompt}\n");

        Console.WriteLine($"You have {durationInSeconds} seconds to list as many items as you can.\n");

        // Allow the user to list items for the specified duration
        DateTime endTime = DateTime.Now.AddSeconds(durationInSeconds);
        while (DateTime.Now < endTime)
        {
            Console.Write("Enter an item: ");
            string item = Console.ReadLine();
            listedItems.Add(item);
        }

        return listedItems;
    }

    private string GetRandomPrompt()
    {
        List<string> prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        // Return a random prompt
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }

    private void DisplayEndingMessage(List<string> listedItems)
    {
        Console.WriteLine("\n=====================================");
        Console.WriteLine("      Listing Activity Complete     ");
        Console.WriteLine($"Total time: {durationInSeconds} seconds");
        Console.WriteLine($"Number of items listed: {listedItems.Count}");
        Thread.Sleep(3000); // Pause for 3 seconds

        // Log the completion of the activity
        activityLog.LogActivity("Listing Activity");
    }
}
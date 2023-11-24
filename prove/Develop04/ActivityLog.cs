class ActivityLog
{
    private Dictionary<string, int> activityCount;

    public ActivityLog()
    {
        activityCount = new Dictionary<string, int>();
    }

    public void LogActivity(string activityName)
    {
        if (activityCount.ContainsKey(activityName))
        {
            activityCount[activityName]++;
        }
        else
        {
            activityCount.Add(activityName, 1);
        }

        Console.WriteLine($"\nActivity Log:");
        foreach (var entry in activityCount)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value} times");
        }
    }
}

class BaseActivity
{
    protected int durationInSeconds;
    protected ActivityLog activityLog;

    public BaseActivity(int duration, ActivityLog log)
    {
        this.durationInSeconds = duration;
        this.activityLog = log;
    }

    protected void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine("=====================================");
        Console.WriteLine("         Activity             ");
        Console.WriteLine("=====================================");
        Console.WriteLine($"This is a generic activity. Override this method in specific activities.\n");
    }

    protected void Countdown(int seconds)
    {
        Console.WriteLine($"Prepare to begin in {seconds} seconds...\n");
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"  {i}...");
            Thread.Sleep(1000); // Pause for 1 second
        }
        Console.WriteLine("\nBegin activity!\n");
    }
}
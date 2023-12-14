using System;

class Activity
{
    public string Date { get; private set; }
    public int Duration { get; private set; }

    public Activity(string date, int duration)
    {
        Date = date;
        Duration = duration;
    }

    public virtual double GetDistance()
    {
        return 0.0; // Default implementation for activities without distance tracking
    }

    public virtual double GetSpeed()
    {
        return 0.0; // Default implementation for activities without speed tracking
    }

    public virtual double GetPace()
    {
        return 0.0; // Default implementation for activities without pace tracking
    }

    public virtual string GetSummary()
    {
        return $"{Date} - {GetType().Name} ({Duration} min)";
    }
}

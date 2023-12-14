class Swimming : Activity
{
    private int laps;

    public Swimming(string date, int duration, int laps)
        : base(date, duration)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        // Convert laps to kilometers
        return laps * 50.0 / 1000.0;
    }

    public override double GetSpeed()
    {
        return GetDistance() / (Duration/60.0);
    }

    public override double GetPace()
    {
        return 60.0 / GetSpeed();
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance {GetDistance()} km, Speed {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}

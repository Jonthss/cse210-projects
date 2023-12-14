class Cycling : Activity
{
    private double speed;

    public Cycling(string date, int duration, double speed)
        : base(date, duration)
    {
        this.speed = speed;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetPace()
    {
        return 60.0 / speed;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Speed: {speed} mph, Pace: {GetPace()} min per mile";
    }
}

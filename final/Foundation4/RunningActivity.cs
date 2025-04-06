public class RunningActivity : Activity
{
    private double _distance;

    public RunningActivity(string date, double minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
        _activityName = "Running";
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return GetDistance() / _minutes * 60;
    }

    public override double GetPace()
    {
        return _minutes / GetDistance();
    }
}
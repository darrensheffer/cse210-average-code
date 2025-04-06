using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities =
        [
            new RunningActivity("03/14/2025", 90, 3),
            new BikingActivity("05/04/2025", 60, 15),
            new SwimmingActivity("03/25/2025", 20, 5)
        ];

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
        Console.WriteLine("");
    }
}
using System.ComponentModel;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. " + "\nClear your mind and focus on your breathing.")
    {}

    public void RunBreathing()
    {
        DisplayStartMessage();
        
        int duration = GetDuration();
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(duration);

        while (currentTime < endTime)
        {
            CountdownAnimation("Breathe in...", 4);
            CountdownAnimation("Breathe out...", 6);
            currentTime = DateTime.Now;
            if (currentTime >= endTime)
            {
                break;
            }
            Console.WriteLine("");
        }

        DisplayEndMessage();
    }
}
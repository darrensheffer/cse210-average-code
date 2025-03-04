using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectionActivity reflectionActivity = new ReflectionActivity();

        int choice = 0;
        while(choice != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());
     
            if (choice == 1)
            {
                breathingActivity.RunBreathing();
            }

            else if (choice == 2)
            {
                reflectionActivity.RunReflectionActivity();
            }

            else if (choice == 3)
            {
                break;
            }

            else if (choice == 4)
            {
                break;
            }
        }
    }
}
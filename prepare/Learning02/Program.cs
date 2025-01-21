using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Apple";
        job1._yearStart = 1995;
        job1._yearEnd = 2000;
        

        Job job2 = new Job();
        job2._jobTitle = "Game Developer";
        job2._company = "Microsoft";
        job2._yearStart = 2020;
        job2._yearEnd = 2025;

        Resume myResume = new Resume();
        myResume._userName = "John Doe";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayJobDetails();
        Console.WriteLine("");
    }
}
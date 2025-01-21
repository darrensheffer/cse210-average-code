using System;

public class Job
{
    public string _jobTitle;
    public string _company;
    public int _yearStart;
    public int _yearEnd;

    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_yearStart}-{_yearEnd}");
    }
}
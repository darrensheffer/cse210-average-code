using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Assignment assignment1 = new Assignment("Darren", "Multiplication");
        Console.WriteLine(assignment1.GetSummary());

        Console.WriteLine();

        MathAssignment assignment2 = new MathAssignment("Darren Sheffer", "Subtraction", "8.5", "1-100");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());

        Console.WriteLine();

        WritingAssignment assignment3 = new WritingAssignment("Darren Sheffer", "History", "The Best Day Ever");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}
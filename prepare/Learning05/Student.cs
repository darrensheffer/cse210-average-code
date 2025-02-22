public class Student : Person
{
        public string GetNumber()
    {
        Console.Write("Please enter your student number: ");
        string studentNumber = Console.ReadLine();
        return studentNumber;
    }
}
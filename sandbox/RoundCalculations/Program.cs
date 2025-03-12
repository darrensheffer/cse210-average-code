namespace RoundCalculations;

class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle(5);
        Circle.Cylinder cylinder = new Circle.Cylinder(5, 2);

        Console.WriteLine(cylinder);
    }
}

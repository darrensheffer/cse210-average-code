namespace Sandbox3;

class Program
{
    static void Main(string[] args)
    {
        Fox fox = new Fox("fox");
        Bird bird = new Bird("blackbird");
        fox.MakeSound();
        bird.MakeSound();

    }
}

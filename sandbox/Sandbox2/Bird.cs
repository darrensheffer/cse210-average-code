class Bird : Animal
{
    private string _sound = "Caw";

    public Bird(string name) : base(name)
    {
        _sound = Caw;
    }

    public void MakeSound()
    {
        Console.WriteLine($"{bird} says {_sound}.\a");
    }
}

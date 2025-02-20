class Fox : Animal
{
    private string _sound = "HA";

    public void MakeSound()
    {
        Console.WriteLine($"{fox} says {_sound}.\a");
    }
}
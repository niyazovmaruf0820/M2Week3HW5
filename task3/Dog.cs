namespace task3;

public class Dog : Animal
{
    public override void Eat()
    {
        System.Console.WriteLine($"The dog named {Name} is eating meat");
    }
}

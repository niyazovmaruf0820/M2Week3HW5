namespace task1;

public class Teacher : Person
{
    public Teacher(string name) : base(name) 
    {
        
    }
    public void Expain()
    {
        System.Console.WriteLine("The teacher is explaining");
    }
}

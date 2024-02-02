namespace task1;

public class Student : Person
{
    public Student(string name) : base(name) 
    {
        
    }
    public void Study()
    {
        System.Console.WriteLine("The student is studying");
    }
}

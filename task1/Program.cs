using task1;
List<Person> people = new List<Person>();
Student student1 = new Student("Maruf");
Student student2 = new Student("Dave");
Teacher teacher = new Teacher("mr.Alijon");
people.Add(student1);
people.Add(student2);
people.Add(teacher);
foreach (var item in people)
{
    System.Console.WriteLine("Name: " + item.Name);
}
student1.Study();
student2.Study();
teacher.Expain();
System.Console.WriteLine(student1.ToString());
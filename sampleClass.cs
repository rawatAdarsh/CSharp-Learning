
Student student1 = new Student();
student1.name = "Rahul";
student1.age = 20;

Student student2 = new Student();
student2.name = "Rohit";
student2.age = 22;

student1.study();
student2.study();
class Student
{
    public string name;
    public int age;

    public void study()
    {
        Console.WriteLine($"{name} is studying.");
    }
}


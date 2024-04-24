
class Assessment1
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>
        {
            new Student { Name = "student1", Age = 20, Class = "A" },
            new Student { Name = "student2", Age = 15, Class = "B" },
            new Student { Name = "student3", Age = 29, Class = "C" },
            new Student { Name = "student4", Age = 17, Class = "D" }
        };


        //AgeValid(students);
        AgeValid2(students);
       
    }

    static void AgeValid(List<Student> students)
    {
        var result = from student in students
                     where student.Age > 18
                     select student;

        Console.WriteLine("Students whose age is greater than 18:");
        foreach (var student in result)
        {
            Console.WriteLine($"Name: {student.Name}, Class: {student.Class}");
        }
    }

    static void AgeValid2(List<Student> students)
    {
        var result = students.Where(student => student.Age > 18);

        Console.WriteLine("Students whose age is greater than 18:");
        foreach (var student in result)
        {
            Console.WriteLine($"Name: {student.Name}, Class: {student.Class}");
        }
    }

}

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Class { get; set; }
}

/*
Student student = new Student("Tomáš", 18);
Console.WriteLine("Student name: " + student.Name);
student.Greet();
ChangeStudent(student);
student.Greet();

void ChangeStudent(Student s)
{
    s.Name = "Nothing";
}


Wall wall = new Wall(20, 30, "cihly");
Console.WriteLine("Informace o zdi: ");
wall.PrintInfo();


Console.Clear();
book book = new book("NAzev autora", 2026, 193, "Moje knizka");
book.printInfo();

*/

Console.Clear();
List<Student> studlist = new List<Student>();

while (true)
{
    Console.Write("Name: ");
    string? name = Console.ReadLine();

    if (name == "q" || string.IsNullOrWhiteSpace(name))
    {
        break;
    }
    Console.Write("Age: ");
    int age = int.Parse(Console.ReadLine());
    studlist.Add(new Student(name, age));
}

foreach (Student student in studlist)
{
    student.Greet();
}
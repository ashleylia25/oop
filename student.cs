class Student
{
    public int Age;
    public string Name;

    public Student(int age, string name)
    {
        this.Age = age;
        this.Name = name;
    }

    public void Greet()
    {
        Console.WriteLine("Dobry den pane uciteli. Jmenuju se: " + Name);
    }
}
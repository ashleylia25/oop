class Student
{
    public int Age;
    public string Name;

    public Student(string name, int age)
    {
        this.Age = age;
        this.Name = name;
    }

    public void Greet()
    {
        Console.WriteLine("Dobry den pane uciteli. Jmenuju se " + Name + " a je mi " + Age);
    }
}
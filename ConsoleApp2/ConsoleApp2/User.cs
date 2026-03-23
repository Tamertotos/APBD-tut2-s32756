namespace ConsoleApp2;

public class User
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Surname { get; set; }
    private int Id = 0;
    public string Type { get; set; }
    public int rentCount { get; set; }

    public User(string name, int age, string surname, string type)
    {
        Name = name;
        Age = age;
        Surname = surname;
        Type = type;
        Id++;
    }

    public override string ToString()
    {
        return Name;
    }
}
namespace ConsoleApp2;

public abstract class User
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Surname { get; set; }
    private int Id = 0;
    public string Type { get; set; }

    protected User(string name, int age, string surname, string type)
    {
        Name = name;
        Age = age;
        Surname = surname;
        Type = type;
        Id++;
    }
}
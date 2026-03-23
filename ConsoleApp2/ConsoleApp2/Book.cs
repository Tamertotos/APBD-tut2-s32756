namespace ConsoleApp2;

public class Book : Equipment
{
    public string Author { get; set; }
    public string Genre { get; set; }

    public Book(string name, bool isAvailable, int price, string author, string genre)
        : base(name, isAvailable, price)
    {
        Author = author;
        Genre = genre;
    }

    public override string ToString()
    {
        return Name;
    }
}
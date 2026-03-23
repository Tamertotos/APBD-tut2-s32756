namespace ConsoleApp2;

public abstract class Equipment
{
    public string Name { get; set; }
    protected static int Id = 0;
    public bool IsAvailable { get; set;  }
    public int Price { get; set; }

    public Equipment(string name, bool isAvailable, int price)
    {
        Id++;
        Name = name;
        IsAvailable = isAvailable;
        Price = price;
    }
    
}
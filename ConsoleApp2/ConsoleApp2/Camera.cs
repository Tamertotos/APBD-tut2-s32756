namespace ConsoleApp2;

public class Camera : Equipment
{
    public string Brand  { get; set; }
    public int Age  { get; set; }

    public Camera(string name, bool isAvailable, int price, string brand, int age) : base(name, isAvailable, price)
    {
        Brand = brand;
        Age = age;
    }
}
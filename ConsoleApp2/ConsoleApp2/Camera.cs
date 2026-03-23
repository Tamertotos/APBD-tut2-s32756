namespace ConsoleApp2;

public class Camera : Equipment
{
    public string Model  { get; set; }
    public int Age  { get; set; }

    public Camera(string name, bool isAvailable, int price, string model, int age) : base(name, isAvailable, price)
    {
        Model = model;
        Age = age;
    }
    
    public override string ToString()
    {
        return Name;
    }
    
}
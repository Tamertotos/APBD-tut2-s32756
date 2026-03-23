namespace ConsoleApp2;

public class Laptop : Equipment
{
    public int GPU { get; set; }
    public int RAM { get; set; }

    public Laptop(string name, bool isAvailable, int price, int gpu, int ram) : base(name, isAvailable, price)
    {
        GPU = gpu;
        RAM = ram;
    }
}
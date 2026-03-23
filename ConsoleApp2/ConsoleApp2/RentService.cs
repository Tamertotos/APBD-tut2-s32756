namespace ConsoleApp2;

public class RentService
{
    public static void Main(string[] args)
    {
        Equipment equipment1 = new Book("Core java",true, 10, "Someone", "Science");
        Equipment equipment2 = new Laptop("MSI",true, 1099, 16, 16);
        Equipment equipment3 = new Camera("Sony",true, 599, "nikkon", 4);
        User user1 = new User("Tamer", 24, "Can", "Student");
        
        Rental rent1 = new StudentRental(user1,equipment1,new DateTime(2025,3,1));
        Rental rent2 = new StudentRental(user1,equipment2,new DateTime(2025,3,1));
        Rental rent3 = new StudentRental(user1,equipment3,new DateTime(2025,3,1));
        
        Console.WriteLine(rent1.ToString());
        Console.WriteLine(rent2.ToString());
        Console.WriteLine(rent3.ToString());
    }
}
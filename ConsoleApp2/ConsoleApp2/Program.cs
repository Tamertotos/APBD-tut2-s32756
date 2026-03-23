namespace ConsoleApp2;

public class Program
{
    public static void Main(string[] args)
    {
        Equipment[] equipments =
        {
            new Book("CoreJava", true, 10, "Someone", "Science"),
            new Laptop("MSI", true, 1000, 16, 8),
            new Camera("Sony",false,599,"nikkon",5)
        };
        
        InventoryList inventory = new InventoryList();
        for (int i = 0; i < equipments.Length; i++)
        {
            inventory.AddEquipment(equipments[i]);
        }
        inventory.DisplayEquipments();

        User user1 = new User("Tamer", 25, "Can", "Student");
        Rental rental1 = new StudentRental(user1,equipments[0],new DateTime(2025,3,3));
        Rental rental2 = new StudentRental(user1,equipments[1],new DateTime(2025,3,3));
        Rental rental3 = new StudentRental(user1,equipments[2],new DateTime(2025,3,3));
        Rental rental4 = new StudentRental(user1,equipments[0],new DateTime(2025,3,3));
       
    }
}
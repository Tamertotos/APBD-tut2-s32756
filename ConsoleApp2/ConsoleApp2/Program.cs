using System.Security.AccessControl;

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
        inventory.DisplayDamagedEquipments();

        User userStudent = new User("Tamer", 24, "Can", "Student");
        Rental rent1 = new StudentRental(userStudent,equipments[1],new DateTime(2026,01,01));
        Console.WriteLine(rent1.ToString());
        rent1.OverDue(new DateTime(2026,01,01));

    }
}
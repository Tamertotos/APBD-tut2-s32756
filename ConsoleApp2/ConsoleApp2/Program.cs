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
        
        Console.WriteLine(equipments[0].InstanceId);
        Console.WriteLine(equipments[1].InstanceId);
        
        InventoryList inventory = new InventoryList();
        for (int i = 0; i < equipments.Length; i++)
        {
            inventory.AddEquipment(equipments[i]);
        }
        inventory.DisplayEquipments();
        inventory.DisplayDamagedEquipments();

        User userStudent = new User("Tamer", 24, "Can", "Student");
        Rental rent1 = new StudentRental(userStudent,equipments[1],DateTime.Now);
        Console.WriteLine(rent1.ToString());
        rent1.IsOnTime(DateTime.Now);
        rent1.ReturnEquipment(equipments[1]);

        User teacherUser = new User("Krisztof",40, "B.","Teacher");
        Rental rent2 = new TeacherRental(teacherUser,equipments[1],new DateTime(2026,03,03));
        Console.WriteLine(rent2.ToString());
        Console.WriteLine(rent2.IsOnTime(DateTime.Now));
        Console.WriteLine(rent2.ReturnEquipment(equipments[1]));
        
        Console.WriteLine(teacherUser.InstanceId);
        Console.WriteLine(userStudent.InstanceId);
    }
}
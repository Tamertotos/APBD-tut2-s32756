namespace ConsoleApp2;

public class StudentRental : Rental
{
    
    List<Equipment> rented = new List<Equipment>();
    public int RentLimit { get; set; }
    
    public StudentRental(User user, Equipment equipment, DateTime rentDate) : base(user, equipment, rentDate)
    {
        rentEquipment(equipment);
    }
    
    public override void rentEquipment(Equipment equipment)
    {
        if (User.rentCount < 2 && Equipment.IsAvailable)
        {
            User.rentCount++;
            equipment.IsAvailable = false;
            rented.Add(equipment);
            Console.WriteLine(equipment + " is rented to" + User.Name);
        }
        else
        {
            Console.WriteLine(equipment + " is already in rent or cannot be rented");
        }
    }

    public override void OverDue(DateTime RentDate)
    {
        int rentLimit = 15;
        if (RentDate.Month * 30 + (RentDate.Day) - rentLimit <= rentLimit)
        {
            Console.WriteLine("You have an overdue");
        }
    }


    public override string ToString()
    {
        return User.Name + " has rented " + rented.Count + " equipments";
    }
}
namespace ConsoleApp2;

public class StudentRental : Rental
{
    
    List<Equipment> rented = new List<Equipment>();
    public int RentLimit { get; set; }
    
    public StudentRental(User user, Equipment equipment, DateTime rentDate) : base(user, equipment, rentDate)
    {
        rentEquipment(equipment);
    }
    
    public override bool rentEquipment(Equipment equipment)
    {
        if (User.rentCount < 2 && Equipment.IsAvailable && IsOnTime(RentDate))
        {
            User.rentCount++;
            equipment.IsAvailable = false;
            rented.Add(equipment);
            Console.WriteLine(equipment + " is rented to " + User.Name);
            return true;
        }
        else
        {
            Console.WriteLine(equipment + " is already in rent or cannot be rented");
            return false;
        }
    }

    public override bool IsOnTime(DateTime RentDate)
    {
        int rentLimit = 15;
        bool isRentable = true;
        if (RentDate.AddDays(rentLimit) < DateTime.Now)
        {
            isRentable = false;
            Console.WriteLine("You have an overdue You cannot rent anything because of our strict rule!");
        }
        return isRentable;
    }

    public override String ReturnEquipment(Equipment equipment)
    {
        int rentLimit = 15;
        double payment = 0.0;
        int passedDay = (DateTime.Now - RentDate.AddDays(rentLimit)).Days;
        if (IsOnTime(RentDate))
        {
            Console.WriteLine("Thank you for timely returnal.");
            equipment.IsAvailable = true;
            User.rentCount--;
        }
        else
        {
            payment = 1.5 * passedDay;
            Console.WriteLine("You have to pay for overdue");
            equipment.IsAvailable = true;
            User.rentCount--;
        }

        return "You have to pay " + payment;
    }
    
    public override List<Equipment> GetEquipments()
    {
        return rented;
    }


    public override string ToString()
    {
        return User.Name + " has rented " + rented.Count + " equipments";
    }
}
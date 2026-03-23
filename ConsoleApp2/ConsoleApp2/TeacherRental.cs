namespace ConsoleApp2;

public class TeacherRental: Rental
{
    List<Equipment> rented = new List<Equipment>();
    public int RentLimit { get; set; }

    public TeacherRental(User user, Equipment equipment, DateTime rentDate) : base(user, equipment, rentDate)
    {
        rentEquipment(equipment);
    }
    
    public override bool rentEquipment(Equipment equipment)
    {
        if (User.rentCount < 5 && Equipment.IsAvailable && IsOnTime(RentDate))
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
        int rentLimit = 30;
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
        if (IsOnTime(RentDate))
        {
            Console.WriteLine("Thank you for timely returnal.");
            equipment.IsAvailable = true;
            User.rentCount--;
        }
        else
        {
            Console.WriteLine("You have an overdue");
            equipment.IsAvailable = true;
            User.rentCount--;
        }

        //No payment required since this person is teacher
        return " Try returning the equipment on time!";
    }
    
    public override string ToString()
    {
        return User.Name + "[" + User.Type + "] has rented " + rented.Count + " equipments";
    }
}
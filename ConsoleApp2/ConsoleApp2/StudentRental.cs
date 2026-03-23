namespace ConsoleApp2;

public class StudentRental : Rental
{
    
    List<Equipment> rented = new List<Equipment>();
    
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


    public override string ToString()
    {
        if (rented.Count > 0)
        {
            return  User + " rented: " + rented[0];      
        }

        return "You reached your rent limitation";
    }
}
namespace ConsoleApp2;

public class StudentRental : Rental
{
    
    List<Equipment> rented = new List<Equipment>();
    
    public StudentRental(User user, Equipment equipment, DateTime rentDate) : base(user, equipment, rentDate)
    {
        rentEquipment(equipment);
    }
    
    public override List<Equipment> rentEquipment(Equipment equipment)
    {
        if (User.rentCount < 2)
        {
            User.rentCount++;
            rented.Add(equipment);
        }

        
        return rented;
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
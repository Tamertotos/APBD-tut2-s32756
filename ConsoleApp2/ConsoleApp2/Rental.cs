namespace ConsoleApp2;

public abstract class Rental
{
    public User User { get; set; }
    public Equipment Equipment { get; set; }
    public DateTime RentDate { get; set; }

    protected Rental(User user, Equipment equipment, DateTime rentDate)
    {
        User = user;
        Equipment = equipment;
        RentDate = rentDate;
    }

    public abstract bool canRent(Equipment equipment);
    public abstract Equipment rentEquipment(Equipment equipment);
    

}
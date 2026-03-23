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
    
    public abstract bool rentEquipment(Equipment equipment);
    public abstract bool IsOnTime(DateTime RentDate);
    public abstract String ReturnEquipment(Equipment equipment);
    public abstract List<Equipment> GetEquipments();

}
namespace ConsoleApp2;

public class InventoryList
{
    private List<Equipment> equipments = new List<Equipment>();

    public void AddEquipment(Equipment equipment)
    {
       
        equipments.Add(equipment);    
        
    }

    public void DisplayEquipments()
    {
        for (int i = 0; i < equipments.Count; i++)
        {
            Console.WriteLine(equipments[i].ToString());
        }
    }

 
    
}
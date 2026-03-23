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

    public void DisplayDamagedEquipments()
    {
        for (int i = 0; i < equipments.Count; i++)
        {
            if (equipments[i].IsAvailable == false)
            {
                Console.WriteLine(equipments[i].ToString() + " Cannot be rented due to some problem");
            }
        }
    }
    
}
public class Item
{
    public string Name { get; set; }
    public int HealingAmount { get; set; }

    public Item(string name, int healing)
    {
        Name = name;
        HealingAmount = healing;
    }
}

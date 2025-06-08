using System.Collections.Generic;
using System;
using System.Linq;

public class Inventory
{
    private List<Item> items = new List<Item>();

    public void AddItem(Item item)
    {
        items.Add(item);
        Console.WriteLine($"Added {item.Name} to inventory.");
    }

    public void UseHealingPotion(Player player)
    {
        if (items.Count == 0)
        {
            Console.WriteLine("Inventory is empty.");
            return;
        }

        var potion = items.FirstOrDefault(i => i.HealingAmount > 0);
        if (potion != null)
        {
            player.Health += potion.HealingAmount;
            items.Remove(potion);
            Console.WriteLine($"Used {potion.Name}. Restored {potion.HealingAmount} HP.");
        }
        else
        {
            Console.WriteLine("No healing items available.");
        }
    }
}

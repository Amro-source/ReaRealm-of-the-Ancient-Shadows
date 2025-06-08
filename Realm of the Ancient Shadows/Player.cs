using System;

public class Player : Character
{
    public Inventory Inventory { get; } = new Inventory();

    public Player()
    {
        Name = "Hero";
        Health = 100;
        AttackPower = 15;
        Defense = 5;
    }

    public override void SpecialAbility(Character target)
    {
        Console.WriteLine("Hero uses Mighty Strike!");
        int bonusDamage = 10;
        target.TakeDamage(AttackPower + bonusDamage);
    }
}
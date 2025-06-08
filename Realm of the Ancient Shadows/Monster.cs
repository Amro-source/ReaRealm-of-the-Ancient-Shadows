using System;

public class Goblin : Character
{
    public Goblin()
    {
        Name = "Goblin";
        Health = 30;
        AttackPower = 8;
        Defense = 2;
    }

    public override void SpecialAbility(Character target)
    {
        Console.WriteLine("Goblin uses Sneak Attack!");
        target.TakeDamage(AttackPower + 5);
    }
}

public class Dragon : Character
{
    public Dragon()
    {
        Name = "Dragon";
        Health = 100;
        AttackPower = 20;
        Defense = 10;
    }

    public override void SpecialAbility(Character target)
    {
        Console.WriteLine("Dragon breathes fire!");
        target.TakeDamage(25);
    }
}
using System;

public abstract class Character
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int AttackPower { get; set; }
    public int Defense { get; set; }

    public virtual void TakeDamage(int damage)
    {
        int actualDamage = Math.Max(damage - Defense, 0);
        Health -= actualDamage;
        Console.WriteLine($"{Name} takes {actualDamage} damage. Remaining HP: {Health}");
    }

    public abstract void SpecialAbility(Character target);
}
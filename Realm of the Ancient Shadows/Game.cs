using System;

public class Game
{
    private Player player = new Player();
    private Random random = new Random();

    public void Run()
    {
        Console.WriteLine("Welcome to Realm of the Ancient Shadows!");

        while (true)
        {
            StartBattle(new Goblin());
            if (!player.IsAlive()) break;

            StartBattle(new Dragon());
            if (!player.IsAlive()) break;

            Console.WriteLine("You have defeated all enemies! You win!");
            break;
        }

        Console.WriteLine("Game Over.");
    }

    private void StartBattle(Character enemy)
    {
        Console.WriteLine($"\nA wild {enemy.Name} appears!\n");

        while (player.Health > 0 && enemy.Health > 0)
        {
            Console.WriteLine("\nChoose action:");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Use Potion");
            Console.WriteLine("3. Special Ability");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    enemy.TakeDamage(player.AttackPower);
                    break;
                case "2":
                    player.Inventory.AddItem(new Item("Healing Potion", 20));
                    player.Inventory.UseHealingPotion(player);
                    break;
                case "3":
                    player.SpecialAbility(enemy);
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    continue;
            }

            if (enemy.Health <= 0)
            {
                Console.WriteLine($"You defeated the {enemy.Name}!\n");
                return;
            }

            // Enemy's turn
            Console.WriteLine("\nEnemy's turn...");
            if (random.NextDouble() < 0.3)
            {
                enemy.SpecialAbility(player);
            }
            else
            {
                player.TakeDamage(enemy.AttackPower);
            }

            if (!player.IsAlive())
            {
                Console.WriteLine("You have been defeated...");
                return;
            }
        }
    }
}
using System;
using System.Collections.Generic;

public static class BattleManager
{
    public static bool RunBattle(Character player, List<Character> enemies)
    {
        while (player.IsAlive() && HasLivingEnemies(enemies))
        {
            ShowStatus(player, enemies);
            PlayerTurn(player, enemies);

            if (!HasLivingEnemies(enemies))
            {
                return true;
            }

            EnemiesTurn(player, enemies);

            if (!player.IsAlive())
            {
                return false;
            }

            Console.WriteLine();
        }

        return player.IsAlive();
    }

    private static void PlayerTurn(Character player, List<Character> enemies)
    {
        while (true)
        {
            Console.WriteLine("Your turn:");
            Console.WriteLine("1 - Attack");
            Console.WriteLine("2 - Heal");

            string action = InputHelper.ReadInputOrExit("Option: ").Trim();

            switch (action)
            {
                case "1":
                    int index = AskEnemy(enemies);
                    player.Attack(enemies[index]);

                    if (!enemies[index].IsAlive())
                    {
                        Console.WriteLine(enemies[index].Name + " was defeated.");
                    }

                    return;

                case "2":
                    player.HealSelf();
                    return;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }

    private static void EnemiesTurn(Character player, List<Character> enemies)
    {
        Console.WriteLine("Enemies turn:");

        for (int i = 0; i < enemies.Count; i++)
        {
            if (!enemies[i].IsAlive())
            {
                continue;
            }

            enemies[i].Act(player, enemies);

            if (!player.IsAlive())
            {
                Console.WriteLine(player.Name + " was defeated.");
                return;
            }
        }
    }

    private static void ShowStatus(Character player, List<Character> enemies)
    {
        Console.WriteLine("---------------------------------");
        Console.WriteLine(player.Name + " HP: " + player.CurrentHp + "/" + player.MaxHp);

        for (int i = 0; i < enemies.Count; i++)
        {
            Console.WriteLine((i + 1) + " - " + enemies[i].Name + " HP: " + enemies[i].CurrentHp + "/" + enemies[i].MaxHp);
        }

        Console.WriteLine();
    }

    private static int AskEnemy(List<Character> enemies)
    {
        while (true)
        {
            string input = InputHelper.ReadInputOrExit("Enemy: ").Trim();

            int index;
            bool valid = int.TryParse(input, out index);

            if (valid)
            {
                index -= 1;

                if (index >= 0 && index < enemies.Count && enemies[index].IsAlive())
                {
                    return index;
                }
            }

            Console.WriteLine("Invalid enemy.");
        }
    }

    private static bool HasLivingEnemies(List<Character> enemies)
    {
        for (int i = 0; i < enemies.Count; i++)
        {
            if (enemies[i].IsAlive())
            {
                return true;
            }
        }

        return false;
    }
}
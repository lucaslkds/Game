using System;
using System.Collections.Generic;

public class Game
{
    static void Main(string[] args)
    {
        Console.WriteLine("Press Z at any input to close the game.");
        Console.WriteLine();

        string playerName = InputHelper.ReadValidName("Enter your name: ");
        Character player = ChoosePlayer(playerName);

        Console.WriteLine();
        Console.WriteLine("Welcome, " + player.Name);
        Console.WriteLine();

        List<List<Character>> stages = StageManager.CreateStages();

        for (int i = 0; i < stages.Count; i++)
        {
            Console.WriteLine("Stage " + (i + 1) + " started.");

            bool won = BattleManager.RunBattle(player, stages[i]);

            if (!won)
            {
                GameOver();
                return;
            }

            Console.WriteLine("You won stage " + (i + 1) + ".");
            Console.WriteLine();
        }

        Victory();
    }

    static Character ChoosePlayer(string playerName)
    {
        while (true)
        {
            Console.WriteLine("Choose your character:");
            Console.WriteLine("1 - Playerchoice1");
            Console.WriteLine("2 - OnePunch");

            string choice = InputHelper.ReadInputOrExit("Option: ").Trim();

            switch (choice)
            {
                case "1":
                    return new Playerchoice1(
                        GameBalance.Playerchoice1Hp,
                        GameBalance.Playerchoice1Hp,
                        GameBalance.Playerchoice1Attack,
                        GameBalance.Playerchoice1Heal,
                        playerName
                    );

                case "2":
                    return new OnePunch(
                        GameBalance.OnePunchHp,
                        GameBalance.OnePunchHp,
                        GameBalance.OnePunchAttack,
                        GameBalance.OnePunchHeal,
                        playerName
                    );

                default:
                    Console.WriteLine("Invalid option.");
                    Console.WriteLine();
                    break;
            }
        }
    }

    static void GameOver()
    {
        Console.WriteLine("Game Over.");
    }

    static void Victory()
    {
        Console.WriteLine("Victory.");
    }
}
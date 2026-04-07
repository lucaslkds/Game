using System;
using System.Collections.Generic;

public class Boss2 : Character
{
    public int StealHealth = 3;

    public Boss2(int maxHp, int currentHp, int attack, int heal, string name)
        : base(maxHp, currentHp, attack, heal, name)
    {
    }

    public override void Act(Character player, List<Character> allies)
    {
        Attack(player);

        if (IsAlive())
        {
            CurrentHp += StealHealth;

            if (CurrentHp > MaxHp)
            {
                CurrentHp = MaxHp;
            }

            Console.WriteLine(Name + " stole " + StealHealth + " HP and now has " + CurrentHp + "/" + MaxHp + " HP.");
        }

        if (!player.IsAlive())
        {
            Console.WriteLine(player.Name + " was defeated.");
        }
    }
}
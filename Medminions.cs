using System;
using System.Collections.Generic;

public class Medminions : Character
{
    public Medminions(int maxHp, int currentHp, int attack, int heal, string name)
        : base(maxHp, currentHp, attack, heal, name)
    {
    }

    public override void Act(Character player, List<Character> allies)
    {
        Character ally = GetDamagedAlly(allies);

        if (ally != null)
        {
            ally.CurrentHp += HealPower;

            if (ally.CurrentHp > ally.MaxHp)
            {
                ally.CurrentHp = ally.MaxHp;
            }

            Console.WriteLine(Name + " healed " + ally.Name + " for " + HealPower + " HP.");
        }
        else
        {
            Attack(player);
        }
    }

    private Character GetDamagedAlly(List<Character> allies)
    {
        for (int i = 0; i < allies.Count; i++)
        {
            if (allies[i].IsAlive() && allies[i].CurrentHp < allies[i].MaxHp)
            {
                return allies[i];
            }
        }

        return null;
    }
}
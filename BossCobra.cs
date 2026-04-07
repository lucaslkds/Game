using System;
using System.Collections.Generic;

public class BossCobra : Character
{
    public int PoisonAttack = 5;

    public BossCobra(int maxHp, int currentHp, int attack, int heal, string name)
        : base(maxHp, currentHp, attack, heal, name)
    {
    }

    public override void Act(Character player, List<Character> allies)
    {
        Attack(player);

        if (player.IsAlive())
        {
            player.TakeDamage(PoisonAttack);
            Console.WriteLine(Name + " poisoned " + player.Name + " for " + PoisonAttack + " extra damage.");

            if (!player.IsAlive())
            {
                Console.WriteLine(player.Name + " was defeated.");
            }
        }
    }
}

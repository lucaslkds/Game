using System.Collections.Generic;

public class Mage : Character
{
    public int FireballDamage = 8;

    public Mage(int maxHp, int currentHp, int attack, int heal, string name)
        : base(maxHp, currentHp, attack, heal, name)
    {
    }

    public override bool HasSpecialAction()
    {
        return true;
    }

    public override string GetSpecialActionName()
    {
        return "Fireball";
    }

    public override bool SpecialNeedsTarget()
    {
        return false;
    }

    public override void UseSpecialAction(Character target, List<Character> enemies)
    {
        System.Console.WriteLine(Name + " used Fireball.");

        for (int i = 0; i < enemies.Count; i++)
        {
            if (enemies[i].IsAlive())
            {
                enemies[i].TakeDamage(FireballDamage);
                System.Console.WriteLine(enemies[i].Name + " took " + FireballDamage + " damage.");

                if (!enemies[i].IsAlive())
                {
                    System.Console.WriteLine(enemies[i].Name + " was defeated.");
                }
            }
        }
    }
}
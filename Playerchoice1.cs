using System.Collections.Generic;

public class Playerchoice1 : Character
{
    public int AreaAttack = 5;

    public Playerchoice1(int maxHp, int currentHp, int attack, int heal, string name)
        : base(maxHp, currentHp, attack, heal, name)
    {
    }

    public override bool HasSpecialAction()
    {
        return true;
    }

    public override string GetSpecialActionName()
    {
        return "Area Attack";
    }

    public override bool SpecialNeedsTarget()
    {
        return false;
    }

    public override void UseSpecialAction(Character target, List<Character> enemies)
    {
        System.Console.WriteLine(Name + " used Area Attack.");

        for (int i = 0; i < enemies.Count; i++)
        {
            if (enemies[i].IsAlive())
            {
                enemies[i].TakeDamage(AreaAttack);
                System.Console.WriteLine(enemies[i].Name + " took " + AreaAttack + " damage.");

                if (!enemies[i].IsAlive())
                {
                    System.Console.WriteLine(enemies[i].Name + " was defeated.");
                }
            }
        }
    }
}
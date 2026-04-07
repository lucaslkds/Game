using System.Collections.Generic;

public class OnePunch : Character
{
    public int UltraAttack = 999999;

    public OnePunch(int maxHp, int currentHp, int attack, int heal, string name)
        : base(maxHp, currentHp, attack, heal, name)
    {
    }

    public override bool HasSpecialAction()
    {
        return true;
    }

    public override string GetSpecialActionName()
    {
        return "Ultra Attack";
    }

    public override bool SpecialNeedsTarget()
    {
        return true;
    }

    public override void UseSpecialAction(Character target, List<Character> enemies)
    {
        target.TakeDamage(UltraAttack);
        System.Console.WriteLine(Name + " used Ultra Attack on " + target.Name + ".");

        if (!target.IsAlive())
        {
            System.Console.WriteLine(target.Name + " was defeated.");
        }
    }
}
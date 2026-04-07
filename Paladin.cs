using System.Collections.Generic;

public class Paladin : Character
{
    public int HolyDamage = 7;
    public int HolyHeal = 4;

    public Paladin(int maxHp, int currentHp, int attack, int heal, string name)
        : base(maxHp, currentHp, attack, heal, name)
    {
    }

    public override bool HasSpecialAction()
    {
        return true;
    }

    public override string GetSpecialActionName()
    {
        return "Holy Strike";
    }

    public override bool SpecialNeedsTarget()
    {
        return true;
    }

    public override void UseSpecialAction(Character target, List<Character> enemies)
    {
        target.TakeDamage(HolyDamage);

        CurrentHp += HolyHeal;
        if (CurrentHp > MaxHp)
        {
            CurrentHp = MaxHp;
        }

        System.Console.WriteLine(Name + " used Holy Strike on " + target.Name + " for " + HolyDamage + " damage.");
        System.Console.WriteLine(Name + " recovered " + HolyHeal + " HP.");

        if (!target.IsAlive())
        {
            System.Console.WriteLine(target.Name + " was defeated.");
        }
    }
}
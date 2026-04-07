using System.Collections.Generic;

public class Berserker : Character
{
    public int FuryDamage = 12;
    public int SelfDamage = 3;

    public Berserker(int maxHp, int currentHp, int attack, int heal, string name)
        : base(maxHp, currentHp, attack, heal, name)
    {
    }

    public override bool HasSpecialAction()
    {
        return true;
    }

    public override string GetSpecialActionName()
    {
        return "Fury Strike";
    }

    public override bool SpecialNeedsTarget()
    {
        return true;
    }

    public override void UseSpecialAction(Character target, List<Character> enemies)
    {
        target.TakeDamage(FuryDamage);
        CurrentHp -= SelfDamage;

        if (CurrentHp < 0)
        {
            CurrentHp = 0;
        }

        System.Console.WriteLine(Name + " used Fury Strike on " + target.Name + " for " + FuryDamage + " damage.");
        System.Console.WriteLine(Name + " lost " + SelfDamage + " HP from recoil.");

        if (!target.IsAlive())
        {
            System.Console.WriteLine(target.Name + " was defeated.");
        }

        if (!IsAlive())
        {
            System.Console.WriteLine(Name + " was defeated.");
        }
    }
}
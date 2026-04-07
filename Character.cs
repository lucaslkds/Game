using System;
using System.Collections.Generic;

public class Character : IAttack, IHeal
{
    public int MaxHp { get; set; }
    public int CurrentHp { get; set; }
    public int AttackPower { get; set; }
    public int HealPower { get; set; }
    public string Name { get; set; }

    public Character(int maxHp, int currentHp, int attackPower, int healPower, string name)
    {
        MaxHp = maxHp;
        CurrentHp = currentHp;
        AttackPower = attackPower;
        HealPower = healPower;
        Name = name;
    }

    public bool IsAlive()
    {
        return CurrentHp > 0;
    }

    public void TakeDamage(int damage)
    {
        CurrentHp -= damage;

        if (CurrentHp < 0)
        {
            CurrentHp = 0;
        }
    }

    public virtual void Attack(Character target)
    {
        target.TakeDamage(AttackPower);
        Console.WriteLine(Name + " attacked " + target.Name + " for " + AttackPower + " damage.");
    }

    public virtual void HealSelf()
    {
        CurrentHp += HealPower;

        if (CurrentHp > MaxHp)
        {
            CurrentHp = MaxHp;
        }

        Console.WriteLine(Name + " healed and now has " + CurrentHp + "/" + MaxHp + " HP.");
    }

    public virtual void Act(Character player, List<Character> allies)
    {
        Attack(player);
    }

    public virtual bool HasSpecialAction()
    {
        return false;
    }

    public virtual string GetSpecialActionName()
    {
        return "";
    }

    public virtual bool SpecialNeedsTarget()
    {
        return false;
    }

    public virtual void UseSpecialAction(Character target, List<Character> enemies)
    {
        Console.WriteLine(Name + " has no special action.");
    }
}
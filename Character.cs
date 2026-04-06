using System;

public class Character
{
    public int MaxHp { get; set; }
    public int CurrentHp { get; set; }
    public int AttackPower { get; set; }
    public int HealPower { get; set; }
    public string Name { get; set; }

    public Character(int maxHp, int currentHp, int attackPower, int healPower, string name)
    {
        this.MaxHp = maxHp;
        this.CurrentHp = currentHp;
        this.AttackPower = attackPower;
        this.HealPower = healPower;
        this.Name = name;
    }
}
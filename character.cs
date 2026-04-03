using System;

protected class Character
{
        int maxhp;
        int currenthp = 10;
        int attackpower;
        int heal;
        string name;

    protected Character (int maxhp, int currenthp, int attackpower, int heal, string name)
    {
        this.maxhp = maxhp;
        this.currenthp = currenthp;
        this.attackpower = attackpower;
        this.heal = heal;
        this.name=name;
    }

    public void Attack()
    {
        Console.WriteLine(name + " attacked with " + attackpower + " damage.");
    }
}

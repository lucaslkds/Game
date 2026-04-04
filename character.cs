using System;

public class Character
{
        public int maxhp;
        public int currenthp = 10;
        public int attackpower;
        public int heal;
        public string name;

    public Character (int maxhp, int currenthp, int attackpower, int heal, string name)
    {
        this.maxhp = maxhp;
        this.currenthp = currenthp;
        this.attackpower = attackpower;
        this.heal = heal;
        this.name=name;
    }
}

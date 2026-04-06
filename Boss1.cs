public class Boss1 : Character
{
    public int PoisonAttack = 5;

    public Boss1(int maxHp, int currentHp, int attack, int heal, string name)
        : base(maxHp, currentHp, attack, heal, name)
    {
    }
}
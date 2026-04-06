public class OnePunch : Character
{
    public int UltraAttack = 999999;

    public OnePunch(int maxHp, int currentHp, int attack, int heal, string name)
        : base(maxHp, currentHp, attack, heal, name)
    {
    }
}
public class Boss2 : Character
{
    public int StealHealth = 10;

    public Boss2(int maxHp, int currentHp, int attack, int heal, string name)
        : base(maxHp, currentHp, attack, heal, name)
    {
    }
}
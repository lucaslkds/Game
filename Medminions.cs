public class Medminions : Character
{
    public double HealEnemies = 0.5;

    public Medminions(int maxHp, int currentHp, int attack, int heal, string name)
        : base(maxHp, currentHp, attack, heal, name)
    {
    }
}
using System;
using System.Collections.Generic;

public static class StageManager
{
    public static List<List<Character>> CreateStages()
    {
        List<List<Character>> stages = new List<List<Character>>();

        stages.Add(CreateStage(1));
        stages.Add(CreateStage(2));
        stages.Add(CreateStage(3));

        return stages;
    }

    public static List<Character> CreateStage(int stageNumber)
    {
        List<Character> enemies = new List<Character>();

        switch (stageNumber)
        {
            case 1:
                enemies.Add(CreateMinion("Minions 1"));
                break;

            case 2:
                enemies.Add(CreateMinion("Minions 1"));
                enemies.Add(CreateMinion("Minions 2"));
                enemies.Add(CreateMedMinion("Medminions 1"));
                break;

            case 3:
                List<Character> bosses = new List<Character>();
                bosses.Add(CreateBoss1("Boss1"));
                bosses.Add(CreateBoss2("Boss2"));

                Random rng = new Random();
                int index = rng.Next(bosses.Count);

                enemies.Add(bosses[index]);
                break;
        }

        return enemies;
    }

    private static Character CreateMinion(string name)
    {
        return new Minions(
            GameBalance.MinionHp,
            GameBalance.MinionHp,
            GameBalance.MinionAttack,
            GameBalance.MinionHeal,
            name
        );
    }

    private static Character CreateMedMinion(string name)
    {
        return new Medminions(
            GameBalance.MedMinionHp,
            GameBalance.MedMinionHp,
            GameBalance.MedMinionAttack,
            GameBalance.MedMinionHeal,
            name
        );
    }

    private static Character CreateBoss1(string name)
    {
        return new Boss1(
            GameBalance.Boss1Hp,
            GameBalance.Boss1Hp,
            GameBalance.Boss1Attack,
            GameBalance.Boss1Heal,
            name
        );
    }

    private static Character CreateBoss2(string name)
    {
        return new Boss2(
            GameBalance.Boss2Hp,
            GameBalance.Boss2Hp,
            GameBalance.Boss2Attack,
            GameBalance.Boss2Heal,
            name
        );
    }
}
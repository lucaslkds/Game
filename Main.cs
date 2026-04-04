using System;

public class Main
{
    static void Main(string[] args)
    {
        Playerchoice1 player = new Playerchoice1(20, 10, 5, 3, "Hero");
        Console.WriteLine("Seu hp é: " + player.currenthp);
    }
}
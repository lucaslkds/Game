public class Main
{

    static void Main(string[] args)
    {
        Character player = new Character(20, 10, 5, 3, "Hero");
        Console.WriteLine("Seu hp é: " + player.currenthp);
    }
}
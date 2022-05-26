using RPG.src.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        Fighter rakgar = new Fighter("Rakgar", "Fighter", 1, 20, 5);
        Wizard kyzas = new Wizard("Kyzas", "Wizard", 1, 8, 10);

        Console.WriteLine(rakgar.Attack());
        Console.WriteLine(kyzas.Attack());
    }
}
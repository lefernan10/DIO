using RPG.src.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        Cleric pomor = new Cleric("Pomor", "Cleric", 1, 10, 5);
        Fighter rakgar = new Fighter("Rakgar", "Fighter", 1, 20, 7);
        Ranger tanar = new Ranger("Tanar", "Ranger", 1, 10, 8);
        Rogue raty = new Rogue("Raty", "Rogue", 1, 12, 8);
        Wizard kyzas = new Wizard("Kyzas", "Wizard", 1, 8, 9);
        
        Console.WriteLine(pomor.Attack(6));
        Console.WriteLine(rakgar.Attack(2));
        Console.WriteLine(tanar.Attack(5));
        Console.WriteLine(raty.Attack(7));
        Console.WriteLine(kyzas.Attack(3));
    }
}
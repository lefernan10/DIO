using Series.src.Entities;
using Series.src.Enum;

class Program
{
    static SerieRepository repository = new SerieRepository();
    static void Main(string[] args)
    {

        string userChoice = ObtainUserChoice();
        
            while (userChoice.ToUpper() != "X")
            {
                switch (userChoice)
                {
                    case "1":
                        SeriesList();
                        break;
                    case "2":
                        InsertSerie();
                        break;
                    case "3":
                        UpdateSerie();
                        break;
                    case "4":
                        DeleteSerie();
                        break;
                    case "5":
                        ViewSerie();
                        break;
                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();                
                }

                userChoice = ObtainUserChoice();
            }

            System.Console.WriteLine("Thanks!");
            System.Console.WriteLine();

    static void SeriesList()
    {
        System.Console.WriteLine("Series List");

        var list = repository.SeriesList();

        if (list.Count == 0)
        {
            System.Console.WriteLine("There's no series registered.");
            return;
        }

        foreach (var serie in list)
        {
    var deleted = serie.deletedReturn();

            System.Console.WriteLine($"#ID {serie.idReturn()}: - {serie.titleReturn()}, {(deleted ? "Deleted" : "")}");
        }
    }

    static void InsertSerie()
    {
        Console.WriteLine("Insert New Serie");

        foreach (int i in Enum.GetValues(typeof(Genre)))
        {
            Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genre), i));
        }
        Console.Write("Enter the genre from the options above: ");
        int genreEntered = int.Parse(Console.ReadLine());

        Console.Write("Enter the Serie's Title: ");
        string titleEntered = Console.ReadLine();

        Console.Write("Enter the Serie's Year: ");
        int yearEntered = int.Parse(Console.ReadLine());

        Console.Write("Enter the Serie's Description: ");
        string descriptionEntered = Console.ReadLine();

        Serie newSerie = new Serie(id: repository.NextId(),
                                    genre: (Genre)genreEntered,
                                    title: titleEntered,
                                    year: yearEntered,
                                    description: descriptionEntered);

        repository.Insert(newSerie);
    }

    static void UpdateSerie()
    {
        Console.Write("Enter Serie's ID: ");
        int serieIndex = int.Parse(Console.ReadLine());

        foreach (int i in Enum.GetValues(typeof(Genre)))
        {
            Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genre), i));
        }
        Console.Write("Enter the genre from the options above: ");
        int genreEntered = int.Parse(Console.ReadLine());

        Console.Write("Enter the Serie's Title: ");
        string titleEntered = Console.ReadLine();

        Console.Write("Enter the Serie's Year: ");
        int yearEntered = int.Parse(Console.ReadLine());

        Console.Write("Enter the Serie's Description: ");
        string descriptionEntered = Console.ReadLine();

        Serie serieUpdate = new Serie(id: serieIndex,
                                    genre: (Genre)genreEntered,
                                    title: titleEntered,
                                    year: yearEntered,
                                    description: descriptionEntered);

        repository.Update(serieIndex, serieUpdate);
    }
    
    static void DeleteSerie()
    {
        Console.Write("Enter Serie's ID: ");
        int serieIndex = int.Parse(Console.ReadLine());

        repository.Delete(serieIndex);
    }

        static void ViewSerie()
    {
        Console.Write("Enter Serie's ID: ");
        int serieIndex = int.Parse(Console.ReadLine());

        var serie = repository.ReturnId(serieIndex);

        Console.WriteLine(serie);
    }

    static string ObtainUserChoice()
    {
        System.Console.WriteLine();
        System.Console.WriteLine("DIO Series!");
        System.Console.WriteLine("Choose an option:");

        System.Console.WriteLine("1 - Series List");
        System.Console.WriteLine("2 - Insert Serie");
        System.Console.WriteLine("3 - Update Serie");
        System.Console.WriteLine("4 - Delete Serie");
        System.Console.WriteLine("5 - View Serie");
        System.Console.WriteLine("C - Clear Screen");
        System.Console.WriteLine("X - Exit");
        System.Console.WriteLine();

        string userChoice = Console.ReadLine().ToUpper();
        System.Console.WriteLine();
        return userChoice;
        }
    }
}
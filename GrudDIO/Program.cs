using GrudDIO.Class;
using GrudDIO.Enum;
using System;

namespace GrudDIO
{
    class Program
    {
        static readonly RepositorySeries repository = new RepositorySeries();
        static void Main(string[] args)
        {
            Series serie1 = new Series(repository.NextId(), (Genre)1, "Thor", "Hero movie", 2016);
            repository.Insert(serie1);
            Series serie2 = new Series(repository.NextId(), (Genre)2, "Thor Ragnarok", "Hero movie", 2018);
            repository.Insert(serie2);
            Series serie3 = new Series(repository.NextId(), (Genre)3, "Funny Movie 2", "Comedy movie", 2020);
            repository.Insert(serie3);
            Series serie4 = new Series(repository.NextId(), (Genre)4, "Real world", "boring documentary", 2021);
            repository.Insert(serie4);
            Series serie5 = new Series(repository.NextId(), (Genre)5, "Brazil", "¬¬", 2021);
            repository.Insert(serie5);

            string userOption = GetUserOption();

            while (userOption.ToUpper() != "X")
            {
                switch (userOption)
                {
                    case "1":
                        ListSeries();
                        break;
                    case "2":
                        InsertSeries();
                        break;
                    case "3":
                        UpdateSeries();
                        break;
                    case "4":
                        ExcludeSeries();
                        break;
                    case "5":
                        ViewSeries();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Invalid number!"); ;
                        break;
                }

                userOption = GetUserOption();
            }
        }

        private static void ViewSeries()
        {
            Console.Write("Enter the series id: ");
            int indexSeries = int.Parse(Console.ReadLine());

            var series = repository.ReturnById(indexSeries);

            Console.WriteLine(series);
        }

        private static void ExcludeSeries()
        {
            Console.Write("Enter the series id: ");
            int indexSeries = int.Parse(Console.ReadLine());

            repository.Exclude(indexSeries);
        }

        private static void UpdateSeries()
        {
            Console.Write("Enter the series id: ");
            int indexSeries = int.Parse(Console.ReadLine());

            foreach (int i in System.Enum.GetValues(typeof(Genre)))
            {
                Console.WriteLine($"{i}-{System.Enum.GetName(typeof(Genre), i)}");
            }

            Console.Write("Enter the gender between the options above: ");
            int enterGenre = int.Parse(Console.ReadLine());
            Console.Write("Enter the title of the series: ");
            string enterTitle = Console.ReadLine();
            Console.Write("Enter the year of the start of the series: ");
            int enterYear = int.Parse(Console.ReadLine());
            Console.Write("Enter the series description: ");
            string enterDescription = Console.ReadLine();

            Series newSeries = new Series(indexSeries, (Genre)enterGenre, enterTitle, enterDescription, enterYear);

            repository.Update(indexSeries, newSeries);
        }

        private static void InsertSeries()
        {
            foreach (int i in System.Enum.GetValues(typeof(Genre)))
            {
                Console.WriteLine($"{i}-{System.Enum.GetName(typeof(Genre), i)}");
            }

            Console.Write("Enter the gender between the options above: ");
            int enterGenre = int.Parse(Console.ReadLine());
            Console.Write("Enter the title of the series: ");
            string enterTitle = Console.ReadLine();
            Console.Write("Enter the year of the start of the series: ");
            int enterYear = int.Parse(Console.ReadLine());
            Console.Write("Enter the series description: ");
            string enterDescription = Console.ReadLine();

            Series newSeries = new Series(repository.NextId(), (Genre)enterGenre, enterTitle, enterDescription, enterYear);
            repository.Insert(newSeries);
        }

        private static void ListSeries()
        {
            Console.WriteLine("List series");

            var list = repository.List();

            if (list.Count == 0)
            {
                Console.WriteLine("No series registered.");
                return;
            }

            foreach (var series in list)
            {
                var excluded = series.ReturnExcluded();
                Console.WriteLine($"#ID {series.ReturnId()}: - {series.ReturnTitle()} {(excluded ? " - *Excluded*" : "")} ");
            }
        }

        private static string GetUserOption()
        {
            Console.WriteLine();
            Console.WriteLine("DIO series at your service");
            Console.WriteLine("Enter the desired option");
            Console.WriteLine("1 - List series");
            Console.WriteLine("2 - Insert new series");
            Console.WriteLine("3 - Update series");
            Console.WriteLine("4 - Delete series");
            Console.WriteLine("5 - View series");
            Console.WriteLine("C - Clear screen");
            Console.WriteLine("X - Exit");
            Console.WriteLine();

            string userOption = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return userOption;
        }

        public static void InsertUpdateSeries()
        {
            foreach (int i in System.Enum.GetValues(typeof(Genre)))
            {
                Console.WriteLine($"{i}-{System.Enum.GetName(typeof(Genre), i)}");
            }

            Console.Write("Enter the gender between the options above: ");
            int enterGenre = int.Parse(Console.ReadLine());
            Console.Write("Enter the title of the series: ");
            string enterTitle = Console.ReadLine();
            Console.Write("Enter the year of the start of the series: ");
            int enterYear = int.Parse(Console.ReadLine());
            Console.Write("Enter the series description: ");
            string enterDescription = Console.ReadLine();
        }
    }
}

using GrudDIO.Class;
using GrudDIO.Enum;
using System;

namespace GrudDIO
{
    class Program
    {
        static RepositorySeries repository = new RepositorySeries();
        static void Main(string[] args)
        {
            string userOption = GetUserOption();

            while(userOption.ToUpper() != "X")
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
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        private static void InsertSeries()
        {
            foreach(int i in System.Enum.GetValues(typeof(Genre)))
            {
                Console.WriteLine($"{i}-{System.Enum.GetName(typeof(Genre),i)}");
            }

            Console.Write("Enter the gender between the options above: ");
            int enterGenre = int.Parse(Console.ReadLine());
            Console.Write("Enter the title of the series: ");
            string enterTitle = Console.ReadLine();
            Console.Write("Enter the year of the start of the series: ");
            int enterYear = int.Parse(Console.ReadLine());
            Console.Write("Enter the series description: ");
            string enterDescription = Console.ReadLine();

            Series newSeries = new Series(repository.NextId(), (Genre)enterGenre, enterTitle, enterDescription,enterYear);

            repository.Insert(newSeries);
        }

        private static void ListSeries()
        {
            Console.WriteLine("List series");

            var list = repository.List();

            if(list.Count == 0)
            {
                Console.WriteLine("No series registered.");
                return;
            }

            foreach(var series in list)
            {
                Console.WriteLine($"#ID {series.ReturnId()}: - {series.ReturnTitle()}");
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
    }
}

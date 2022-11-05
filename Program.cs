using System;
using System.Runtime.ExceptionServices;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Match match = new Match();
            English english = new English();
            Biology biology = new Biology();
            Chemistry chemistry = new Chemistry();
            History history = new History();
            Console.WriteLine("Match 3 grades, English 3 grades, Biology 3 grades");
            Console.WriteLine("Chemistry 3 grades, History 3 grades");
            match.Match1 = double.Parse(Console.ReadLine());
            match.Match2 = double.Parse(Console.ReadLine());
            match.Match3 = double.Parse(Console.ReadLine());
            match.average();
            english.English1 = double.Parse(Console.ReadLine());
            english.English2 = double.Parse(Console.ReadLine());
            english.English3 = double.Parse(Console.ReadLine());
            english.average();
            biology.Biology1 = double.Parse(Console.ReadLine());
            biology.Biology2 = double.Parse(Console.ReadLine());
            biology.Biology3 = double.Parse(Console.ReadLine());
            biology.average();
            chemistry.Chem1 = double.Parse(Console.ReadLine());
            chemistry.Chem2 = double.Parse(Console.ReadLine());
            chemistry.Chem3 = double.Parse(Console.ReadLine());
            chemistry.average();
            history.History1 = double.Parse(Console.ReadLine());
            history.History2 = double.Parse(Console.ReadLine());
            history.History3 = double.Parse(Console.ReadLine());
            history.average();
            double sum = (match.All + english.All + biology.All + chemistry.All + history.All) / 5;
            Console.WriteLine("Grade Point Average " + Math.Round(sum, 2));
        }        
        }
    }

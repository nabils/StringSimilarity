using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuzzyStrings;

namespace StringSimilarity
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string>
                {
                    "Book",
                    "Johnson",
                    "Jensen",
                    "Johansen",
                    "Johanneson",
                    "P&L test 1",
                    "P&L test 2",
                    "P&L test 3",
                    "Benchmark",
                    "Book Id"
                };

            string input = "booc";
            var results = list.Select(l => new {Item = l, Distance = l.DiceCoefficient(input)})
                .Where(l => l.Distance > 0)
                .OrderByDescending(i => i.Distance);

            foreach (var result in results)
            {
                Console.WriteLine(result.Distance + ": " + result.Item);
            }

            Console.ReadLine();
        }
    }
}

using System;
using System.Linq;

namespace JourneyChallenge
{
    class TerseSolution
    {

        public static void Run(string[] args)
        {
            var result = args[1].Aggregate(
                (int.Parse(args[0].Split(' ')[0]) * 1000000) + (int.Parse(args[0].Split(' ')[1]) * 1000) + "NESW".IndexOf(args[0].Split(' ')[2]),
                ((current, command) => (new Func<int, int>[] { r => r + 1, l => l + 3, (f => f + new[] { 1000, 1000000, -1000, -1000000 }[f % 4]) })["RLF".IndexOf(command)](current))
                );
            Console.WriteLine($"{result / 1000000 } {(((result % 1000000) - (result % 4)) / 1000)} { "NESW"[result % 4]}");
        }
    }
}
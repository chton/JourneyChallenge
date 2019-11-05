using System;

namespace JourneyChallenge
{
    class MyPoint { public int X; public int Y; };
    class Program
    {
        static string DIRECTIONS = "NESW";
        static Action<MyPoint>[] MOVEMENTS = {
                n => n.Y++,
                e => e.X++,
                s => s.Y--,
                w => w.X--
        };

        static void Main(string[] args)
        {
            var startPosition = args[0].Split(' ');
            var currentPosition = new MyPoint() { X = int.Parse(startPosition[0]), Y = int.Parse(startPosition[1]) };
            var direction = startPosition[2];
            var directionPointer = DIRECTIONS.IndexOf(direction) + (args[1].Length * 4);
            foreach (var command in args[1])
            {
                switch (command)
                {
                    case 'R': directionPointer++; break;
                    case 'L': directionPointer--; break;
                    case 'F': MOVEMENTS[directionPointer % 4](currentPosition); break;
                    default: break;
                }
            }
            Console.WriteLine($"{currentPosition.X} {currentPosition.Y} {DIRECTIONS[directionPointer % 4]}");
        }
    }
}

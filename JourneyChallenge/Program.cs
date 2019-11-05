using System;

namespace JourneyChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //args = new[] { "1 1 N", "RRRR" };
            //VerboseSolution.Run(args);
            //TerseSolution.Run(args);
            //Console.WriteLine("Expected 1 1 N");
            args = new[] { "1 1 E", "RFRFRFRF" };
            VerboseSolution.Run(args);
            TerseSolution.Run(args);
            Console.WriteLine("Expected 1 1 E");
            args = new[] { "3 2 N", "FRRFLLFFRRFLL" };
            VerboseSolution.Run(args);
            TerseSolution.Run(args);
            Console.WriteLine("Expected 3 3 N");
            args = new []{ "0 3 W", "LLFFFLFLFL"};
            VerboseSolution.Run(args);
            TerseSolution.Run(args);
            Console.WriteLine("Expected 2 4 S");
            Console.ReadLine();
        }
    }

}

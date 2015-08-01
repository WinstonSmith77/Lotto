using System;
using System.Collections.Generic;
using System.Linq;

namespace Lotto
{
    class Program
    {
        static void Main()
        {
            var result = new List<int>();
            for (;;)
            {
                result = Pick6OutOf49();
                if (result.Contains(6) && result.Contains(29))
                {
                    break;
                }
            }

            result.ForEach(Console.WriteLine);
            Console.ReadKey();
        }

        private static List<int> Pick6OutOf49()
        {
            const int numberOfBalls = 49;
            const int choosen = 6;
            var balls = Enumerable.Range(1, numberOfBalls).ToList();
            var random = new Random();

            var result = new List<int>();

            for (int i = 0; i <= choosen; i++)
            {
                var nextPick = random.Next(balls.Count - 1);
                result.Add(balls[nextPick]);
                balls.RemoveAt(nextPick);
            }
            result = result.OrderBy(ball => ball).ToList();
            return result;
        }
    }
}

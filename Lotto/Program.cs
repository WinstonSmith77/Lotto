using System;
using System.Collections.Generic;
using System.Linq;

namespace Lotto
{
    class Program
    {
        static void Main()
        {
            var result = Pick6OutOf49(6, 29);

            result.ForEach(Console.WriteLine);
            Console.ReadKey();
        }

        private static List<int> Pick6OutOf49(params int[] alreadySetBalls)
        {
            const int ballsToChoose = 6;
            if (alreadySetBalls.Length > ballsToChoose)
            {
                throw new ArgumentException("Too many balls choosen!");
            }
            const int numberOfBalls = 49;

            var balls = Enumerable.Range(1, numberOfBalls).ToList();
            var random = new Random();

            var result = new List<int>();

            foreach (var ball in alreadySetBalls)
            {
                result.Add(ball);
                balls.Remove(ball);
            }

            for (int i = 0; i < ballsToChoose - alreadySetBalls.Length; i++)
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

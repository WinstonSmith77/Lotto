using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    class Program
    {
        static void Main()
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


            result.ForEach(Console.WriteLine);
            Console.ReadKey();
        }
    }
}

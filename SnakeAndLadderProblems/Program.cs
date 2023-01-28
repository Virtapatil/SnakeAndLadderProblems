using System;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Xml.Linq;

namespace SnakeAndLadderProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startPosition = 0, dieCount = 0;
            const int noPlay = 1, ladder = 2, snake = 3;
            Console.WriteLine("welcome to snake and ladder program");

            while (startPosition < 100)
            {
                Random random = new Random();
                int dieValue = random.Next(1, 7);
                Console.WriteLine("The player roll a die:" + dieValue);

                int option = random.Next(1, 4);
                Console.WriteLine("option:" + option);

                switch (option)
                {
                    case noPlay:
                        Console.WriteLine("The player stays in the same position:" + startPosition);
                        break;
                    case ladder:
                        startPosition = startPosition + dieValue;
                        if (startPosition > 100)
                        {
                            startPosition = startPosition - dieValue;
                        }
                        Console.WriteLine("player got ladder and move ahead :" + startPosition);
                        dieCount++;
                        break;
                    case snake:
                        startPosition = startPosition - dieValue;
                        if (startPosition < 0)
                        {
                            startPosition = 0;
                        }
                        Console.WriteLine("player got snake and move behind :" + startPosition);
                        dieCount++;
                        break;
                }
                Console.WriteLine("player is at:" + startPosition);
            }
            Console.WriteLine("Dice count:" + dieCount);
            Console.ReadLine();
        }
    }
}

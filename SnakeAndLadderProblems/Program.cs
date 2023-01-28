using System;
using System.Numerics;

namespace SnakeAndLadderProblems
{
    internal class Program
    {
        public static void Main(string[] args)

        { 
            int startPosition = 0;
            Console.WriteLine("the player start position is:" + startPosition);
            Random random = new Random();
            int dieValue = random.Next(1, 7);
            Console.WriteLine("The player roll a die:" + dieValue );
            const int noPlay = 1, ladder = 2, snake = 3;
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
                    
                    break;
                case snake:
                    startPosition = startPosition - dieValue;
                    if (startPosition < 0)
                    {
                        startPosition = 0;
                    }
                    Console.WriteLine("player got snake and move behind :" + startPosition);
                   
                    break;
            }
        }
        
    }
}

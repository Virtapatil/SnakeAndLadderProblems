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
            Console.WriteLine("The player roll a die:" + dieValue);
        }
        
    }
}
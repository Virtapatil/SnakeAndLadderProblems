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
            const int snake = 0;
            const int ladder = 1;
            const int NoGame = 2;
            const int player1 = 0;
            const int player2 = 1;
            int diceCount = 0;
            int playerPosition1 = 0;
            int playerPosition2 = 0;

            int player = player1;
            Random random = new Random();

            while (playerPosition1 < 100 && playerPosition2 < 100)
            {
                int diceRoll, choice;
                diceRoll = random.Next(1, 7);
                Console.WriteLine("Dice Roll= " + diceRoll);
                choice = random.Next(0, 3);
                if (player == player1)
                {
                    switch (choice)
                    {
                        case snake:
                            playerPosition1 -= diceRoll;
                            Console.WriteLine("Snake");
                            if (playerPosition1 < 0)
                            {
                                playerPosition1 = 0;
                                Console.WriteLine("Restart Game");
                                Console.WriteLine("Player 1 position : " + playerPosition1);
                            }
                            else
                            {
                                Console.WriteLine("Player 1 position : " + playerPosition1);
                            }
                            player = player2;
                            break;
                        case ladder:
                            playerPosition1 += diceRoll;
                            Console.WriteLine("Ladder");
                            if (playerPosition1 == 100)
                            {
                                Console.WriteLine(" PLAYER-1 Wins");
                            }
                            else if (playerPosition1 > 100)
                            {
                                playerPosition1 -= diceRoll;
                                Console.WriteLine("Player 1 Position is above 100; doesn't Count " + playerPosition1);
                            }
                            else
                            {
                                Console.WriteLine("Player 1 position : " + playerPosition1);
                            }
                            player = player1;
                            break;
                        case NoGame:
                            Console.WriteLine("No Game");
                            Console.WriteLine("Player 1 position : " + playerPosition1);
                            player = player2;
                            break;
                    }
                }
                else
                {
                    switch (choice)
                    {
                        case snake:
                            playerPosition2 -= diceRoll;
                            Console.WriteLine("Snake");
                            if (playerPosition2 < 0)
                            {
                                playerPosition2 = 0;
                                Console.WriteLine("Restart Game");
                                Console.WriteLine("Player 2 position : " + playerPosition2);
                            }
                            else
                            {
                                Console.WriteLine("Player 2 position : " + playerPosition2);
                            }
                            player = player1;
                            break;
                        case ladder:
                            playerPosition2 += diceRoll;
                            Console.WriteLine("Ladder");
                            if (playerPosition2 == 100)
                            {
                                Console.WriteLine(" PLAYER-2 Wins");
                            }
                            else if (playerPosition2 > 100)
                            {
                                playerPosition2 -= diceRoll;
                                Console.WriteLine("Player 2 Position is above 100; doesn't Count " + playerPosition2);
                            }
                            else
                            {
                                Console.WriteLine("Player 2 position : " + playerPosition2);
                            }
                            player = player2;
                            break;
                        case NoGame:
                            Console.WriteLine("No Game");
                            Console.WriteLine("Player 2 position : " + playerPosition2);
                            player = player1;
                            break;
                    }
                }
                diceCount++;
            }
            Console.WriteLine("Dice Count to Win the Game: " + diceCount);
        }
    }
}

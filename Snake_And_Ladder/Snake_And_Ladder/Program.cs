using Snake_And_Ladder;
using System;
using System.Runtime.Intrinsics.X86;
namespace SnakeAndLadderSimulator
{
    class Program
    {
        public const int WinPosition = 100;
        static void Main(string[] args)
        {
            Position Player1 = new Position();
            Position Player2 = new Position();
            while (Player1.currentPosition < WinPosition && Player2.currentPosition < WinPosition)
            {
                Player1.PlayTurn();
                Console.WriteLine("Player 1 Position: " + Player1.currentPosition);
                Player2.PlayTurn();
                Console.WriteLine("Player 2 Position: " + Player2.currentPosition);
            }
            if(Player1.currentPosition == WinPosition)
            {
                Console.WriteLine("Player 1 Won");
            }
            else
            {
                Console.WriteLine("Player 2 Won");
            }
            Console.WriteLine("Number Of Total Die Rolls by Player 1 = " + Player1.count);
            Console.WriteLine("Number Of Total Die Rolls by Player 2 = " + Player2.count);
            Console.WriteLine("Final Position of Player 1 = " + Player1.currentPosition);
            Console.WriteLine("Final Position of Player 2 = " + Player2.currentPosition);
        }
    }
}
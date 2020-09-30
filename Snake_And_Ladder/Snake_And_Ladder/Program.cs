using System;
namespace SnakeAndLadderSimulator
{
    class Program
    {
        public const int NoPlay = 0;
        public const int Ladder = 1;
        public const int Snake = 2;
        //Returns the Output Of Die Roll
        public static int rollTheDie()
        {
            Random random = new Random();
            int numberOnDie = random.Next(1, 7);
            return numberOnDie;
        }
        //Returns the forward or the backward movement of the player
        public static int newPosition(int numberOnDie)
        {
            int toAdd = 0;
            Random random = new Random();
            int toMove = random.Next(0, 3);
            switch (toMove)
            {
                case NoPlay:
                    Console.WriteLine("No Play");
                    break;
                case Ladder:
                    toAdd = numberOnDie;
                    Console.WriteLine("Ladder so moving forward.");
                    break;
                case Snake:
                    toAdd = -numberOnDie;
                    Console.WriteLine("Snake so moving backward!");
                    break;
            }
            return toAdd;
        }
        static void Main(string[] args)
        {
            //Welcome msg
            Console.WriteLine("Welcome to the Snake and Ladder Problem!");
            //Initialising
            int currentPosition = 0;
            Console.WriteLine("Starting position = " + currentPosition);
            int numberOnDie = rollTheDie();
            Console.WriteLine("Number on Die rolled = " + numberOnDie);
            //checking for an option out of three
            Console.WriteLine("New position = " + newPosition(numberOnDie));
        }
    }
}
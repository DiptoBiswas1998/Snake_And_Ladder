using System;
namespace SnakeAndLadderSimulator
{
    class Program
    {
        //Returns Output Of Die Roll
        public static int rollTheDie()
        {
            Random random = new Random();
            int numberOnDie = random.Next(1, 7);
            return numberOnDie;
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
        }
    }
}
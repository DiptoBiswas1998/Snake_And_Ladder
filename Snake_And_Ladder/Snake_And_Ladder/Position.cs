using System;
using System.Collections.Generic;
using System.Text;
namespace Snake_And_Ladder
{
    class Position
    {
        public const int StartPosition = 0;
        public const int WinPosition = 100;
        public const int NoPlay = 0;
        public const int Ladder = 1;
        public const int Snake = 2;
        public int currentPosition = StartPosition;
        public int nextPosition; 
        public int count = 0;
        public int RollTheDie()
        {
            Random random = new Random();
            int numOnDie = random.Next(1, 7);
            return numOnDie;
        }
        public int NewPosition(int numOnDie)
        {
            int toAdd = 0;
            Random random = new Random();
            int toMove = random.Next(0, 3);
            switch (toMove)
            {
                case NoPlay:
                    break;
                case Ladder:
                    toAdd = numOnDie;
                    break;
                case Snake:
                    toAdd = -numOnDie;
                    break;
            }
            return toAdd;
        }
        public void PlayTurn()
        {
            int numOnDie = this.RollTheDie();
            this.count++;
            int toAdd = this.NewPosition(numOnDie);
            //Checking if player got ladder
            if (toAdd > 0)
            {
                this.PlayTurn();
            }
            //Checking if next position will cross WinPosition
            if (this.currentPosition + toAdd > WinPosition)
            {
                this.nextPosition = this.currentPosition;
            }
            else
            {
                this.nextPosition = this.currentPosition + toAdd;
            }
            //Checking if player has moved below starting StartPosition
            if (this.nextPosition < StartPosition)
            {
                this.currentPosition = StartPosition;
            }
            else
            {
                this.currentPosition = this.nextPosition;
            }
        }
    }
}

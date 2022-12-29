using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderProblem
{
    public class SnakeandLadder
    {
        public static void SnakeAndLadder()
        {
            int position = 0;
            int currentPosition = 0;
            int endPosition = 100;
            int startposition = 0;
            const int NoPlay = 0;
            const int ladder = 1;
            const int snake = 2;
            int temp = 0;
            while (currentPosition < endPosition)
            {
                Random random = new Random();
                int die = random.Next(1, 7);
                int prop = random.Next(3);
                switch (prop)
                {
                    case NoPlay:
                        position = 0;
                        break;
                    case ladder:
                        position = die;
                        break;
                    case snake:
                        if (currentPosition > 0)
                        {
                            position = 0;
                            currentPosition = currentPosition - die;
                            if (currentPosition < 0)
                            {
                                currentPosition = startposition;
                            }
                        }
                        else
                        {
                            currentPosition = startposition;
                        }
                        break;
                }

                currentPosition += (position);
                if (currentPosition <= 100)
                {
                    Console.WriteLine("die : " + die + " option : " + prop + " position : " + currentPosition);
                    temp = currentPosition;
                }
            }
        }
    }
}

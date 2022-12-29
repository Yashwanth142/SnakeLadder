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
            int flag1 = 0;
            int flag2 = 0;
            int resultflag = 0;
            while (currentPosition < endPosition)
            {

                Random random = new Random();
                int die = random.Next(1, 7);
                flag1++;
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

                if (endPosition < currentPosition)
                {
                    while (temp < endPosition)
                    {
                        Random random1 = new Random();
                        int die1 = random.Next(1, 7);
                        flag2++;
                        int prop1 = random.Next(3);
                        switch (prop1)
                        {
                            case NoPlay:
                                position = 0;
                                break;
                            case ladder:
                                if (temp + die1 == endPosition)
                                {
                                    position = die1;
                                }
                                else
                                {
                                    position = 0;
                                }
                                break;
                            case snake:
                                position = 0;
                                break;
                        }
                        temp += (position);
                        if (temp == endPosition)
                        {
                            Console.WriteLine("die : " + die1 + " option : " + prop1 + " position : " + temp);
                        }
                    }

                }
            }
            Console.WriteLine("Dice rolled to reach win : " + flag1);
            Console.WriteLine("Dice rolled to reach exact win : " + flag2);
            resultflag = flag1 + flag2;
            Console.WriteLine("The number of times dice rolled : " + resultflag);
        }


    }
}

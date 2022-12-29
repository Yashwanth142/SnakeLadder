using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderProblem
{
    public class Players
    {
        public static int Play(int currentPosition)
        {
            
            int endPosition = 100;
            
            int startposition = 0;
            const int NoPlay = 0;
            const int ladder = 1;
            const int snake = 2;
            
            
            if (currentPosition < endPosition)
            {

                Random random = new Random();
                int die = random.Next(1, 7);
                int prop = random.Next(3);
                
                switch (prop)
                {
                    case NoPlay:
                        
                        break;
                    case ladder:
                        
                        currentPosition += (die);
                        Play(currentPosition);
                        break;
                    case snake:
                        if (currentPosition > 0)
                        {
                            
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
            }
            return currentPosition;
        }
    }
}

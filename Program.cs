namespace SnakeLadderProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to snake and ladder");

            int Player1 = 0;
            int Player2 = 0;
            while (Player1 < 100 | Player2 < 100)
            {
                Player1 = Players.Play(Player1);
                Player2 = Players.Play(Player2);
            }
           
                if (Player1 > 100)
                {
                    Console.WriteLine("The Player1 has won");
                }
                else
                {
                    Console.WriteLine("The player2 has won");
                }
            
        }
    }
}
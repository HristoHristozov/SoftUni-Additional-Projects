using System.Runtime.CompilerServices;

namespace RockPaperScissors
{
    internal class RockPaperScissors
    {
        static void Main()
        {
            const string Rock = "Rock";
            const string Paper = "Paper";
            const string Scissors = "Scissors";

            Console.Write("Choose [r]ock, [p]aper or [s]cissors: ");

            string playerMove = Console.ReadLine().ToLower();

            if (playerMove == "r" || playerMove == "rock")
            {
                playerMove = Rock;
            }
            else if (playerMove == "p" ||  playerMove == "paper")
            {
                playerMove = Paper;
            }
            else if (playerMove == "s" || playerMove == "scissors")
            {
                playerMove = Scissors;
            }

            else
            {
                Console.WriteLine("Invalid Input. Try Again...");
                return;
            }

            Random rand = new Random();
            int computerRandomNumber = rand.Next(1,4);

            string computerMove = "";

            switch (computerRandomNumber)
            {
                case 1: computerMove = Rock;
                    break;
                case 2: computerMove = Paper;
                    break;
                case 3: computerMove = Scissors;
                    break;
            }

            Console.WriteLine($"The computer chose {computerMove}");

            if ((playerMove == Rock && computerMove == Scissors) ||
                (playerMove == Paper && computerMove == Rock) ||
                (playerMove == Scissors && computerMove == Paper))
            {
                Console.WriteLine("You win.");
            }
            else if ((playerMove == Paper && computerMove == Scissors) ||
                (playerMove ==  Rock && computerMove == Paper) ||
                (playerMove == Scissors && computerMove == Rock))
            {
                Console.WriteLine("You lose.");
            }

            else Console.WriteLine("Draw");

        }
    }
}

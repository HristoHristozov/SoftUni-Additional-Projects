﻿namespace GuessANumber
{
    internal class GuessANumber
    {
        static void Main()
        {
            Random random = new Random();

            int computerNumber = random.Next(1, 101);

            while (true)
            {
                Console.Write("Guess a number (1-100): ");

                string playerInput = Console.ReadLine();
                
                bool isValid = int.TryParse(playerInput, out int playerNumber);

                if (isValid) 
                {
                    if (playerNumber == computerNumber)
                    {
                        Console.WriteLine("You guessed it!");
                        break;
                    }
                    else if (playerNumber > computerNumber)
                    {
                        Console.WriteLine("Too High");
                    }
                    else Console.WriteLine("Too Low");
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
        }
    }
}

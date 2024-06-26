namespace RockPaperScissor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string ROCK_TEXT = "Rock";
            const string PAPER_TEXT = "Paper";
            const string SCISSORS_TEXT = "Scissors";

            // Read user's move
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Choose [r]ock, [p]aper, or [s]cissors: ");
            Console.ResetColor();
            string userMove = Console.ReadLine().ToLower();

            if (userMove == "r" || userMove == "rock")
            {
                userMove = ROCK_TEXT;
            }
            else if (userMove == "p" || userMove == "paper")
            {
                userMove = PAPER_TEXT;
            }
            else if (userMove == "s" || userMove == "scissors")
            {
                userMove = SCISSORS_TEXT;
            }

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"The user chose {userMove}");

            // Generate computer's move

            // Generate random number for the move
            Random random = new Random();
            int computerMoveNumber = random.Next(1, 4);

            // Determine word for the move based on the number
            string computerMove = "";

            switch (computerMoveNumber)
            {
                case 1:
                    computerMove = ROCK_TEXT;
                    break;

                case 2:
                    computerMove = PAPER_TEXT;
                    break;

                case 3:
                    computerMove = SCISSORS_TEXT;
                    break;
            }


            Console.WriteLine($"The computer chose {computerMove}");

            // Compare moves and print winner

            if (
                (userMove == ROCK_TEXT && computerMove == SCISSORS_TEXT) ||
                (userMove == PAPER_TEXT && computerMove == ROCK_TEXT) ||
                (userMove == SCISSORS_TEXT && computerMove == PAPER_TEXT)
            )
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You win.");
            }
            else if (
                (userMove == ROCK_TEXT && computerMove == PAPER_TEXT) ||
                (userMove == PAPER_TEXT && computerMove == SCISSORS_TEXT) ||
                (userMove == SCISSORS_TEXT && computerMove == ROCK_TEXT)
            )
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You lose.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("This game was a draw.");
            }

            Console.ResetColor();
        }
    }
}
using System;

namespace rockPaperScissorsProject
{
    class RockPaperScissors
    {
        static void Main(string[] args)
        {
            const string rock = "Rock";
            const string paper = "Paper";
            const string scissors = "Scissors";
            Console.Write("Choose from (r)ock, (p)aper or (s)cissors: ");
            string ourMove = Console.ReadLine();
            
            while (ourMove.ToUpper()!="END" && ourMove.ToUpper() != "E")
            {
                while (ourMove.ToLower() != "r" && ourMove.ToLower() != "rock" && ourMove.ToLower() != "p" 
                    && ourMove.ToLower() != "paper" && ourMove.ToLower() != "s" && ourMove.ToLower() != "scissors"
                    && ourMove.ToUpper() != "END" && ourMove.ToUpper() != "E")
                {
                    Console.WriteLine($"Invalid input: {ourMove}. Try again with a valid input");
                    ourMove = Console.ReadLine();
                }
                if (ourMove.ToLower() == "r" || ourMove.ToLower() == "rock")
                {
                    ourMove = rock;
                }
                else if (ourMove.ToLower() == "p" || ourMove.ToLower() == "paper")
                {
                    ourMove = paper;
                }
                else if (ourMove.ToLower() == "s" || ourMove.ToLower() == "scissors")
                {
                    ourMove = scissors;
                }
                
                Random random = new Random();
                int computerMoveInt = random.Next(1, 4);
                string computerMoveStr = "";
                switch (computerMoveInt)
                {
                    case 1:
                        computerMoveStr = rock;
                        break;
                    case 2:
                        computerMoveStr = paper;
                        break;
                    case 3:
                        computerMoveStr = scissors;
                        break;
                }
                Console.WriteLine($"The computer chose the move: {computerMoveStr}");
                
                if ((ourMove == rock && computerMoveStr == scissors) || (ourMove == paper && computerMoveStr == rock) || (ourMove == scissors && computerMoveStr == paper))
                {
                    Console.WriteLine("Congratulations, YOU WON");
                }
                else if ((ourMove == rock && computerMoveStr == paper) || (ourMove == paper && computerMoveStr == scissors) || (ourMove == scissors && computerMoveStr == rock))
                {
                    Console.WriteLine("Sadly, you lost");
                }
                else
                {
                    Console.WriteLine("WHAT A GAME but it ended in a draw");
                }
                Console.Write("Choose from (r)ock, (p)aper, (s)cissors or (e)nd: ");
                 ourMove = Console.ReadLine();
                while (ourMove.ToLower() != "r" && ourMove.ToLower() != "rock" && ourMove.ToLower() != "p"
                    && ourMove.ToLower() != "paper" && ourMove.ToLower() != "s" && ourMove.ToLower() != "scissors"
                    &&ourMove.ToUpper() != "END" && ourMove.ToUpper() != "E")
                {
                    Console.WriteLine($"Invalid input: {ourMove}. Try again with a valid input");
                    ourMove = Console.ReadLine();

                }
            }
            Console.WriteLine("See you");
            
        }
    }
}

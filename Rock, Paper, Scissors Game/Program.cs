using System;

namespace Rock__Paper__Scissors_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            Random rdmNum = new Random();
            int number = rdmNum.Next(1, 3);
            int guess;
           

            //Display The Game
            Console.WriteLine("I Challenge You To A Game Of Rock, Paper, Scissors\nType (1) for Rock, (2) for Paper, Or, (3) for Scissors\nReady...\n");

            //Computer Guess VS. Yours
            do
                  guess = PromptV("Rock!!! Paper!!! Scissors!!! Shoot!!!: ");
                  
            while (guess != 1 && guess != 2 && guess != 3);

            if (guess == 1 && number == 1)
            {
                Console.WriteLine("IT'S A DRAW!!!\nWe Both Chose Rock");
            } 
            else if (guess == 1 && number == 2)
            {
                Console.WriteLine("I WON!!!\nPaper Covers Rock");
            } 
            else if (guess == 1 && number == 3)
            {
                Console.WriteLine("YOU'RE A WINNER!!!\nRock Beats Scissors");
            }//End If

            if (guess == 2 && number == 2)
            {
                Console.WriteLine("IT'S A DRAW!!!\nWe Both Chose Paper");
            }
            else if (guess == 2 && number == 1)
            {
                Console.WriteLine("YOU'RE A WINNER!!!\nPaper Covers Rock");
            }
            else if (guess == 2 && guess == 3)
            {
                Console.WriteLine("I WON!!!\nScissors Cut Paper");
            }//End If

            if (guess == 3 && number == 3)
            {
                Console.WriteLine("IT'S A DRAW!!!\nWe Both Chose Scissors");
            }
            else if (guess == 3 && number == 1)
            {
                Console.WriteLine("I WON!!!\nRock Beats Scissors");
            }
            else if (guess == 3 && number == 2)
            {
                Console.WriteLine("YOU'RE A WINNER!!!\nScissors Cut Paper");
            }//End If

            Console.ReadKey();

        }//End Main

        static int PromptV(string text)
        {
            Console.Write(text + "");
            return int.Parse(Console.ReadLine());

        }//End Function
       
    }//End Class

}//End Namespace

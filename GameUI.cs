using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    public class GameUI
    {
        public void Run()
        {

            Game();
        }
        public static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };


        public static int _check = Check.CheckIfWon;

        public int chosenSquare;




        static int player = 1;
        private void Game()
        {
            Console.WriteLine("TIC TAC TOE! by Erin & Khalil.");

            Thread.Sleep(5000);

            Console.Clear();
            bool continueToRun = true;
            while (continueToRun)
            {


                do
                {
                    Console.Clear();



                    Console.WriteLine("TIC TAC TOE");

                    Console.WriteLine("\n");

                    Console.WriteLine("Player 1 = X and Player 2 = O", ConsoleColor.Red);

                    Console.WriteLine("\n");

                    if (player % 2 != 0)

                    {
                        Console.WriteLine("Player 1's Turn");
                    }

                    else
                    {
                        Console.WriteLine("Player 2's Turn");
                    }

                    Console.WriteLine("\n");
                    Board();

                    chosenSquare = int.Parse(Console.ReadLine());

                    if (arr[chosenSquare] != 'X' && arr[chosenSquare] != 'O')
                    {
                        if (player % 2 == 0)
                        {
                            arr[chosenSquare] = 'O';

                            player++;


                        }
                        else
                        {
                            arr[chosenSquare] = 'X';

                            player++;
                        }
                    }

                    else

                    {
                        Console.WriteLine("Square {0} is already marked by {1}", chosenSquare, arr[chosenSquare]);

                        Console.WriteLine("\n");

                        Console.WriteLine("Hit any key to try again.");

                        Console.ReadKey();

                    }




                    _check = GameStateRepo.CheckWin();


                }


                while (_check != 1 && _check != -1);




                Console.Clear();

                Board();

                if (_check == 1)
                {
                    Console.WriteLine("Player {0} has won!", (player % 2) + 1);

                }
                else
                {
                    Console.WriteLine("Draw");

                }

                Console.WriteLine("Do you want to play again? (y/n)");

                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "y":
                        { ; break; }

                    case "n":
                        { Console.WriteLine("GoodBye!");
                          Thread.Sleep(4000); 
                            continueToRun = false; break; }
                }

                Console.ReadLine();

            }
        }

        private static void Board()

        {

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);

            Console.WriteLine("     |     |      ");

        }
    }
}

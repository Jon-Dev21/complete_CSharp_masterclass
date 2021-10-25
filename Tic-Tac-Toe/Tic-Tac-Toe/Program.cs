using System;

namespace Tic_Tac_Toe
{
    /// <summary>
    /// This program is a console based Tic-Tac-Toe game.
    /// Created By. Jonathan A. Acevedo
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            PaintConsole();
            PlayGame();
        }

        /// <summary>
        /// This function prints the tic-tac-toe grid into the console. It takes 2 parameters, user input and the current player playing.
        /// This function is called each time a player takes a turn.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="player"></param>
        public static void ShowGrid(string input, int player)
        {
            switch (input)
            {
                case "1":
                    if (player == 1)
                            grid[0, 0] = "X";
                    else
                        grid[0, 0] = "O";
                    break;
                case "2":
                    if (player == 1)
                        grid[0, 1] = "X";
                    else
                        grid[0, 1] = "O";
                    break;
                case "3":
                    if (player == 1)
                        grid[0, 2] = "X";
                    else
                        grid[0, 2] = "O";
                    break;
                case "4":
                    if (player == 1)
                        grid[1, 0] = "X";
                    else
                        grid[1, 0] = "O";
                    break;
                case "5":
                    if (player == 1)
                        grid[1, 1] = "X";
                    else
                        grid[1, 1] = "O";
                    break;
                case "6":
                    if (player == 1)
                        grid[1, 2] = "X";
                    else
                        grid[1, 2] = "O";
                    break;
                case "7":
                    if (player == 1)
                        grid[2, 0] = "X";
                    else
                        grid[2, 0] = "O";
                    break;
                case "8":
                    if (player == 1)
                        grid[2, 1] = "X";
                    else
                        grid[2, 1] = "O";
                    break;
                case "9":
                    if (player == 1)
                        grid[2, 2] = "X";
                    else
                        grid[2, 2] = "O";
                    break;
                default:
                    break;
            }
            Console.WriteLine("Tic-Tac-Toe");
            Console.WriteLine("By Jonathan A. Acevedo");
            Console.WriteLine();

            for (int i = 0; i<grid.GetLength(0); i++)
            {
                Console.WriteLine("     |     |      ");
                
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    Console.Write(j!=2?"  "+ grid[i,j]+"  |": "  " + grid[i, j] + "   ");
                }
                Console.WriteLine();
                Console.WriteLine(i!=2?"_____|_____|_____ ": "     |     |      ");

            }
        }
        
        /// <summary>
        /// This function clears the console when called.
        /// </summary>
        public static void ClearConsole()
        {
            Console.Clear();
        }
    
        /// <summary>
        /// This function paints the console background to blue and foreground to white.
        /// </summary>
        public static void PaintConsole()
        {
            // Changing console colors
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            ClearConsole();
        }

        /// <summary>
        /// This function starts the tic-tac-toe game when called.
        /// </summary>
        public static void PlayGame()
        {
            // Starting game
            ShowGrid("0", 1);
            // Starting player turn
            while(isOver == false)
            {
                PlayTurn();
            }
            Console.WriteLine("Game over. \nWinner is {0}", winner);
            AskPlayAgain();
            
        }

        /// <summary>
        /// This function executes in each tic-tac-toe turn until the game is over.
        /// </summary>
        public static void PlayTurn()
        {
            Console.WriteLine();
            string userInput = PromptUserInput(player);
            if (ValidateUserInput(userInput))
            {
                ClearConsole();
                ShowGrid(userInput, player); // Show grid with player input
                if (player == 1)
                    player = 2;
                else
                    player = 1;

                CheckGameOver();
            } else
            {
                Console.WriteLine(errorMessage);
            }
        }

        /// <summary>
        /// This function restarts the tic-tac-toe game.
        /// </summary>
        public static void ResetGame()
        {
            ClearConsole();
            grid = new string[3, 3] {
                {"1" , "2", "3"},
                {"4" , "5", "6"},
                {"7" , "8", "9"}
            };
            if (winner == "Player 1")
                player = 1;
            else
                player = 2;

            isOver = false;

            winner = "";
        }

        /// <summary>
        /// Checks if the someone won the game. If anyone won the game, isOver will be assigned to true and winner
        /// name will be assigned (Player 1 or Player 2).
        /// </summary>
        public static void CheckGameOver()
        {
            // Check if X Won (Player 1)
            if (grid[0,0] == "X" && grid[0, 1] == "X" && grid[0, 2] == "X")
            {
                // If horizontal win in first row
                /*
                    X X X 
                    4 5 6
                    7 8 9
                 */
                isOver = true;
                winner = "Player 1";
                return;
            } else if (grid[1, 0] == "X" && grid[1, 1] == "X" && grid[1, 2] == "X")
            {
                // If horizontal win in second row
                /*
                    1 2 3 
                    X X X
                    7 8 9
                 */
                isOver = true;
                winner = "Player 1";
            } else if (grid[2, 0] == "X" && grid[2, 1] == "X" && grid[2, 2] == "X")
            {
                // If horizontal win in third row
                /*
                    1 2 3 
                    4 5 6
                    X X X
                 */
                isOver = true;
                winner = "Player 1";
            }
            else if (grid[0, 0] == "X" && grid[1, 0] == "X" && grid[2, 0] == "X")
            {
                // If vertical win in first column
                /*
                    X 2 3 
                    X 5 6
                    X 8 9
                 */
                isOver = true;
                winner = "Player 1";
                return;
            }
            else if (grid[0, 1] == "X" && grid[1, 1] == "X" && grid[2, 1] == "X")
            {
                // If vertical win in second column
                /*
                    1 X 3 
                    4 X 6
                    7 X 9
                 */
                isOver = true;
                winner = "Player 1";
                return;
            }
            else if (grid[0, 2] == "X" && grid[1, 2] == "X" && grid[2, 2] == "X")
            {
                // If vertical win in third column
                /*
                    1 2 X
                    4 5 X
                    7 8 X
                 */
                isOver = true;
                winner = "Player 1";
            }
            else if (grid[0, 0] == "X" && grid[1, 1] == "X" && grid[2, 2] == "X")
            {
                // If diagonal win from left to right
                /*
                    X 2 3 
                    4 X 6
                    7 8 X
                 */
                isOver = true;
                winner = "Player 1";
                return;
            }
            else if (grid[0, 2] == "X" && grid[1, 1] == "X" && grid[2, 0] == "X")
            {
                // If diagonal win from right to left
                /*
                    1 2 X 
                    4 X 6
                    X 8 9
                 */
                isOver = true;
                winner = "Player 1";
                return;
            } else
            {
                isOver = false;
            }

            // ==============================================================================
            // ==============================================================================

            // Check if O Won (Player 2)
            if (grid[0, 0] == "O" && grid[0, 1] == "O" && grid[0, 2] == "O")
            {
                // If horizontal win in first row
                /*
                    X X X 
                    4 5 6
                    7 8 9
                 */
                isOver = true;
                winner = "Player 2";
                return;
            }
            else if (grid[1, 0] == "O" && grid[1, 1] == "O" && grid[1, 2] == "O")
            {
                // If horizontal win in second row
                /*
                    1 2 3 
                    X X X
                    7 8 9
                 */
                isOver = true;
                winner = "Player 2";
                return;
            }
            else if (grid[2, 0] == "O" && grid[2, 1] == "O" && grid[2, 2] == "O")
            {
                // If horizontal win in third row
                /*
                    1 2 3 
                    4 5 6
                    X X X
                 */
                isOver = true;
                winner = "Player 2";
                return;
            }
            else if (grid[0, 0] == "O" && grid[1, 0] == "O" && grid[2, 0] == "O")
            {
                // If vertical win in first column
                /*
                    X 2 3 
                    X 5 6
                    X 8 9
                 */
                isOver = true;
                winner = "Player 2";
                return;
            }
            else if (grid[0, 1] == "O" && grid[1, 1] == "O" && grid[2, 1] == "O")
            {
                // If vertical win in second column
                /*
                    1 X 3 
                    4 X 6
                    7 X 9
                 */
                isOver = true;
                winner = "Player 2";
                return;
            }
            else if (grid[0, 2] == "O" && grid[1, 2] == "O" && grid[2, 2] == "O")
            {
                // If vertical win in third column
                /*
                    1 2 X
                    4 5 X
                    7 8 X
                 */
                isOver = true;
                winner = "Player 2";
                return;
            }
            else if (grid[0, 0] == "O" && grid[1, 1] == "O" && grid[2, 2] == "O")
            {
                // If diagonal win from left to right
                /*
                    X 2 3 
                    4 X 6
                    7 8 X
                 */
                isOver = true;
                winner = "Player 2";
                return;
            }
            else if (grid[0, 2] == "O" && grid[1, 1] == "O" && grid[2, 0] == "O")
            {
                // If diagonal win from right to left
                /*
                    1 2 X 
                    4 X 6
                    X 8 9
                 */
                isOver = true;
                winner = "Player 2";
                return;
            }
            else
            {
                isOver = false;
            }
        }

        /// <summary>
        /// Prompts the user for input. Takes in the player number as a parameter.
        /// Player can be 1 or 2.
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public static string PromptUserInput(int player)
        {
            string input;
            if(player == 1)
            {
                Console.Write("Player 1. \nChoose where you want to place the X: ");
            } else
            {
                Console.Write("Player 2. \nChoose where you want to place the O: ");
            }
            input = Console.ReadLine();
            return input;
        }

        /// <summary>
        /// This function is called whenever the game is over. 
        /// It prompts user to enter if the game should restart or end and validates user input. 
        /// If yes, ResetGame function is called. 
        /// Else, It prints a thank you message and closes the console.
        /// </summary>
        public static void AskPlayAgain()
        {
            Console.Write("Play Again? (y/n): ");
            bool correctInput = false;
            string input = Console.ReadLine();
            bool isNumber = int.TryParse(input, out int unused);
            while(correctInput == false)
            {
                if (isNumber == false && input == "y" || input == "Y" || input.ToLower() == "yes")
                {
                    correctInput = true;
                    ResetGame();
                    PlayGame();
                }
                else if (isNumber == false && input == "n" || input == "N" || input.ToLower() == "no")
                {
                    correctInput = true;
                    ClearConsole();
                    Console.WriteLine("\n\n\n====================================================================================");
                    Console.WriteLine("====================================================================================");
                    Console.WriteLine("=========== Thank you so much for playing my game. Much Love, Jonathan =============");
                    Console.WriteLine("====================================================================================");
                    Console.WriteLine("====================================================================================\n\n\n");
                    break;
                }
                else
                {
                    correctInput = false;
                    Console.WriteLine("Incorrect input \"{0}\"", input);
                    Console.Write("Play Again? (y/n): ");
                    input = Console.ReadLine();
                }
            }
            
        }

        /// <summary>
        /// Returns true if input is a number between 1 and 9. Else, returns false.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool ValidateUserInput(string input)
        {
            bool isNumber = int.TryParse(input, out int num);
            if (isNumber && num >= 1 && num <=9)
                if(num == 1 && grid[0,0] == "1" || num == 2 && grid[0, 1] == "2" || num == 3 && grid[0, 2] == "3" || num == 4 && grid[1, 0] == "4" || num == 5 && grid[1, 1] == "5" || num == 6 && grid[1, 2] == "6" || num == 7 && grid[2, 0] == "7" || num == 8 && grid[2, 1] == "8" || num == 9 && grid[2, 2] == "9")
                {
                    return true;
                }
                else
                {
                    string playerMarker = player == 1 ? "X" : "O";
                    errorMessage = "\nThat spot is already taken. Choose another spot to place your " +playerMarker+".";
                    return false;
                }                
            else
            {
                errorMessage = "\nInvalid input. Please enter a number between 1 and 9.";
                return false;
            }   
        }

        /// <summary>
        /// This two-dimensional string array represents the tic tac toe grid.
        /// </summary>
        static string[,] grid = new string[3, 3] { 
            {"1" , "2", "3"},
            {"4" , "5", "6"},
            {"7" , "8", "9"}
        };

        /// <summary>
        /// This variable is true when the game is over, else variable is false.
        /// </summary>
        static bool isOver = false;

        /// <summary>
        /// This variable indicates which player's turn is it.
        /// </summary>
        static int player = 1;

        /// <summary>
        /// This variable will hold the player who won. Either player 1 or Player 2.
        /// </summary>
        static string winner = "";

        /// <summary>
        /// This message is printed whenever there is an input error during the game.
        /// </summary>
        static string errorMessage = "";
    }
}

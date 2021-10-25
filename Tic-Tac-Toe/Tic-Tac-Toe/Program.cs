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
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.White;
            ClearConsole();
            
            Console.WriteLine("Tic-Tac-Toe");
            Console.WriteLine("By Jonathan A. Acevedo");

            Console.WriteLine();
            ShowGrid();
        }

        /// <summary>
        /// This function prints out the tic-tac-toe game board
        /// </summary>
        public static void ShowGrid()
        {
            for(int i = 0; i<grid.GetLength(0); i++)
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
        /// This two-dimensional string array represents the tic tac toe grid.
        /// </summary>
        static string[,] grid = new string[3, 3] { 
            {"1" , "2", "3"},
            {"4" , "5", "6"},
            {"7" , "8", "9"}
        };
    }
}

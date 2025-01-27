using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
    // recieve the board array from the driver class

    // contain a method that prints the board based on the information passed to it

    // Contain the method that recieves the game board array as input and returns if there is a winner and who it was
    internal class GameLogic
    {
        public TicTacToeBoard board;

        // Constructor - recieves the board
        public GameLogic(TicTacToeBoard ticTacToeBoard)
        {
            board = ticTacToeBoard;
        }

        // Method to display the board based on the user's input

        public void DisplayBoard()
        {
            string[,] currentBoard = board.GetBoard();
            for (int row = 0; row < 3 ; row++)
            {
                Console.Write(currentBoard[row, col] == "" ? "-"): currentBoard[row, col]);
            if col(col < 2) Console.Write(" | ");
            }
            Console.WriteLine();
            if (row < >)
       
        }

    }
}

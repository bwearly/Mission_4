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
        public char CheckWinner(char[,] board)
        {
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == ' ' && board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                    return board[i, 0];
                if (board[0, i] != ' ' && board[0, i] == board[1, i] && board[1, i] == board[2, i])
                    return board[0, i];
            }

            if (board[0, 0] != ' ' && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
                return board[0, 0];
            if (board[0, 2] != ' ' && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
                return board[0, 2];
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
            if (row < 2) Console.WriteLine("--------");
        }


        // Method To Process a move

        public bool MakeMove(int row, int col, string player)
        {
            try
            {
                board.UpdateCell(row, col, player);
                return true;
            }
            catch (InalidOperationException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }


            return ' ';
        }

    }
}

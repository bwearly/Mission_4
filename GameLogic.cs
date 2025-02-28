﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Mission_4
{
    // recieve the board array from the driver class

    // contain a method that prints the board based on the information passed to it

    // Contain the method that recieves the game board array as input and returns if there is a winner and who it was
    internal class GameLogic
    {
        // Char array to represent the board 
        private char[,] board;
        // Constructor - recieves the board
        public GameLogic(char[,] gameBoard)
        {
            board = gameBoard; 
        }

        // Method to display the board based on the user's input
        public void DisplayBoard(char[,] board)
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    // Display "-" for empty cells or the actual value
                    Console.Write(board[row, col] == '\0' ? "-" : board[row, col].ToString());

                    // Add a separator between columns
                    if (col < 2)
                        Console.Write(" | ");
                }
                Console.WriteLine();

                // Add a separator between rows
                if (row < 2)
                    Console.WriteLine("---------");
            }
        }

        public bool MakeMove(int row, int col, char player)
        {
            // Check if the move is valid
            if (row >= 0 && row < 3 && col >= 0 && col < 3 && board[row, col] == '\0')
            {
                // Update boards with the user's move
                board[row, col] = player;
                return true; // if the move is successful return true
            }
            else
            {
                Console.WriteLine("Invalid Move. Try again.");
                return false; // Return flase if move is invalid
            }
        }

        public char CheckWinner(char[,] board)
        {
            // For loop to make sure that there is three in a row
            for (int i = 0; i < 3; i++)
            {
                // 
                if (board[i, 0] != '\0' && board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                    return board[i, 0];
                if (board[0, i] != '\0' && board[0, i] == board[1, i] && board[1, i] == board[2, i])
                    return board[0, i];
            }

            if (board[0, 0] != '\0' && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
                return board[0, 0];
            if (board[0, 2] != '\0' && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
                return board[0, 2];

            // Returns the winner
            return ' ';
        }
    }
}




using System.Reflection.Metadata;
using Microsoft.VisualBasic;
using Mission_4;
using static Mission_4.GameLogic;

TicTacToeBoard boardObject = new TicTacToeBoard();
GameLogic gl = new GameLogic(boardObject);

// Welcome User to the Game 
Console.WriteLine("Welcome to our Tic-Tac-Toe game!");
        
// Create a board game array to store the players choices
char[,] board = new char[3, 3];
bool isXTurn = true;
bool gameWon = false;
int moves = 0;

// Loop until there is a winner or the board is full
while (!gameWon && moves < 9)
{
    Console.Clear();
    gl.DisplayBoard(board);

    // Ask each player during their turn for their choice and update the game board
    Console.WriteLine($"Player {(isXTurn ? "X" : "O")}, it's your turn.");
    Console.Write("Enter the row (0-2): ");
    int row = int.Parse(Console.ReadLine());
    Console.Write("Enter the column (0-2): ");
    int col = int.Parse(Console.ReadLine());

    if (row < 0 || row > 2 || col < 0 || col > 2 || board[row, col] != ' ')
    {
        Console.WriteLine("Invalid move. Try again.");
        Console.ReadLine(); // Pause to let the player see the error message
        continue;
    }

    // Update the board with the player's choice
    board[row, col] = isXTurn ? 'X' : 'O';

    // Check for the winner by calling the method in the supporting class
    char winner = gl.CheckWinner(board);

    if (winner != ' ')
    {
        gameWon = true;
        Console.Clear();
        gl.DisplayBoard(board);
        Console.WriteLine($"Player {winner} wins! Congratulations!");
    }

    // Switch turns and increment move count
    isXTurn = !isXTurn;
    moves++;
}
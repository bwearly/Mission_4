using System.Reflection.Metadata;
using Microsoft.VisualBasic;
using Mission_4;
using static Mission_4.GameLogic;

char[,] board = new char[3,3];
GameLogic gl = new GameLogic(board);
        
// Create a board game array to store the players choices
bool isXTurn = true;
bool gameWon = false;
int moves = 0;
char player;

// Welcome User to the Game 
Console.WriteLine("Welcome to our Tic-Tac-Toe game!");

// Loop until there is a winner or the board is full
while (!gameWon && moves < 9)
{
    gl.DisplayBoard(board);

    // Ask each player during their turn for their choice and update the game board
    Console.WriteLine($"Player {(isXTurn ? "X" : "O")}, it's your turn.");
    Console.Write("Enter the row (0-2): ");
    int row = int.Parse(Console.ReadLine());
    Console.Write("Enter the column (0-2): ");
    int col = int.Parse(Console.ReadLine());

    player = isXTurn ? 'X' : 'O';

    if (gl.MakeMove(row, col, player))
    {
        moves++;
        // Check for the winner by calling the method in the supporting class
        char winner = gl.CheckWinner(board);

        if (winner != ' ')
        {
            gameWon = true;
            gl.DisplayBoard(board);
            Console.WriteLine($"Player {winner} wins! Congratulations!");
            break;
        }

        // Switch turns and increment move count
        isXTurn = !isXTurn;
    }
    else
    {
        Console.WriteLine("Invalid move. Press enter to try again.");
        Console.ReadLine();
    }
}
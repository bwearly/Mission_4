using System;

class Program
{
    static void Main(string[] args)
    {
        // Welcome User to the Game 
        Console.WriteLine("Welcome to our Tic-Tac-Toe game!");
        
        // Create a board game array to store the players choices
        char[,] board = new char[3, 3];
        InitializeBoard(board); 
        
        // track whose turn it is
        bool isXTurn = true;
        //track if the game is won
        bool gameWon = false;
        //count number of moves
        int moves = 0;
        
        // Loop until there is a winner or the board is full
        while (!gameWon && moves < 9) 
        {
            Console.Clear();
            // Print the board by calling the method in the supporting class
            GameLogic.DisplayBoard(board); 

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
            gameWon = GameLogic.CheckWinner(board, out char winner);

            if (gameWon)
            {
                Console.Clear();
                // Print the board by calling the method in the supporting class
                GameLogic.DisplayBoard(board);
                // Notify the players when a win has occured and which player has won
                Console.WriteLine($"Player {winner} wins! Congratulations!");
            }

            // Switch turns and increment move count
            isXTurn = !isXTurn;
            moves++;
        }
    }
    
    // Initialize the board with empty spaces
    static void InitializeBoard(char[,] board)
    {
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                board[row, col] = ' ';
            }
        }
    }
}





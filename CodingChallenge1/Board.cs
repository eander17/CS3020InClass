using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge1
{
    /// <summary>
    /// Act as a container for a gameboard consisting of chars
    /// </summary>
    class Board
    {

        //field
        char[,] gameBoard = new char[10, 10];


        public void FillBoard(char newChar)
        {
            for (int row = 0; row < gameBoard.GetLength(0); row++)
            {
                for (int col = 0; col < gameBoard.GetLength(1); col++)
                {
                    gameBoard[row, col] = newChar;
                }
                
            }
        }

        /// <summary>
        /// Prompts user for a character to fill the gameboard. 
        /// </summary>

        public void UserFillBoard()
        {

            Console.Write("Enter a character to fill the board: ");
            char input = Console.ReadKey().KeyChar;
            Console.WriteLine();
            FillBoard(input);


        }

        public void CheckerFillBoard()
        {
            Console.Write("Enter two Characters to fill the board: ");
            Char input1 = Console.ReadKey().KeyChar;
            Char input2 = Console.ReadKey().KeyChar;
            Console.WriteLine();

            for (int row = 0; row < gameBoard.GetLength(0); row++)
            {
                for (int col = 0; col < gameBoard.GetLength(1); col++)
                {
                    if (col % 2 == 0)
                    {
                        gameBoard[row, col] = input1;
                    }
                    else
                        gameBoard[row, col] = input2;
                }

            }
        }

        public void RandomFillBoard()
        {
            Random random = new Random();
            Console.WriteLine("HoW RaNdOm!");

            for (int row = 0; row < gameBoard.GetLength(0); row++)
            {
                for (int col = 0; col < gameBoard.GetLength(1); col++)
                {
                    int value = random.Next(33, 126);

                    gameBoard[row, col] = (char)value;
                }

            }

        }

        public void SearchAndDestroy()
        {
            Console.Write("Enter a character to search for and then a character to replace it with: ");
            char key = Console.ReadKey().KeyChar;
            char destroy = Console.ReadKey().KeyChar;

            int counter = 0;

            for (int row = 0; row < gameBoard.GetLength(0); row++)
            {
                for (int col = 0; col < gameBoard.GetLength(1); col++)
                {
                    if (gameBoard[row, col] == key)
                    {
                        gameBoard[row, col] = destroy;
                        counter++;
                    }
                }

            }
            Console.WriteLine();
            Display();

            if (counter == 0)
                Console.WriteLine("No words Were replaced!");
            else
                Console.WriteLine("\nReplaced " + counter + " letters.");
        }


        public void Reset()
        {
            FillBoard(' ');
        }

        public void Display()
        {
            DrawHorizontalLine();
            for (int row = 0; row < gameBoard.GetLength(0); row++)
            {
                Console.Write("|");
                for (int col = 0; col < gameBoard.GetLength(1); col++)
                {
                    Console.Write($" {gameBoard[row, col]} |");
                }

                Console.WriteLine();
                DrawHorizontalLine();
            }
        }

        /// <summary>
        /// Draws a Horizontal line consisting of dashes of the appropriate length. 
        /// </summary>

        private void DrawHorizontalLine()
        {
            Console.Write("-");
            for (int i = 0; i < gameBoard.GetLength(1); i++)
            {
                Console.Write("----");
            }
            Console.WriteLine("-");
        }
    }
}

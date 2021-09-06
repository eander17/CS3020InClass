using System;

namespace CodingChallenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();

            board.Reset();
            board.UserFillBoard();
            board.Display();
            Console.ReadLine();

            board.Reset();
            board.CheckerFillBoard();
            board.Display();
            Console.ReadLine();

            board.Reset();
            board.RandomFillBoard();
            board.Display();
            Console.ReadLine();

            board.SearchAndDestroy();
          

            Console.ReadLine();
        }
    }
}

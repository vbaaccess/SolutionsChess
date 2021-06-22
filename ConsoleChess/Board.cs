using System;

namespace ConsoleChess
{
    //internal class Board
    public class Board
    {
        int[,] chessboard = new int[8, 8]
        {
            {0,1,0,1,0,1,0,1}
           ,{1,0,1,0,1,0,1,0}
           ,{0,1,0,1,0,1,0,1}
           ,{1,0,1,0,1,0,1,0}
           ,{0,1,0,1,0,1,0,1}
           ,{1,0,1,0,1,0,1,0}
           ,{0,1,0,1,0,1,0,1}
           ,{1,0,1,0,1,0,1,0}
        };

        public Board()
        {
            Draw();
        }

        void Draw()
        {
            //Console.WriteLine(" A B C D E F G H");
            //Console.WriteLine("8");
            //Console.WriteLine("7");
            //Console.WriteLine("6");
            //Console.WriteLine("5");
            //Console.WriteLine("4");
            //Console.WriteLine("3");
            //Console.WriteLine("2");
            //Console.WriteLine("1");
            //Console.WriteLine(" A B C D E F G H");
            for (int v = 1; v < 8; v++)
            {
                for (int h = 1; h < 8; h++)
                {
                    Console.SetCursorPosition(v, h);
                    if (chessboard[v, h]==1)
                        Console.BackgroundColor = ConsoleColor.Gray;
                    else
                        Console.BackgroundColor = ConsoleColor.White;

                    //Console.BackgroundColor
                    //Console.ForegroundColor

                    Console.Write(" ");
                }
            }

            Console.WriteLine();
            //Console.WriteLine("♙ ♟ ♔ ♕ ♖ ♗ ♘ ♚ ♛ ♜ ♝ ♞");
            //Console.WriteLine("♙ ♚ ♛ ♝ ♞ ♟ ♠ ♡ ♢ ♣ ☔ ☕ ☖ ☗ ☘ ☙ ☊");
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            //Console.WriteLine(
            Console.WriteLine(new string('.', 10));
            Console.Write(new string('x', 10));
            Console.Write(Environment.NewLine);
            Console.WriteLine("\u00a9");
            //Console.WriteLine(String.CharW(""));
            //Console.WriteLine("♜♝♞♛♚♝♞♜♟");




        }
    }
}
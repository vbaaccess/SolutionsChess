using System;
//using ConsoleFramework

namespace ConsoleChess
{
    class Program
    {
        static void Main(string[] args)
        {
            int Size = 80;

            Console.CursorVisible = false;
            Helper.ConsoleSize(Size, Size);
            Helper.CenterConsol();
            Console.Title = "CONSOL GAME - CHESS 2021 (c)";

            string s;
            Console.Clear();
            s = "CONSOL GAME CHESS";
            Console.SetCursorPosition(Helper.CenterTextPosition(s,Size) , 1);
            Console.Write(s);

            

            Console.ReadLine();

            

            Board board = new Board();
            
            
            //Console.Write('\u2103');

            Console.ReadLine();

            //Console.OutputEncoding = System.Text.Encoding.UTF8;
            //for (var i = 0; i <= 1000; i++)
            //{
            //    Console.Write(Strings.ChrW(i));
            //    if (i % 50 == 0)
            //    { // break every 50 chars
            //        Console.WriteLine();
            //    }
            //}
            Console.ReadKey();

        }
    }
}

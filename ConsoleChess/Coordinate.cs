using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleChess
{
    // 2 wymiarowa matryca
    // klasa do przechowywania wspolrzednych
    public class Coordinate
    {
        public enum Horizontally
        {
            A
          , B
          , C
          , D
          , E
          , F
          , G
          , H
        }

        public int v { get; set; }  //vertical    => column
        public int h { get; set; }  //horizontall => row

        public Coordinate() { v = 0; h = 0; }

        public Coordinate(int vertical, int horizontall)
        {
            v = vertical;
            h = horizontall;
        }
    }
}
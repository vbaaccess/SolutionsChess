using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormChess
{


    public enum PlayerColor
    {
        White
      , Black
    }

    class Board
    {
        private Color ChessFieldColorLight = Color.Bisque;
        private Color ChessFieldColorDark = Color.Peru;

        public Board(PlayerColor playerColor = PlayerColor.White)
        {
            // domyslnie szachownica usawiona jest do gry bialymi

        }

        public void Restart()
        {

        }

    }
}

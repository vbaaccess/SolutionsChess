using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormChess
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            string s;

            s = "♜♞♝♛♚♝♞♜";
            s = s + System.Environment.NewLine;
            s = s + "♙♙♙♙♙♙♙♙";
            s = s + System.Environment.NewLine;
            s = s + System.Environment.NewLine;
            s = s + System.Environment.NewLine;
            s = s + System.Environment.NewLine;
            s = s + "♟♟♟♟♟♟♟♟";
            s = s + System.Environment.NewLine;
            s = s + "♖♘♗♔♕♗♘♖";
            richTextBoxBoard.Text = s;


            
        }
    }
}

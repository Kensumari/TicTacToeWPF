using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeWinform
{
    public partial class Form1 : Form
    {
        public Button b;

        bool endGame;

        Player player = new Player();

        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
                b = (Button)sender;
                b.Text = player.PlaySymbol();
                b.Enabled = false;
                EndCondition();
        }
        public void EndCondition()
        {
            if ((button1.Text == button2.Text) && (button2.Text == button3.Text) && (!button2.Enabled) ||
                (button4.Text == button5.Text) && (button5.Text == button6.Text) && (!button5.Enabled) ||
                (button7.Text == button8.Text) && (button8.Text == button9.Text) && (!button8.Enabled) ||
                (button1.Text == button4.Text) && (button4.Text == button7.Text) && (!button4.Enabled) ||
                (button2.Text == button5.Text) && (button5.Text == button8.Text) && (!button5.Enabled) ||
                (button3.Text == button6.Text) && (button6.Text == button9.Text) && (!button6.Enabled) ||
                (button1.Text == button5.Text) && (button5.Text == button9.Text) && (!button5.Enabled) ||
                (button3.Text == button5.Text) && (button5.Text == button7.Text) && (!button5.Enabled)
                )
            {
                endGame = true;
                MessageBox.Show (player.PlayerTurn + " won the game.");
            }
            if (endGame == false && player.Counter == 9)
            {
                MessageBox.Show("It's a draw");
            }
        }

        private void button_click(object sender, EventArgs e)
        {

        }
    }
}

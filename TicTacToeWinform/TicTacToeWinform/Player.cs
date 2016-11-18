using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeWinform
{
    class Player
    {
        // False = player 1, True = player 2
        public bool PlayerTurn;
        public int Counter;
        string symbol;
        public string PlaySymbol()
        {
            if (PlayerTurn == false)
            {
                symbol = "X";
            }
            else
            {
                symbol = "O";
            }
            PlayerTurn = !PlayerTurn;
            Counter++;
            return symbol;
        }
    }
}

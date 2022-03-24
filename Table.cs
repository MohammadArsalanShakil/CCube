using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCube
{
    class Table
    {
        bool player1;
        bool player2;
        bool tablefree;
        Game game;

        public Table()
        {
            this.tablefree = true;
        }
        public Table(bool player1 = false, bool player2 = false, bool tablefree = false)
        {
            this.player1 = player1;
            this.player2 = player2;
            this.tablefree = tablefree;
        }

        public bool Player1 { get => player1; set => player1 = value; }
        public bool Player2 { get => player2; set => player2 = value; }
        public bool Tablefree { get => tablefree; set => tablefree = value; }
        public Game Game { get => game; set => game = value; }

    }//end class
}//end namespace

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCube
{
    class Game
    {
        int gameid = 0;
        Player player1 = new Player();
        string player1cnic;
        Player player2 = new Player();
        string player2cnic;
        sbyte result;

        public Game()
        {

        }
        public Game(int gameid, Player player1, Player player2, sbyte result = -1)
        {
            this.gameid = gameid;
            this.Player1 = player1;
            this.Player2 = player2;
            this.result = result;
        }

        public int Gameid { get => gameid; set => gameid = value; }
        public sbyte Result { get => result; set => result = value; }
        public string Player1cnic { get => player1cnic; set => player1cnic = value; }
        public string Player2cnic { get => player2cnic; set => player2cnic = value; }
        internal Player Player1 { get => player1; set => player1 = value; }
        internal Player Player2 { get => player2; set => player2 = value; }

        public void Addplayer1(Player player) { Player1 = player; }
        public void Addplayer2(Player player) { Player2 = player; }
    }//end class
}//end namespace

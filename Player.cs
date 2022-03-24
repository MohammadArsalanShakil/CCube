using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCube
{
    class Player:Person
    {
        uint totalGamesPlayed;

        public uint TotalGamesPlayed
        {
            get { return totalGamesPlayed; }
            set { totalGamesPlayed = value; }
        }
        uint totalGamesWon;

        public uint TotalGamesWon
        {
            get { return totalGamesWon; }
            set { totalGamesWon = value; }
        }
        uint totalGamesLost;

        public uint TotalGamesLost
        {
            get { return totalGamesLost; }
            set { totalGamesLost = value; }
        }

        public Player()
        {

        }
        public Player(string cnic, string name, uint totalGamesPlayed = 0, uint totalGamesWon = 0, uint totalGamesLost = 0)
            : base(cnic, name)
        {
            this.totalGamesPlayed = totalGamesPlayed;
            this.totalGamesWon = totalGamesWon;
            this.totalGamesLost = totalGamesLost;
        }

        

        public override string getData()
        {
            string data = base.getData();
            data += "Total Games Played: " + this.totalGamesPlayed + "\n";
            data += "Total Games Won: " + this.totalGamesWon + "\n";
            data += "Total Games Lost: " + this.totalGamesLost + "\n";
            data += "------------------------------";
            return data;

        }
    }
}

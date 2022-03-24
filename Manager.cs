using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCube
{
    class Manager : Person
    {
        double salary;
        DateTime dutyTime;
        public FileHandler playerfile = new FileHandler();
        ArrayList gamelist = new ArrayList();
        static int gameID = 0;
        Game temp;
        bool wait = true;
        ArrayList playerwaitinglist = new ArrayList();

        ArrayList PlayerList;

        public void DisplayAllPlayers()
        {
            InputOutputHandler.DisplayAllPlayer(this.PlayerList);
        }

        public void RegisterNewPlayerduringgame(Player player)
        {
            //Player newPlayer = InputOutputHandler.GetPlayerInfoFromUser();
            PlayerList.Add(player);
        }

        public void RegisterNewPlayer()
        {
            Player newPlayer = InputOutputHandler.GetPlayerInfoFromUser();
            PlayerList.Add(newPlayer);
        }

        public void SearchPlayerInfobyCNIC()
        {
            Player player = new Player();
            string cnic = InputOutputHandler.GetPlayerCNIC();
            bool playerfound = false;
            for (int index = 0; index < PlayerList.Count; index++)
            {
                player = PlayerList[index] as Player;
                if (player.CNIC == cnic)
                {
                    playerfound = true;
                    break;
                }
            }
            if (playerfound)
                InputOutputHandler.displayPlayerInfo(player);
            else
            {
                Player falseplayer = new Player
                {
                    CNIC = "not found"
                };
                InputOutputHandler.EditPlayer(falseplayer);
            }
        }

        public bool SearchPlayerInfobyCNIC(string cnic)
        {
            Player player = new Player();
            
            bool playerfound = false;
            for (int index = 0; index < PlayerList.Count; index++)
            {
                player = PlayerList[index] as Player;
                if (player.CNIC == cnic)
                {
                    playerfound = true;
                    break;
                }
            }
            if (playerfound)
                return true;
            else
            {
                return false;
            }
        }

        public void SearchPlayerInfobyName()
        {
            Player player = new Player();
            string name = InputOutputHandler.getPlayerName();
            bool playerfound = false;
            int indexofplayer = -1;
            for (int index = 0; index < PlayerList.Count; index++)
            {
                player = PlayerList[index] as Player;
                if (player.Name == name)
                {
                    playerfound = true;
                    indexofplayer = index;
                    break;
                }
            }
            if (playerfound)
                InputOutputHandler.displayPlayerInfo(player);
            else
            {
                Player falseplayer = new Player
                {
                    Name = "not found"
                };
                InputOutputHandler.EditPlayer(falseplayer);
            }
        }

        public void EditPlayerInfobyCNIC(bool edit)//Getting bool if user wants to edit or delete
        {
            Player player = new Player();
            string cnic = InputOutputHandler.GetPlayerCNIC();
            bool playerfound = false;
            int indexofplayer = -1;
            for (int index = 0; index < PlayerList.Count; index++)
            {
                player = PlayerList[index] as Player;
                if (player.CNIC == cnic)
                {
                    playerfound = true;
                    indexofplayer = index;
                    break;
                }
            }
            if (playerfound && edit)//If user selects to edit and the index is found in the AraryList then user will be taken to editPlayer Function
                InputOutputHandler.EditPlayer(player);
            else if (!edit && playerfound)//If he wish to delete the player will be deleted from the record
                PlayerList.Remove(indexofplayer);
            else if (!playerfound)
            {
                Player falseplayer = new Player
                {
                    CNIC = "not found"
                };
                InputOutputHandler.EditPlayer(falseplayer);
            }
        }


        public void EditPlayerInfobyName(bool edit)
        {
            Player player = new Player();
            string name = InputOutputHandler.getPlayerName();
            bool playerfound = false;
            int indexofplayer = -1;
            for (int index = 0; index < PlayerList.Count; index++)
            {
                player = PlayerList[index] as Player;
                if (player.Name == name)
                {
                    playerfound = true;
                    indexofplayer = index;
                    break;
                }
            }
            if (playerfound && edit)
                InputOutputHandler.EditPlayer(player);
            else if (!edit)
                PlayerList.Remove(indexofplayer);
            else if (!playerfound)
            {
                Player falseplayer = new Player
                {
                    Name = "not found"
                };
                InputOutputHandler.EditPlayer(falseplayer);
            }
        }


        public Manager()
        {
            PlayerList = playerfile.PlayerList;
        }
        public Manager(string cnic,string name,double salary,DateTime dutyTime):base(cnic,name)
        {
            this.salary = salary;
            this.dutyTime = dutyTime;
        }

        public double Salary
        {
            set { salary = value; }
            get { return salary; }

        }

        public DateTime DutyTime
        {
            set { dutyTime = value; }
            get { return dutyTime; }

        }


        public override string getData()
        {
            string data = base.getData();
            data += "Salary :" + this.salary + "\n";
            data += "DutyTime :" + this.dutyTime.Hour + ":" + this.dutyTime.Minute + "\n";
            data += "------------------------------";
            return data;

        }

        public void Result()
        {
            int id = InputOutputHandler.getgameID();
            foreach (Game game in gamelist)
            {
                if (id == game.Gameid)
                {
                    game.Result = InputOutputHandler.result();
                    game.Player1.TotalGamesPlayed++;
                    game.Player2.TotalGamesPlayed++;
                    if (game.Result == -1)
                    {
                        game.Player2.TotalGamesWon++;
                        game.Player1.TotalGamesLost++;
                    }
                    else if (game.Result == 1)
                    {
                        game.Player1.TotalGamesWon++;
                        game.Player2.TotalGamesLost++;
                    }
                    break;
                }
            }
        }

        void ExitApplication()
        {
            playerfile.PlayerList = this.PlayerList;
            playerfile.writeback();
        }

        public void StartGamefor2()
        {
            Table gametable = new Table();
            gameID++;
            Player player1 = InputOutputHandler.GetPlayerInfoFromUser();
            Player player2 = InputOutputHandler.GetPlayerInfoFromUser();
            bool player1datamatch = SearchPlayerInfobyCNIC(player1.CNIC);
            bool player2datamatch = SearchPlayerInfobyCNIC(player2.CNIC);
            if (player1datamatch == false)
                RegisterNewPlayerduringgame(player1);
            if (player2datamatch == false)
                RegisterNewPlayerduringgame(player2);
            Game game = new Game(gameID, player1, player2);
            if (gamelist.Count < 10)
            {
                if (gametable.Tablefree == true)
                {
                    if (gametable.Player1 == false && gametable.Player2 == false)
                    {
                        gametable.Game = game;
                        gametable.Player1 = true;
                        gametable.Player2 = true;
                        gametable.Tablefree = false;
                        wait = false;
                        gamelist.Add(gametable);
                    }
                    else if (gametable.Player1 == true && gametable.Player2 == false)
                    {

                        temp = gametable.Game;
                        gametable.Game = game;
                        gametable.Player1 = true;
                        gametable.Player2 = true;
                        gametable.Tablefree = false;
                        wait = true;
                        gamelist.Add(gametable);
                    }
                    else if (gametable.Player1 == false && gametable.Player2 == true)
                    {

                        temp = gametable.Game;
                        gametable.Game = game;
                        gametable.Player1 = true;
                        gametable.Player2 = true;
                        gametable.Tablefree = false;
                        wait = true;
                        gamelist.Add(gametable);
                    }
                    else if (gametable.Player1 == true && gametable.Player2 == true)
                    {
                        temp = game;
                        wait = true;
                    }
                }
            }
            if (wait)
            {
                Waitinglist();
                InputOutputHandler.Waitmessage();
            }
            else
                InputOutputHandler.Gamestart();
        }

        void StartGameforrandom2(Game game)
        {
            Table gametable = new Table();
            gameID++;
            if (gamelist.Count < 10)
            {
                if (gametable.Tablefree == true)
                {
                    if (gametable.Player1 == false && gametable.Player2 == false)
                    {
                        gametable.Game = game;
                        gametable.Player1 = true;
                        if (gametable.Game.Player2.CNIC != "0")
                            gametable.Player2 = true;
                        else
                            gametable.Player2 = false;
                        gametable.Tablefree = false;
                        wait = false;
                    }
                    else if (gametable.Player1 == true && gametable.Player2 == false)
                    {

                        temp = gametable.Game;
                        gametable.Game = game;
                        if (gametable.Game.Player2.CNIC != "0")
                            gametable.Player2 = true;
                        else
                            gametable.Player2 = false;
                        gametable.Tablefree = false;
                        wait = true;
                    }
                }
            }
            if (wait)
                Waitinglist();
            else
                InputOutputHandler.Waitmessage();
        }

        public void Waitinglist()
        {
            playerwaitinglist.Add(temp);
        }

        public void StartGamefor1()
        {
            gameID++;
            Player player = InputOutputHandler.GetPlayerInfoFromUser();
            bool playerdatamatch = SearchPlayerInfobyCNIC(player.CNIC);
            if (playerdatamatch == false)
                RegisterNewPlayerduringgame(player);
            Game game = new Game();
            if (playerwaitinglist.Count != 0)
            {
                game = PlayerList[0] as Game;
                playerwaitinglist.RemoveAt(0);
                game.Addplayer2(player);
            }
            else
            {
                Player playerdummy = new Player { CNIC = "0" };
                game.Gameid = gameID;
                game.Player1 = player;
                game.Player2 = playerdummy;
            }
            StartGameforrandom2(game);
        }
    }//end class
}//end namespace

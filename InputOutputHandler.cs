using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCube
{
    class InputOutputHandler
    {
        public static Player GetPlayerInfoFromUser()
        {
            Player player = new Player();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("------Enter Information for Player-------");
            Console.WriteLine("---------------------------------------------");

            Console.Write("Enter CNIC: ");
            player.CNIC = Console.ReadLine();

            Console.Write("Enter Name: ");
            player.Name = Console.ReadLine();

            Console.WriteLine("---------------------------------------------");
            return player;
        }

        public static Manager GetManagerInfoFromUser()
        {
            Manager manager = new Manager();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("------Enter Information for New Player-------");
            Console.WriteLine("---------------------------------------------");

            Console.Write("Enter CNIC: ");
            manager.CNIC = Console.ReadLine();

            Console.Write("Enter Name: ");
            manager.Name = Console.ReadLine();

            Console.WriteLine("---------------------------------------------");
            return manager;
        }

        public static string GetPlayerCNIC()
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("------Enter CNIC for Searching Player-------");
            Console.WriteLine("---------------------------------------------");

            Console.Write("Enter CNIC: ");
            return Console.ReadLine();
        }

        public static string getManagerCNIC()
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("------Enter CNIC for Searching Player-------");
            Console.WriteLine("---------------------------------------------");

            Console.Write("Enter CNIC: ");
            return Console.ReadLine();
        }


        public static string getPlayerName()
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("------Enter Name for Searching Player-------");
            Console.WriteLine("---------------------------------------------");

            Console.Write("Enter Name: ");
            return Console.ReadLine();
        }

        public static string getManagerName()
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("------Enter Name for Searching Player-------");
            Console.WriteLine("---------------------------------------------");

            Console.Write("Enter Name: ");
            return Console.ReadLine();
        }

        public static void displayPlayerInfo(Player player)
        {
            if (player.CNIC == "not found" || player.Name=="not found")
                Console.WriteLine("Player with this CNIC/Name does not exist");
            else
                Console.WriteLine(player.getData());
        }

        public static void displayManagerInfo(Manager manager)
        {
            if (manager.CNIC == "not found" || manager.Name == "not found")
                Console.WriteLine("Player with this CNIC/Name does not exist");
            else
                Console.WriteLine(manager.getData());
        }

        public static void DisplayAllPlayer(ArrayList playerlist)
        {
            foreach (Player player in playerlist)
                Console.WriteLine(player.getData());
        }

        public static void DisplayAllManager(ArrayList managerlist)
        {
            foreach (Manager manager in managerlist)
                Console.WriteLine(manager.getData());
        }

        public static void EditPlayer(Player player)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("-----Enter Information for Change Player-----");
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("Press 1 for CNIC");
            Console.WriteLine("Press 2 for Name");

            int choice = int.Parse(Console.ReadLine());

            if (choice==1)
            {
                Console.WriteLine("Enter New CNIC: ");
                string cnic = Console.ReadLine();
                player.CNIC = cnic;
            }
            else if (choice == 2)
            {
                Console.WriteLine("Enter New Name: ");
                string name = Console.ReadLine();
                player.Name = name;
            }    
        }


        public static void EditManager(Manager manager)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("-----Enter Information for Change Player-----");
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("Press 1 for CNIC");
            Console.WriteLine("Press 2 for Name");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Enter New CNIC: ");
                string cnic = Console.ReadLine();
                manager.CNIC = cnic;
            }
            else if (choice == 2)
            {
                Console.WriteLine("Enter New Name: ");
                string name = Console.ReadLine();
                manager.Name = name;
            }
        }

        static public void Waitmessage()
        {
            Console.WriteLine("No table free at the moment");
            Console.WriteLine("Kindly wait till any table is free");
        }

        static public void Gamestart()
        {
            Console.WriteLine("Game Started");
        }

        public static int getgameID()
        {
            Console.WriteLine("Enter ID of game to enter result : ");
            return int.Parse(Console.ReadLine());
        }

        public static sbyte result()
        {
            Console.WriteLine("Enter result : ");
            return sbyte.Parse(Console.ReadLine());
        }
    }
}

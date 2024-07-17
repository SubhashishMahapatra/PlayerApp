using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerAgeComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player[] playerArray = new Player[5]
            {
                new Player(1, "Subhashish", 21),
                new Player(2, "Atharv", 22),
                new Player(3, "Athul", 23),
                new Player(4, "Devanshu", 25),
                new Player(5, "Nishank", 20)
            };

            int choice = 0;
            Player elderDetails = WhoIsElder(playerArray);

            bool programRunning = true;

            while (programRunning)
            {
                Console.WriteLine("1. Player Details 2. Who is Elder 3. Exit");
                choice = int.Parse(Console.ReadLine());

                switch (choice)

                {
                    case 1:
                        foreach (Player player in playerArray)
                        {
                            player.GetPlayerDetails();
                        }
                        break;
                    case 2:
                        Console.WriteLine("Elder Player Details are: ");
                        elderDetails.GetPlayerDetails();
                        break;
                    case 3:
                        programRunning = false;
                        break;

                }
                
            }

        }

        public static Player WhoIsElder(Player[] players) 
        {
           int maxAge = 0;
           Player elderPlayer = null;

            foreach (Player player in players)
            {
                if (player.GetPlayerAge() > maxAge) 
                {
                    maxAge = player.GetPlayerAge();
                    elderPlayer = player;
                }
            }
            return elderPlayer;


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerAgeComparison
{
    public class Player
    {
        public const int AGE  = 0;
        private int _playerId;
        private string _playerName;
        private int _playerAge;


        public Player(int playerId, string playerName):this(playerId, playerName, AGE)
        {

        }

         public Player(int playerId, string playerName, int playerAge)
        {
            _playerId = playerId;
            _playerName = playerName;
            _playerAge = playerAge;

        }

        public int GetId()
        {
            return _playerId;
        }

        public string GetPlayerName() 
        {
            return _playerName;
        }

        public int GetPlayerAge() 
        {
            return _playerAge;
        }
      
        public void GetPlayerDetails()
        {
            Console.WriteLine("Player Id: " + _playerId);
            Console.WriteLine("Player Name: " + _playerName);
            Console.WriteLine("Player Age: " + _playerAge);
            Console.WriteLine();
        }

    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_And_Delegates.Events_and_Multicast_Delegates
{
    class Player
    {
        // Player Name
        public string PlayerName { get; set; }

        // Simple constructor
        public Player(string name)
        {
            PlayerName = name;
            // subscribing to delegates OnGameStart and OnGameOver events.
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;
        }

        // At the start of the game, spawn the player.
        private void StartGame()
        {
            Console.WriteLine("Spawning Player: {0}", PlayerName);
        }

        // At the end of the game, remove the player.
        private void GameOver()
        {
            Console.WriteLine("Removing Player: {0}", PlayerName);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_And_Delegates.Events_and_Multicast_Delegates
{
    class AudioSystem
    {

        // Simple constructor
        public AudioSystem()
        {
            // subscribing to delegates OnGameStart and OnGameOver events.
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;
        }

        // At the start of the game, we want to enable the audio system engine and start playing audio clips.
        private void StartGame()
        {
            Console.WriteLine("Audio System started");
            Console.WriteLine("Playing Audio...");
        }

        // When the game is over, we want to stop our audio system
        private void GameOver()
        {
            Console.WriteLine("Audio System Stopped");
        }
    }
}

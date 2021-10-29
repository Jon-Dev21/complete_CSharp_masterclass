using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_And_Delegates.Events_and_Multicast_Delegates
{
    class RenderingEngine
    {

        // Simple constructor
        public RenderingEngine()
        {
            // subscribing to delegates OnGameStart and OnGameOver events.
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;
        }

        // At the start of the game, we want to enable the rendering engine and start drawing visuals.
        private void StartGame() 
        {
            Console.WriteLine("Rendering engine started");
            Console.WriteLine("Drawing Visuals");
        }

        // When the game is over, we want to stop our rendering engine
        private void GameOver()
        {
            Console.WriteLine("Rendering Engine Stopped");
        }
    }
}

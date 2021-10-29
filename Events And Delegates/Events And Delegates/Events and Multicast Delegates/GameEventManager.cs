using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_And_Delegates.Events_and_Multicast_Delegates
{
    class GameEventManager
    {
        // A new delegate type called GameEvent
        public delegate void GameEvent();

        // create two delegate variables called OnGameStart and OnGameOver.
        // Using event keyword to prevent us from making a reassignment error in our objects
        // that use this delegate GameEvent
        public static event GameEvent OnGameStart, OnGameOver;

        // a static method to trigger OnGameStart
        public static void TriggerGameStart()
        {
            // CHeck if the OnGameStart event is not empty, meaning that other methods already subscribed
            if (OnGameStart != null)
            {
                // Print a message
                Console.WriteLine("The game has started.");
                // Call OnGameStart that will trigger all the methods subscribed to this event.
                OnGameStart();
            }
        }

        // a static method to trigger OnGameOver
        public static void TriggerGameOver()
        {
            // CHeck if the OnGameOver event is not empty, meaning that other methods already subscribed
            if (OnGameOver != null)
            {
                // Print a message
                Console.WriteLine("The game has ended.");
                // Call OnGameOver that will trigger all the methods subscribed to this event.
                OnGameOver();
            }
        }
    }
}

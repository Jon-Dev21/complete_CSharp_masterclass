using System;
using System.Threading;

namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            // ==========================================
            // ============= Threads Basics =============
            // ==========================================

            // This only pauses the main thread.

            // Pause program for 1 second
            //Thread.Sleep(1000);
            //Console.WriteLine("Hello World! 1");
            //// Pause program for 1 second
            //Thread.Sleep(1000);
            //Console.WriteLine("Hello World! 2");
            //// Pause program for 1 second
            //Thread.Sleep(1000);
            //Console.WriteLine("Hello World! 3");
            //// Pause program for 1 second
            //Thread.Sleep(1000);
            //Console.WriteLine("Hello World! 4");

            // Creating a new threads
            new Thread(() => {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 1.");
            }).Start();

            new Thread(() => {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 2.");
            }).Start();

            new Thread(() => {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 3.");
            }).Start();

            new Thread(() => {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 4.");
            }).Start();

        }
    }
}

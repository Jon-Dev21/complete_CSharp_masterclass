using System;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;

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
            //new Thread(() => {
            //    Thread.Sleep(1000);
            //    Console.WriteLine("Thread 1.");
            //}).Start();

            //new Thread(() => {
            //    Thread.Sleep(1000);
            //    Console.WriteLine("Thread 2.");
            //}).Start();

            //new Thread(() => {
            //    Thread.Sleep(1000);
            //    Console.WriteLine("Thread 3.");
            //}).Start();

            //new Thread(() => {
            //    Thread.Sleep(1000);
            //    Console.WriteLine("Thread 4.");
            //}).Start();


            // ==========================================
            // ===== Thread Start, End & Completion =====
            // ==========================================

            // Use a thread to do something. If the task is done, then go ahead.

            // TaskCompletionSource is used to tell if a task is done or not.
            //var taskCompletionSource = new TaskCompletionSource<bool>();

            //var thread = new Thread(() =>
            //{
            //    Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} started");
            //    Thread.Sleep(5000);
            //    // Try to set task completion source to true.
            //    taskCompletionSource.TrySetResult(true);
            //    Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} ended");
            //});


            //// To start thread, we call thread.Start();
            //thread.Start();
            //var test = taskCompletionSource.Task.Result;
            //Console.WriteLine("Task done? {0}", test);


            // ==========================================
            // =========== Threads and Tasks ============
            // ==========================================

            //// { IsBackground = true } is used to run the thread in the background
            //new Thread(() =>
            //{
            //    Console.WriteLine("Thread 4");
            //    Console.WriteLine("Thread 4 started ===============");
            //    Thread.Sleep(1000);
            //    Console.WriteLine("Thread 4 ended ===============");
            //})
            //{ IsBackground = true }.Start();


            //// Will create 1000 threads
            //Enumerable.Range(0, 1000).ToList().ForEach(f =>
            //{
            //    // Thread pools only create threads that are required.
            //    // Queue is a method for execution. It executes when a Thread pool thread becomes available.
            //    ThreadPool.QueueUserWorkItem((o) =>
            //    {
            //        // Give me the Id of threads when started and when ended.
            //        // The thread pool will create threads for us but in a different safer way.
            //        Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} started");
            //        Thread.Sleep(1000);
            //        Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} ended");
            //    });

            //});

            //Console.ReadLine();
            //Thread.Sleep(10000);

            // Some threads end before others start.

            // Thread Pools are more secure than just creating threads
            // IF YOU USE THREADS, YOU HAVE TO CONTROL THEM.
            // DON'T RANDOMLY USE THREADS.

            // ==========================================
            // ============ Join and IsAlive ============
            // ==========================================

            // Join is a method that the thread class has
            // IsAlive is a property that it has

            Console.WriteLine("Main Thread Started");

            // Creating threads & passing functions to delegates.
            Thread thread1 = new Thread(Thread1Function);
            Thread thread2 = new Thread(Thread2Function);

            // Starting Threads
            thread1.Start();
            thread2.Start();

            // Using Join method.
            // Join will join this thread with the Main Thread and it blocks the main thread while it does.. 

            // COMMENT AND UNCOMMENT THIS LINE TO SEE HOW THE BEHAVIOR CHANGES
            // thread1.Join();

            // If thread1 Join takes a second,  
            if (thread1.Join(1000))
            {
                Console.WriteLine("Thread1 Function done");
            }
            else
            {
                Console.WriteLine("Thread1 Function wasn't done between 1 second.");
            }
            Console.WriteLine("Thread1 Function done");
            thread2.Join();
            Console.WriteLine("Thread2 Function done");
            
            // Looking at the IsAlive property.
            //if(thread1.IsAlive)
            //    Console.WriteLine("Thread 1 is still doing stuff");
            //else
            //    Console.WriteLine("Thread 1 completed.");

            // if We want to check if thread1 is doing stuff on a regular basis: 
            for (int i = 0; i < 10; i++)
            {
                if (thread1.IsAlive)
                {
                    Console.WriteLine("Thread 1 is still doing stuff");
                    Thread.Sleep(300);
                }   
                else
                    Console.WriteLine("Thread 1 completed.");
            }


            // Since threads joined, main thread waits until other threads are done.
            Console.WriteLine("Main Thread Ended");

            // When commenting thread1.Join(), it won't join the main thread,
            // therefore thread1 will end after the main thread. Main thread will move on.
            // To see the change, uncomment and comment thread1.Join(); to see the change in behavior
        }

        public static void Thread1Function()
        {
            Console.WriteLine("Thread 1 Function Started");
            // Making thread sleep for 3 seconds.
            Thread.Sleep(3000);
            Console.WriteLine("Thread1 Function coming back to caller.");
        }

        public static void Thread2Function()
        {
            Console.WriteLine("Thread 2 Function Started");
        }
    }
}

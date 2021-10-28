using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Inheritance_and_More_About_OOP
{
    // Inheritance Challenge 1 class.
    class VideoPost : Post
    {
        // Member Fields
        protected bool isPlaying = false;
        protected int currDuration = 0;
        public Timer timer;

        // Properties
        public string VideoURL { get; set; }
        public int Length { get; set; }
        

        // Default Constructor.
        public VideoPost() { }

        public VideoPost(string title, string username, string videoURL, bool isPublic, int length)
        {
            ID = GetNextId();
            Title = title;
            SentByUsername = username;
            VideoURL = videoURL;                
            IsPublic = isPublic;
            Length = length;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1}.\nURL: {2}\nDuration: {3}\nPosted by {4}", ID, Title, VideoURL,Length, SentByUsername);
        }
        public void Play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Playing Video");
                timer = new Timer(TimerCallback, null, 0, 1000);
            }
        }

        private void TimerCallback(Object o)
        {
            if(currDuration < Length)
            {
                currDuration++;
                //Console.Clear();
                Console.WriteLine("{0} seconds. Press enter to pause video.", currDuration);
                GC.Collect();               // This line tells the garbage collector to clean up.
            } else
            {

                Stop();
            }
        }

        public void Stop()
        {
            if(isPlaying)
            {
                Console.WriteLine("Video stopped at {0} seconds", currDuration);
                currDuration = 0;
                timer.Dispose();
                isPlaying = false;
            }
        }

        //public void Pause()
        //{
        //    if (isPlaying)
        //    {
        //        Console.WriteLine("Video paused at {0} seconds", currDuration);
        //        isPlaying = false;
        //    }
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_More_About_OOP
{
    // This class Post represents any web post. (Used to explain use of base constructor and method overriding)
    class Post
    {
        // post ID
        private static int currentPostId { get; set; }

        //properties
        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SentByUsername { get; set; }
        protected bool IsPublic { get; set; }

        // Default constructor sidenote. If a derived class does not invoke
        // a base-class constructor explicitly, the default constructor is called implicitly

        // default constructor
        public Post()
        {
            ID = 0;
            Title = "My First Post";
            IsPublic = true;
            SentByUsername = "calculus";
        }

        // parametized constructor
        public Post(string title, bool isPublic, string username)
        {
            this.ID = GetNextId();
            Title = title;
            IsPublic = isPublic;
            SentByUsername = username;
        }

        /// <summary>
        /// This method increments and returns the next ID.
        /// </summary>
        /// <returns></returns>
        protected int GetNextId()
        {
            return ++currentPostId;
        }

        /// <summary>
        /// This method updates the title and the post privacy with the passed values.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="isPublic"></param>
        public void UpdatePost (string title, bool isPublic)
        {
            Title = title;
            IsPublic = isPublic;
        }

        // Overriding the System.Object.ToString
        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2}", ID, Title, SentByUsername);
        }
    }
}

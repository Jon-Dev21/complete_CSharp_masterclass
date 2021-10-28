using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_More_About_OOP
{
    /// <summary>
    /// This class is a child class of parent class Post.
    /// It extends from Post
    /// (Used to explain use of base constructor and method overriding)
    /// </summary>
    class ImagePost : Post
    {
        // Stores the Image URL for an image post
        public string ImageURL { get; set; }

        public ImagePost() { }

        // The post constructor is Implicitly called
        public ImagePost(string title, string username, string imageURL, bool isPublic)
        {
            ID = GetNextId();
            Title = title;
            SentByUsername = username;
            ImageURL = imageURL;                // ImageURL is a member of ImagePost but not of Post
            IsPublic = isPublic;
        }

        // Challenge. Create a ToString method override for this class ImagePost.
        public override string ToString()
        {
            return String.Format("{0} - {1}. URL: {2} - by {3}", ID, Title, ImageURL,SentByUsername);
        }

    }
}

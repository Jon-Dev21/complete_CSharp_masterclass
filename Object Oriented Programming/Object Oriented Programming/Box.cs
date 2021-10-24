using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{
    class Box
    {
        // Constructor
        public Box(int length, int height, int width)
        {
            this.length = length;
            this.height = height;
            Width = width;
        }


        // Member variables 
        // These variables were public, therefore they were not safe.
        private int length;
        private int height;
        //private int width;   // Commenting member variable width and creating property width
        //private int volume;

        // Private member variables can only be accessed by public created properties or by setters and getters.

        // Created new property width
        public int Width { get; set; } // This line of code is the same as this:

        //public int Width
        //{
        //    get
        //    {
        //        return width;
        //    }
        //    set
        //    {
        //        width = value;
        //    }
        //} 

        // The only difference is that with the shorthand code, a member variable "width" is not needed.

        /// <summary>
        /// Volume property
        /// </summary>
        public int Volume {
            get
            {
                return length * Height * Width;
            }
        }

        /// <summary>
        /// Height property that sets and gets the member variable height.
        /// New shorthand getter and setter.
        /// </summary>
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if(value < 0)
                    height = -value;
                else
                    height = value;
            }
        }

        // Challenge property "FrontSurface"
        public int FrontSurface
        {
            get
            {
                return height * length;
            }
        }


        // Setter methods
        /// <summary>
        /// This method sets the length.
        /// </summary>
        /// <param name="length"></param>
        //public void SetLength(int length)
        //{
        //    if(length < 0)
        //    {
        //        throw new Exception("Length must be a positive number.");
        //    }
        //    this.length = length;
        //}

        /// <summary>
        /// This method sets the height.
        /// </summary>
        /// <param name="height"></param>
        //public void SetHeight(int height)
        //{
        //    if (height < 0)
        //    {
        //        throw new Exception("Height must be a positive number.");
        //    }
        //    this.height = height;
        //}

        /// <summary>
        /// This method sets the width.
        /// </summary>
        /// <param name="width"></param>
        //public void SetWidth(int width)
        //{
        //    if (width < 0)
        //    {
        //        throw new Exception("Width must be a positive number.");
        //    }
        //    this.width = width;
        //}

        /// <summary>
        /// This method sets the volume
        /// </summary>
        /// <param name="volume"></param>
        //public void SetVolume()
        //{
        //    this.volume = length*height*Width;
        //}

        // Getter Methods
        /// <summary>
        /// This method gets the length.
        /// </summary>
        /// <param name="length"></param>
        public int GetLength()
        {
            return this.length;
        }

        /// <summary>
        /// This method gets the height.
        /// </summary>
        /// <param name="height"></param>
        //public int GetHeight()
        //{
        //    return this.height;
        //}

        /// <summary>
        /// This method gets the width.
        /// </summary>
        /// <param name="width"></param>
        //public int GetWidth()
        //{
        //    return this.width;
        //}

        /// <summary>
        /// This method gets the volume
        /// </summary>
        /// <param name="volume"></param>
        //public int GetVolume()
        //{
        //    return this.length * this.height * this.Width;
        //}

        /// <summary>
        /// This method displays the box's info
        /// </summary>
        public void DisplayInfo()
        {
            Console.WriteLine("Length: {0}\nHeight: {1}\nWeight: {2}\nVolume: {3}",length,Height, Width, Volume);
        }
    }
}

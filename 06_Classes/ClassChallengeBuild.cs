using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Classes
{
    //Create a Room class that has three properties: one each for the length, width, and height.
    //Create a method that calculates total square footage.
    //Bonus: Create a method that calculates total lateral surface area.
    //Only allow the properties to be set from inside the class itself.

    public class Room
    {
        private int length;

        public int Length
        {
            get { return length; }
            set { length = value; }
        }

        private int width;

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        private int height;

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public int SquareFootage
        {
            get
            {
                return Length * Width;
            }
        }

        public int LateralSurfaceArea
        {
            get
            {
                return 2 * Length * Height + 2 * Width * Height;
            }
        }
    }
}

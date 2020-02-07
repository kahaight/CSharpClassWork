using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Challenges
{
    class Room
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public double CalculateFloorArea()
        {
            double floorArea = Length * Width;
            return floorArea;
        }

        public double CalculateFloorArea(int denominator)
        {
            double floorArea = Length * Width;
            double fractionFloorArea = floorArea / denominator;
            return fractionFloorArea;
        }

        public double CalcLatSurfArea()
        {
            return 2 * Length * Height + 2 * Width * Height;
        }



    }



}

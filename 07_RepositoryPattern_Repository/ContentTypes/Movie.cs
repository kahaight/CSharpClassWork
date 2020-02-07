using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository.ContentTypes
{
    public class Movie : StreamingContent
    {
        public double RunTime { get; set; }
        public Movie() { }
        public Movie(string genre, string title, int starRating, StreamingQuality typeOfQuality, string description, string language, MaturityRating maturityRating, double runTime)
            : base(genre, title, starRating, typeOfQuality, description, language, maturityRating)
        {
            RunTime = runTime;
        }


    }


}

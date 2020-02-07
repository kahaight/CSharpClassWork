using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository
    {
    public enum StreamingQuality { SD240, SD480, HD720, HD1080, UHD4K }
    public enum MaturityRating { G, PG, PG_13, R, NC_17}
    public class StreamingContent
    {
        public string Genre { get; set; }
        public string Title { get; set; }
        public int StarRating { get; set; }
        public StreamingQuality TypeOfStreamingQuality { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }
        public bool IsFamilyFriendly
        {
            get
            {
                switch (MaturityRating)
                {
                    case MaturityRating.G:
                    case MaturityRating.PG:
                    case MaturityRating.PG_13:
                        return true;
                    case MaturityRating.R:
                    case MaturityRating.NC_17:
                    default:
                        return false;
                }
            }
        }
        public MaturityRating MaturityRating { get; set; }


        public StreamingContent() { }
        public StreamingContent(string genre, string title, int starRating, StreamingQuality typeOfQuality, string description, string language, MaturityRating maturityRating)
        {
            Genre = genre;
            Title = title;
            StarRating = starRating;
            TypeOfStreamingQuality = typeOfQuality;
            Description = description;
            Language = language;
            MaturityRating = maturityRating;
        }
    }            
}

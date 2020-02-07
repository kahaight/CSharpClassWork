using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository.ContentTypes
{
    public class Show : StreamingContent
    {

        public Show()
        {
            Episodes = new List<Episode>();
        }
        public Show(string genre, string title, int starRating, StreamingQuality typeOfQuality, string description, string language, MaturityRating maturityRating, List<Episode> episodes)
            : base(genre, title, starRating, typeOfQuality, description, language, maturityRating)
        {
            Episodes = episodes;
        }

        public List<Episode> Episodes { get; set; }
        public int SeasonCount
        {
            get
            {
                //how do we get this??
                //new collection type: look up hashsets
                HashSet<int> seasonNumbers = new HashSet<int>();
                //check each episode and add it's season number to a hashset
                foreach (Episode episode in Episodes)
                {
                    seasonNumbers.Add(episode.SeasonNumber);
                }
                //look for all unique season numbers (count from hashset)
                return seasonNumbers.Count();
            }
        }
        public int EpisodeCount
        {
            //get => Episodes.Count(); = expression body
            get
            {
                return Episodes.Count();//block body
            }
        }
        public double AverageRunTime
        {
            get
            {
                //declare a total runtime starting at 0
                double totalRunTime = 0d;
                //add each episode's runtime to my total
                foreach (Episode individualEpisode in Episodes)
                {
                    totalRunTime += individualEpisode.RunTime;
                }
                //divide total run time by total episode count
                double averageRunTime = totalRunTime / EpisodeCount;
                //return calculated average
                return averageRunTime;
            }
        }

        public bool AddEpisodeToEpisodeList(Episode content)
        {
            int episodeListLength = Episodes.Count();
            Episodes.Add(content);
            bool wasAdded = episodeListLength + 1 == Episodes.Count();
            return wasAdded;
        }

    }

    public class Episode
    {
        public string Title { get; set; }
        public string EpisodeDescription { get; set; }
        public double RunTime { get; set; }
        public int SeasonNumber { get; set; }
        public int EpisodeNumber { get; set; }

        public Episode(string title, string episodeDescription, double runTime, int seasonNumber, int episodeNumber)
        {
            Title = title;
            EpisodeDescription = episodeDescription;
            RunTime = runTime;
            SeasonNumber = seasonNumber;
            EpisodeNumber = episodeNumber;
        }

    }
}

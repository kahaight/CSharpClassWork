using _07_RepositoryPattern_Repository.ContentTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository
{
    public class StreamingRepository : StreamingContentRepository
    {
        //Get all shows - Method
        public List<Show> GetAllShows()
        {
            //make a new list that holds shows
            List<Show> listOfShows = new List<Show>();
            //Look at all streaming content and check if it is a show
            foreach(StreamingContent content in _contentDirectory)
            {
                if (content is Show s)
                {
                    //add each show to a list of shows
                    //listOfShows.Add((Show)content); - casting
                    listOfShows.Add(s);//pattern matching - requires the s above
                }
            }
            //return that list
            return listOfShows;
        }
        //Get all movies - Method
        public List<Movie> GetAllMovies()
        {
            //make a new list that holds movies
            List<Movie> listOfMovies = new List<Movie>();
            //Look at all streaming content and check if it is a movie
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content is Movie s)
                {
                    //add each movie to a list of movies
                    //listOfMovies.Add((Movie)content); - casting
                    listOfMovies.Add(s);//pattern matching - requires the s above
                }
            }
            //return that list
            return listOfMovies;
        }
        //Get show by title - Method
        //Get movie by title - Method

        //Update existing show - Method
        //Update existing movie - Method

        //Delete existing show by title - MEthod
        //Delete existing movie by title - Method
    }
}

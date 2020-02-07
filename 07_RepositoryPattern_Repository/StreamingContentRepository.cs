using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository
{
    public class StreamingContentRepository
    {
        protected readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();
        public bool AddContentToDirectory(StreamingContent content)
        {
            int directoryLength = _contentDirectory.Count();
            _contentDirectory.Add(content);
            bool wasAdded = directoryLength + 1 == _contentDirectory.Count();
            return wasAdded;
        }

        public List<StreamingContent> GetAllContents()
        {
            return _contentDirectory;
        }

        public StreamingContent GetContentByTitle(string title)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower() == title.ToLower())
                {
                    return content;
                }
            }
            return null;
        }

        public bool UpdateExistingContent(string originalTitle, StreamingContent newContent)
        {
            StreamingContent oldContent = GetContentByTitle(originalTitle);
            if (oldContent != null)
            {
                oldContent.Title = newContent.Title;
                oldContent.Description = newContent.Description;
                oldContent.Genre = newContent.Genre;
                oldContent.Language = newContent.Language;
                oldContent.MaturityRating = newContent.MaturityRating;
                oldContent.TypeOfStreamingQuality = newContent.TypeOfStreamingQuality;
                oldContent.StarRating = newContent.StarRating;

                return true;
            }
            return false;

        }

        public bool DeleteExistingContent(string title)
        {
            StreamingContent foundContent = GetContentByTitle(title);
            bool deletedResult = _contentDirectory.Remove(foundContent);
            return deletedResult;
        }

        /*Get by other parameters:
            Get All Content between StarRating Range
        Refactor code to return lists in alphabetical order*/

        public List<StreamingContent> GetContentOfStarRating(int lowRating, int highRating)
        {
            List<StreamingContent> contents = new List<StreamingContent>();

            for (int i = lowRating; i <= highRating; i++)
            {
                foreach (StreamingContent content in _contentDirectory)
                {
                    if (content.StarRating == i)
                    {
                        contents.Add(content);
                    }
                }
            }
            List<StreamingContent> SortedList = contents.OrderBy(o => o.Title).ToList();
            return SortedList;
        }

        /* Get All By MaturityRating*/

        public List<StreamingContent> GetContentOfMaturityRating(MaturityRating maturityRating)
        {
            List<StreamingContent> contents = new List<StreamingContent>();

            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.MaturityRating == maturityRating)
                {
                    contents.Add(content);
                }
            }
            List<StreamingContent> SortedList = contents.OrderBy(o => o.Title).ToList();
            return SortedList;
        }

        /*Get All By Family Friendly*/

        public List<StreamingContent> GetFamilyFriendlyContent()
        {
            List<StreamingContent> contents = new List<StreamingContent>();
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.IsFamilyFriendly)
                {
                    contents.Add(content);
                }
            }
            List<StreamingContent> SortedList = contents.OrderBy(o => o.Title).ToList();
            return SortedList;
        }
        /*Get All By Language*/

        public List<StreamingContent> GetContentOfLanguage(string language)
        {
            List<StreamingContent> contents = new List<StreamingContent>();
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Language == language)
                {
                    contents.Add(content);
                }
            }
            List<StreamingContent> SortedList = contents.OrderBy(o => o.Title).ToList();
            return SortedList;
        }
    }
}

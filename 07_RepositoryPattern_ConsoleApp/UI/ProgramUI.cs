using _07_RepositoryPattern_Repository;
using _07_RepositoryPattern_Repository.ContentTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_ConsoleApp.UI
{
    class ProgramUI
    {

        private readonly StreamingRepository _streamingRepo = new StreamingRepository();
        public void Run()
        {
            SeedContent();
            RunMenu();
        }

        private void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine("Select an option number:\n" +
                    "1. Display All Streaming Content\n" +
                    "2. Display All Shows\n" +
                    "3. Display All Movies\n" +
                    "4. Add Streaming Content\n" +
                    "5. Update Existing Content\n" +
                    "6. Remove Streaming Content\n" +
                    "7. Exit");

                string userInput = Console.ReadLine();
                userInput = userInput.Replace(" ", "");
                switch (userInput)
                {
                    case "1":
                        DisplayAllContent();
                        break;
                    case "2":
                        DisplayAllShows();
                        break;
                    case "3":
                        DisplayAllMovies();
                        break;
                    case "4":
                        AddNewStreamingContent();
                        break;
                    case "5":
                        UpdateExistingContent();
                        break;
                    case "6":
                        //Remove Streaming Content
                        break;
                    case "7":
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Input, press any key to continue");
                        Console.ReadKey();
                        break;
                }
            }
        }


        private void DisplayAllContent()
        {
            Console.Clear();
            List<StreamingContent> directory = _streamingRepo.GetAllContents();

            //go through each item of our content and display its properties
            foreach (StreamingContent content in directory)
            {
                Console.WriteLine($"Title: {content.Title}\n" +
                    $"Description: {content.Description}\n" +
                    $"Stars: {content.StarRating}\n" +
                    $"Genre: {content.Genre}\n" +
                    $"Language: {content.Language}\n" +
                    $"Quality: {content.TypeOfStreamingQuality}\n" +
                    $"Maturity: {content.MaturityRating}\n" +
                    $"Family Friendly: {content.IsFamilyFriendly}\n" +
                    $"");
            }

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        private void DisplayAllShows()
        {
            Console.Clear();
            List<Show> directory = _streamingRepo.GetAllShows();

            //go through each item of our content and display its properties
            foreach (Show show in directory)
            {
                Console.WriteLine($"Title: {show.Title}\n" +
                  $"Description: {show.Description}\n" +
                  $"Stars: {show.StarRating}\n" +
                  $"Genre: {show.Genre}\n" +
                  $"Language: {show.Language}\n" +
                  $"Quality: {show.TypeOfStreamingQuality}\n" +
                  $"Maturity: {show.MaturityRating}\n" +
                  $"Family Friendly: {show.IsFamilyFriendly}\n" +
                  $"Average Run Time: {show.AverageRunTime}\n" +
                  $"Episodes: {show.EpisodeCount}\n" +
                  $"Seasons: {show.SeasonCount}\n" +
                  $"");
            }

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        private void DisplayAllMovies()
        {
            Console.Clear();
            List<Movie> directory = _streamingRepo.GetAllMovies();

            //go through each item of our content and display its properties
            foreach (Movie movie in directory)
            {
                Console.WriteLine($"Title: {movie.Title}\n" +
                  $"Description: {movie.Description}\n" +
                  $"Stars: {movie.StarRating}\n" +
                  $"Genre: {movie.Genre}\n" +
                  $"Language: {movie.Language}\n" +
                  $"Quality: {movie.TypeOfStreamingQuality}\n" +
                  $"Maturity: {movie.MaturityRating}\n" +
                  $"Family Friendly: {movie.IsFamilyFriendly}\n" +
                  $"Run Time (minutes): {movie.RunTime}\n" +
                  $"");
            }

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        private void AddNewStreamingContent()
        {
            bool endAddNewContent = false;
            while (!endAddNewContent)
            {
                Console.Clear();

                {
                    StreamingContent streamingContent = new StreamingContent();
                    string qualityUser;
                    string maturityUser;
                    StreamingQuality output;
                    MaturityRating output2;
                    Console.WriteLine("Enter new streaming content title:\n");
                    streamingContent.Title = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine($"Enter {streamingContent.Title} description:\n");
                    streamingContent.Description = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine($"Enter {streamingContent.Title} star rating:\n");
                    streamingContent.StarRating = Convert.ToInt32(Console.ReadLine());
                    //streamingContent.StarRating = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine($"Enter {streamingContent.Title} genre:\n");
                    streamingContent.Genre = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine($"Enter {streamingContent.Title} language:\n");
                    streamingContent.Language = Console.ReadLine();
                    Console.Clear();
                    bool validQualityEntry = false;
                    while (!validQualityEntry)
                    {
                        Console.WriteLine($"Enter {streamingContent.Title} quality.\n" +
                            $"Select from:\n" +
                            $"SD240\n" +
                            $"SD480\n" +
                            $"HD720\n" +
                            $"HD1080\n" +
                            $"UHD4K\n");
                        qualityUser = (Console.ReadLine()).ToUpper();
                        Console.Clear();
                        if (Enum.TryParse(qualityUser, out output))
                        {
                            streamingContent.TypeOfStreamingQuality = output;
                            validQualityEntry = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input, try again:");
                        }
                    }
                    Console.Clear();
                    bool validMaturityEntry = false;
                    while (!validMaturityEntry)
                    {
                        Console.WriteLine($"Enter {streamingContent.Title} maturity rating:\n" +
                            $"Select From:\n" +
                            $"G\n" +
                            $"PG\n" +
                            $"PG_13\n" +
                            $"R\n" +
                            $"NC_17");
                        maturityUser = (Console.ReadLine()).ToUpper();
                        Console.Clear();
                        if (Enum.TryParse(maturityUser, out output2))
                        {
                            streamingContent.MaturityRating = output2;
                            validMaturityEntry = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input, try again:");
                        }
                    }
                    bool continueToDisplay = false;
                    while (!continueToDisplay)
                    {
                        Console.Clear();
                        Console.WriteLine("Here is what you entered");
                        Console.WriteLine($"Title: {streamingContent.Title}\n" +
                                $"Description: {streamingContent.Description}\n" +
                                $"Stars: {streamingContent.StarRating}\n" +
                                $"Genre: {streamingContent.Genre}\n" +
                                $"Language: {streamingContent.Language}\n" +
                                $"Quality: {streamingContent.TypeOfStreamingQuality}\n" +
                                $"Maturity: {streamingContent.MaturityRating}\n" +
                                $"Family Friendly: {streamingContent.IsFamilyFriendly}\n" +
                                $"\n" +
                                $"Do you wish to add {streamingContent.Title} to the directory?\n" +
                                $"Enter 'N' to reenter your content\n" +
                                $"Enter 'Y' to add {streamingContent.Title} to the directory");
                        string continueYN = (Console.ReadLine()).ToUpper();
                        if (continueYN == "Y")
                        {
                            _streamingRepo.AddContentToDirectory(streamingContent);
                            endAddNewContent = true;
                            continueToDisplay = true;
                        }
                        else if (continueYN == "N")
                        {
                            continueToDisplay = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input, try again.");
                        }
                    }
                }
            }

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

        }

        private void UpdateExistingContent()

        {
            bool endUpdateContent = false;
            while (!endUpdateContent)
            {
                Console.Clear();
                string qualityUser;
                string maturityUser;
                StreamingQuality output;
                MaturityRating output2;
                Console.WriteLine("Enter the title of the content you wish to update:");
                string titleInput = Console.ReadLine();
                StreamingContent existingContent = _streamingRepo.GetContentByTitle(titleInput);
                if (existingContent == null)
                {
                    Console.WriteLine("There is no content with that Title.\n" +
                        "Press any key to continue");
                    Console.ReadKey();
                }
                else
                {
                    Console.Clear();
                    StreamingContent updatedContent = new StreamingContent();
                    Console.WriteLine($"The title is {existingContent.Title}, update to:\n");
                    string newTitle = Console.ReadLine();
                    updatedContent.Title = newTitle;
                    Console.Clear();
                    Console.WriteLine($"The description is {existingContent.Description}, update to:\n");
                    string newDescription = Console.ReadLine();
                    updatedContent.Description = newDescription;
                    Console.Clear();
                    Console.WriteLine($"The star rating is {existingContent.StarRating}, update to:\n");
                    updatedContent.StarRating = Convert.ToInt32(Console.ReadLine());
                    //streamingContent.StarRating = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine($"The genre is {existingContent.Genre}, update to:\n");
                    updatedContent.Genre = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine($"The language is {existingContent.Language}, update to:\n");
                    updatedContent.Language = Console.ReadLine();
                    Console.Clear();
                    bool validQualityEntry = false;
                    while (!validQualityEntry)
                    {
                        Console.WriteLine($"The video quality is {existingContent.TypeOfStreamingQuality}, to update\n" +
                            $"Select from:\n" +
                            $"SD240\n" +
                            $"SD480\n" +
                            $"HD720\n" +
                            $"HD1080\n" +
                            $"UHD4K\n");
                        qualityUser = (Console.ReadLine()).ToUpper();
                        Console.Clear();
                        if (Enum.TryParse(qualityUser, out output))
                        {
                            updatedContent.TypeOfStreamingQuality = output;
                            validQualityEntry = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input, try again:");
                        }
                    }
                    Console.Clear();
                    bool validMaturityEntry = false;
                    while (!validMaturityEntry)
                    {
                        Console.WriteLine($"Enter {existingContent.Title} maturity rating:\n" +
                            $"Select From:\n" +
                            $"G\n" +
                            $"PG\n" +
                            $"PG_13\n" +
                            $"R\n" +
                            $"NC_17");
                        maturityUser = (Console.ReadLine()).ToUpper();
                        Console.Clear();
                        if (Enum.TryParse(maturityUser, out output2))
                        {
                            updatedContent.MaturityRating = output2;
                            validMaturityEntry = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input, try again:");
                        }
                    }
                    bool continueToDisplay = false;
                    while (!continueToDisplay)
                    {
                        Console.Clear();
                        Console.WriteLine("Here is what you entered");
                        Console.WriteLine($"Title: {updatedContent.Title}\n" +
                                $"Description: {updatedContent.Description}\n" +
                                $"Stars: {updatedContent.StarRating}\n" +
                                $"Genre: {updatedContent.Genre}\n" +
                                $"Language: {updatedContent.Language}\n" +
                                $"Quality: {updatedContent.TypeOfStreamingQuality}\n" +
                                $"Maturity: {updatedContent.MaturityRating}\n" +
                                $"Family Friendly: {updatedContent.IsFamilyFriendly}\n" +
                                $"\n" +
                                $"Do you wish to commit changes to the directory?\n" +
                                $"Enter 'N' to reenter your content\n" +
                                $"Enter 'Y' to commit changes to the directory");
                        string continueYN = (Console.ReadLine()).ToUpper();
                        if (continueYN == "Y")
                        {
                            _streamingRepo.UpdateExistingContent(existingContent.Title, updatedContent);
                            endUpdateContent = true;
                            continueToDisplay = true;
                        }
                        else if (continueYN == "N")
                        {
                            continueToDisplay = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input, try again.");
                        }
                    }
                }
            }

        }

        private void SeedContent()
        {
            StreamingContent toyStory = new StreamingContent("Bromance", "Toy Story", 5, StreamingQuality.HD720, "What", "English", MaturityRating.G);
            _streamingRepo.AddContentToDirectory(toyStory);

            Movie rubber = new Movie("Horror", "Rubber", 5, StreamingQuality.SD480, "What", "French", MaturityRating.R, 120);
            _streamingRepo.AddContentToDirectory(rubber);

            Show supernatural = new Show("Horror", "Supernatural", 5, StreamingQuality.HD1080, "Sam gets knocked out a lot", "English", MaturityRating.PG_13, new List<Episode>());
            _streamingRepo.AddContentToDirectory(supernatural);
        }
    }
}


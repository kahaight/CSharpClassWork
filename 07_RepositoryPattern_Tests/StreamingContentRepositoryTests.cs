using _07_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentRepositoryTests
    {
        [TestMethod]
        public void AddToDirectory_ShouldGetCorrectBoolean()
        {
            StreamingContent content = new StreamingContent();
            StreamingContentRepository repository = new StreamingContentRepository();

            bool addResult = repository.AddContentToDirectory(content);

            Assert.IsTrue(addResult);
        }

        [TestMethod]
        public void ReadDirectory_ShouldReturnCorrectCollection()
        {
            StreamingContent content = new StreamingContent();
            StreamingContentRepository repo = new StreamingContentRepository();

            repo.AddContentToDirectory(content);

            List<StreamingContent> contents = repo.GetAllContents();

            bool directoryHasContent = contents.Contains(content);

            Assert.IsTrue(directoryHasContent);
        }

        private StreamingContentRepository _repo;
        private StreamingContent _content;
        [TestInitialize]
        public void Arrange()
        {
            _repo = new StreamingContentRepository();
            _content = new StreamingContent("Drama", "Rubber", 1, StreamingQuality.UHD4K, "A car tyre comes to life with the power to make people explode and goes on a murderous rampage through the California desert.", "French", MaturityRating.R);
            _repo.AddContentToDirectory(_content);
            _content = new StreamingContent("Drama", "Blubber", 3, StreamingQuality.UHD4K, "A car tyre comes to life with the power to make people explode and goes on a murderous rampage through the California desert.", "English", MaturityRating.NC_17);
            _repo.AddContentToDirectory(_content);
            _content = new StreamingContent("Drama", "Flubber", 4, StreamingQuality.UHD4K, "A car tyre comes to life with the power to make people explode and goes on a murderous rampage through the California desert.", "English", MaturityRating.G);
            _repo.AddContentToDirectory(_content);
            _content = new StreamingContent("Drama", "Grubber", 4, StreamingQuality.UHD4K, "A car tyre comes to life with the power to make people explode and goes on a murderous rampage through the California desert.", "German", MaturityRating.R);
            _repo.AddContentToDirectory(_content);
            _content = new StreamingContent("Drama", "Nubber", 5, StreamingQuality.UHD4K, "A car tyre comes to life with the power to make people explode and goes on a murderous rampage through the California desert.", "German", MaturityRating.R);
            _repo.AddContentToDirectory(_content);
            _content = new StreamingContent("Drama", "Dubber", 6, StreamingQuality.UHD4K, "A car tyre comes to life with the power to make people explode and goes on a murderous rampage through the California desert.", "German", MaturityRating.G);
            _repo.AddContentToDirectory(_content);

        }
        [TestMethod]
        public void GetByTitle_ShouldReturnCorrectContent()
        {
            StreamingContent searchResult = _repo.GetContentByTitle("Rubber");
            string title = searchResult.Title;
            Assert.AreEqual("Rubber", title);
        }

        [TestMethod]
        public void UpdateExistingContent_ShouldReturnTrue()
        {
            StreamingContent newContent = new StreamingContent("Drama", "Rubber", 2, StreamingQuality.UHD4K, "A car tyre comes to life with the power to make people explode and goes on a murderous rampage through the California desert.", "French", MaturityRating.R);
            bool updateResult = _repo.UpdateExistingContent("Rubber", newContent);

            Assert.IsTrue(updateResult);

        }

        [TestMethod]
        public void DeleteExistingResult_ShouldReturnTrue()
        {
            bool removeResult = _repo.DeleteExistingContent("Rubber");

            Assert.IsTrue(removeResult);
        }

        [TestMethod]
        public void GetContentOfStarRating_ShouldReturnTrue()
        {
            List<StreamingContent> contents = _repo.GetContentOfStarRating(3, 5);
            int contentsCount = contents.Count();
            Assert.AreEqual(4, contentsCount);
            StreamingContent content = contents.First();
            string title = content.Title;
            Assert.AreEqual("Blubber", title);
            Console.WriteLine(title);


        }

        [TestMethod]
        public void GetContentOfMaturityRating_ShouldReturnTrue()
        {
            List<StreamingContent> contents = _repo.GetContentOfMaturityRating(MaturityRating.R);
            int contentsCount = contents.Count();
            Assert.AreEqual(3, contentsCount);
            StreamingContent content = contents.First();
            string title = content.Title;
            Assert.AreEqual("Grubber", title);
            Console.WriteLine(title);
        }
        [TestMethod]
        public void GetFamilyFriendlyContent_ShouldReturnTrue()
        {
            List<StreamingContent> contents = _repo.GetFamilyFriendlyContent();
            int contentsCount = contents.Count();
            Assert.AreEqual(2, contentsCount);
            StreamingContent content = contents.First();
            string title = content.Title;
            Assert.AreEqual("Dubber", title);
            Console.WriteLine(title);
        }
        [TestMethod]
        public void GetContentOfLanguage_ShouldReturnTrue()
        {
            List<StreamingContent> contents = _repo.GetContentOfLanguage("German");
            int contentsCount = contents.Count();
            Assert.AreEqual(3, contentsCount);
            StreamingContent content = contents.First();
            string title = content.Title;
            Assert.AreEqual("Dubber", title);
            Console.WriteLine(title);
        }
    }
}

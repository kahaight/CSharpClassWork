using System;
using _07_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _07_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentTests
    {
        [TestMethod]
        public void SetTitle_ShouldSetCorrectString()
        {
            StreamingContent content = new StreamingContent();
            content.Title = "The Matrix: Reloaded";

            string expected = "The Matrix: Reloaded";
            string actual = content.Title;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SetGenre_ShouldSetCorrectString()
        {
            StreamingContent content = new StreamingContent();
            content.Genre = "Horror";

            string expected = "Horror";
            string actual = content.Genre;

            Assert.AreEqual(expected, actual);
        }
        [DataTestMethod]
        [DataRow(MaturityRating.R, false)]
        [DataRow(MaturityRating.NC_17, false)]
        [DataRow(MaturityRating.G, true)]
        [DataRow(MaturityRating.PG, true)]

        public void SetMaturityRating_ShouldGetCorrectIsFamilyFriendly(MaturityRating rating, bool isFriendly)
        {
            StreamingContent content = new StreamingContent("Content Genre", "Content Title", 1, StreamingQuality.HD1080, "Content Description", "Content Language", rating);

            bool actual = content.IsFamilyFriendly;
            bool expected = isFriendly;

            Assert.AreEqual(actual, expected);

        }

        [TestMethod]
        public void MyTestMethod()
        {

        }
    }
}

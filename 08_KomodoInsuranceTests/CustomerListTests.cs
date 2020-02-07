using System;
using _08_KomodoInsurance;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _08_KomodoInsuranceTests
{
    [TestClass]
    public class CustomerListTests
    {

        //private _repo;
        //private Episode _content;
        //[TestInitialize]
        //public void Arrange()
        //{
        //    _repo = new Show();
        //    _content = new Episode("Pilot", "As children, Sam (Padalecki) and Dean Winchester's (Ackles) mother Mary (Samantha Smith) died a violent and unexplainable death, which in turn led their father, John Winchester (Jeffrey Dean Morgan), to teach them hunting skills in search of the creature that took her life. Years later, while attending Stanford University, Sam is forced back into the paranormal world by Dean, who has come to tell him that their father is missing. The two travel to Jericho, California, to find him, but their search is put on hold when they discover that a ghostly Woman in White (Sarah Shahi)—the spirit of a woman who drowned her children and then killed herself—has been taking male victims. They investigate, but Dean is arrested for impersonating a federal agent. However, he manages to escape custody, and saves his brother from the vengeful spirit. The Woman in White is finally put to rest after the brothers force her to confront the spirits of her children. Sam later returns home but discovers his girlfriend Jessica (Adrianne Palicki) pinned to the ceiling. He is then forced to watch as she is killed in the same supernatural manner as his mother was. Jessica's death prompts him to return to the life of hunting with Dean.", 46d, 1, 1);
        //    _repo.AddEpisodeToEpisodeList(_content);
        [TestMethod]
        public void AddCustomerTest_ShouldReturnTrue()
        {
            Customer customer = new Customer(1, "Haight", 33, new DateTime(2020,2,4));
            CustomerList customers = new CustomerList();
            bool wasAdded = customers.AddCustomerToList(customer);
            Assert.IsTrue(wasAdded);
        }
    }
}

using System;
using System.Collections.Generic;
using _07_RepositoryPattern_Repository;
using _07_RepositoryPattern_Repository.ContentTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _07_RepositoryPattern_Tests
{
    [TestClass]
    public class ShowTests
    {


        private Show _repo;
        private Episode _content;
        [TestInitialize]
        public void Arrange()
        {
            _repo = new Show();
            _content = new Episode("Pilot", "As children, Sam (Padalecki) and Dean Winchester's (Ackles) mother Mary (Samantha Smith) died a violent and unexplainable death, which in turn led their father, John Winchester (Jeffrey Dean Morgan), to teach them hunting skills in search of the creature that took her life. Years later, while attending Stanford University, Sam is forced back into the paranormal world by Dean, who has come to tell him that their father is missing. The two travel to Jericho, California, to find him, but their search is put on hold when they discover that a ghostly Woman in White (Sarah Shahi)—the spirit of a woman who drowned her children and then killed herself—has been taking male victims. They investigate, but Dean is arrested for impersonating a federal agent. However, he manages to escape custody, and saves his brother from the vengeful spirit. The Woman in White is finally put to rest after the brothers force her to confront the spirits of her children. Sam later returns home but discovers his girlfriend Jessica (Adrianne Palicki) pinned to the ceiling. He is then forced to watch as she is killed in the same supernatural manner as his mother was. Jessica's death prompts him to return to the life of hunting with Dean.", 46d, 1, 1);
           _repo.AddEpisodeToEpisodeList(_content);
            _content = new Episode("Wendigo", "After having no luck in the investigation of Jessica's death, the brothers follow instructions found in their father's journal and head to Blackwater Ridge, Lost Creek, Colorado. Posing as park rangers, they help a young woman named Haley (Gina Holden) and her younger brother Ben (Alden Ehrenreich) search for their lost older brother Tommy (Graham Wardle), who disappeared while on a camping trip. Sam and Dean soon realize that he was taken by a wendigo that has terrorized the woods since 1936. While searching, Haley and Dean are kidnapped by the creature, but Sam and Ben are able to track them to a mine. After Dean, Haley, and Tommy are freed, they kill the wendigo with a flare gun.", 44d, 1, 2);
            _repo.AddEpisodeToEpisodeList(_content);
            _content = new Episode("In My Time of Dying", "As the season opens, the Winchesters are taken to a hospital in Memphis, Tennessee following a car wreck caused by one of the demon Azazel's henchmen. Though Sam (Padalecki) and his father John (Jeffrey Dean Morgan) make it out of the crash with minor injuries, a dying Dean (Ackles) is in a coma. He has an out-of-body experience, and is approached by a Reaper (Lindsey McKeon) who tries to take his soul. She reveals that if he refuses to move on, he will one day become a vengeful spirit. Meanwhile, Sam tries without success to save his brother, so John contacts Azazel (Fredric Lehne) and offers to make a deal; in exchange for saving Dean's life: he will give up his own life, his immortal soul, and the mystical Colt—a gun capable of killing anything. Dean is saved before he can die, but after making peace with his sons, John dies.", 50d, 2, 1);
            _repo.AddEpisodeToEpisodeList(_content);
            _content = new Episode("Everybody Loves A Clown", "After cremating their father's body, Sam and Dean refuse to discuss his death. Instead, they head back to work, and track an old message on John's phone to Harvelle's Roadhouse, a bar frequented by hunters. There they meet Ellen Harvelle (Samantha Ferris), an old friend of John's, and her daughter Jo (Alona Tal). As the group's resident genius, Ash (Chad Lindberg), attempts to analyze John's research on Azazel with his computer, the brothers investigate the murders of visitors to a traveling carnival, currently near Medford, Wisconsin. They discover that a Rakshasa—a demon of Hindu mythology—has been taking the form of a clown and tricking children into inviting it into their homes so that it can eat their parents. When not feeding, it takes the form of a blind knife thrower at the carnival. The brothers kill it with a brass pipe. Dean later takes out his anger at his father's death on the Impala, one of his most prized possessions.", 55d, 2, 2);
            _repo.AddEpisodeToEpisodeList(_content);
            _content = new Episode("The Magnificent Seven", "The season begins with brothers Sam (Jared Padalecki) and Dean Winchester (Jensen Ackles) bracing themselves for the possibility of an apocalyptic war. They realize that hunting down the hundreds of spirits that escaped from the Devil's Gate—a doorway to Hell briefly opened at the end of the previous season—will be an enormous task. With only a year left to live, he made a demonic pact to resurrect Sam, Dean decides to live life to the fullest and exhibits a carefree attitude that troubles Sam, who is trying to find a loophole. Friend and fellow hunter Bobby Singer (Jim Beaver) informs the brothers about a supernatural sighting in Nebraska, which turns out to be demonic manifestations of the Seven Deadly Sins. While investigating, they meet Isaac (Peter Macon) and Tamara (Caroline Chikezie), a husband and wife team of hunters. Isaac and Tamara trail one of the demons to a bar, but discover that all the patrons are demonically possessed. The two are restrained, and Isaac dies after being forced to drink drain cleaner. Before the demons can target Tamara, Bobby and the Winchesters crash their car into the building. They throw the personification of Envy into the trunk, and drive away with Tamara. The hunters interrogate the demon and then exorcise it. Later that night, the other Sins track them down. During the scuffle, a mysterious blonde named Ruby (Katie Cassidy) saves Sam and kills three demons, which are typically immune to physical harm, with a magical knife before departing. The rest of the Sins are exorcised. As Sam continues his research the next day, Dean reveals that a clause in his pact will end Sam's life if he tries to escape the deal.", 49d, 3, 1);
            _repo.AddEpisodeToEpisodeList(_content);
            _content = new Episode("The Kids Are Alright", "Dean reads about a death in Cicero, Indiana, where a man was pushed onto a power saw. The town reminds him of Lisa Braeden (Cindy Sampson), a woman he knew eight years prior and whom he wants to see again before he dies. Later arriving in Cicero, Dean drops Sam off at a motel and drives to her house. He arrives during her son Ben's (Nicholas Elia) eighth birthday party, leading Dean to suspect that he is Ben's father. Lisa denies this, and tells Dean about the saw accident. Meanwhile, Ruby visits Sam at a diner. She surprises him with her knowledge of his psychic abilities, and informs him that something happened to all of his mother's friends. She also tells him that there is a supernatural occurrence in town. Moments later, Dean calls Sam and reveals that four other 'accidents' occurred in Lisa's neighborhood. As Dean helps Ben deal with bullies, Sam investigates one of the accidents—a man fell off a ladder—and notices the child is behaving oddly. A mark on the mother's neck also catches his attention. Later, Sam researches changelings. He suspects that the creatures have replaced the local children, killed the fathers, and are feeding on the mothers. The brothers discover the mother changeling is using a vacant house as her base. Inside, they find a recently-replaced Ben, the other children, and the local realtor in cages. The mother changeling, in the form of the realtor, attacks them. Sam retaliates with a flamethrower, and all the changelings explode in flames upon her death. The real children are returned, and Dean explains everything to Lisa. Dean reluctantly turns down an offer to stay, telling her that it is not his life. Elsewhere, Sam confirms to Ruby that all of his mother's friends were killed. She reveals herself as a demon, but claims that she wants to help him.", 43d, 3, 2);
            _repo.AddEpisodeToEpisodeList(_content);
        }
        [TestMethod]
        public void SeasonCountTest()
        {
            int actual = _repo.SeasonCount;
            int expected = 3;
            Assert.AreEqual(expected, actual);


        }

        [TestMethod]
        public void AverageRunTimeTests()
        {
            double expected = (46d + 44d + 50d + 55d + 49d + 43d) / 6;
            double actual = _repo.AverageRunTime;
            Assert.AreEqual(expected, actual);
        }
    }
}

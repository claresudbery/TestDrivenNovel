using NovelDomain;
using NUnit.Framework;

namespace TestDrivenNovel.StuckOnATrainTests.ProgressionTests
{
    [TestFixture]  
    class Chapter2Tests 
    {
        [Test]
        public void Protagonist_goes_from_happy_to_sad_during_chapter_two()
        {
            // Arrange
            var novel = new StuckOnATrain();

            // Act
            string protagonistEmotionAtEndOfChapterTwo = novel.GetProtagonistEmotionAtEndOfChapter(2);
            string protagonistEmotionAtStartOfChapterTwo = novel.GetProtagonistEmotionAtEndOfChapter(1);

            // Assert
            Assert.AreEqual("sad", protagonistEmotionAtEndOfChapterTwo);
            Assert.AreEqual("happy", protagonistEmotionAtStartOfChapterTwo);
        }

        [Test]
        public void InChapter2TheTurningPointIsThatAloysiusFallsFoulOfAVillian()
        {
            // Arrange
            var novel = new StuckOnATrain();

            // Act
            Chapter chapter2 = novel.GetChapter(2);

            // Assert
            Assert.AreEqual("Aloysius falls foul of a wicked villian!", chapter2.GetEvent(1).TurningPoint);
        }
    }
}

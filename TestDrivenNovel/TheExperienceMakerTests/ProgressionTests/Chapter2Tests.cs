using NovelDomain;
using NovelDomain.ActualNovels.TheExperienceMaker;
using NUnit.Framework;

namespace TestDrivenNovel.TheExperienceMakerTests.ProgressionTests
{
    [TestFixture]  
    class Chapter2Tests 
    {
        [Test]
        public void Protagonist_goes_from_relieved_to_scared_during_chapter_two()
        {
            // Arrange
            var novel = new TheExperienceMaker();

            // Act
            string protagonistEmotionAtStartOfChapterTwo = novel.GetProtagonistEmotionAtStartOfChapter(2);
            string protagonistEmotionAtEndOfChapterTwo = novel.GetProtagonistEmotionAtEndOfChapter(2);

            // Assert
            Assert.AreEqual("relieved", protagonistEmotionAtStartOfChapterTwo);
            Assert.AreEqual("scared", protagonistEmotionAtEndOfChapterTwo);
        }

        [Test]
        public void InChapter2TheTurningPointIs()
        {
            // Arrange
            var novel = new TheExperienceMaker();

            // Act
            IChapter chapter2 = novel.GetChapter(2);

            // Assert
            Assert.AreEqual("", chapter2.GetEvent(1).TurningPoint);
        }
    }
}

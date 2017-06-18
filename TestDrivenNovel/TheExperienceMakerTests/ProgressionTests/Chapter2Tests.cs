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
            Assert.AreEqual("terrified", protagonistEmotionAtEndOfChapterTwo);
        }

        [Test]
        public void InChapter2TheMainEventIsThatProtagonistFeelsARollercoasterExperienceFromMurdererPOV()
        {
            // Arrange
            var novel = new TheExperienceMaker();

            // Act
            IChapter chapter2 = novel.GetChapter(2);

            // Assert
            Assert.AreEqual("The protagonist is lured into feeling a rollercoaster experience that turns out to belong to the murderer.", chapter2.GetEvent(1).Summary);
        }

        [Test]
        public void InChapter2TheTurningPointIsWhenSerenRealisesThisExperienceBelongsToTheMurderer()
        {
            // Arrange
            var novel = new TheExperienceMaker();

            // Act
            IChapter chapter2 = novel.GetChapter(2);

            // Assert
            Assert.AreEqual("It is very exciting and exhilarating, but at the end he looks into a mirror and contemplates his next kill.", chapter2.GetEvent(1).TurningPoint);
        }
    }
}

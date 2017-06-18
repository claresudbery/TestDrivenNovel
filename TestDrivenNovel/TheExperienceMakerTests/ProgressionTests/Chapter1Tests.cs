using NovelDomain;
using NovelDomain.ActualNovels.TheExperienceMaker;
using NUnit.Framework;

namespace TestDrivenNovel.TheExperienceMakerTests.ProgressionTests
{
    [TestFixture]  
    class Chapter1Tests 
    {
        [Test]
        public void Protagonist_goes_from_angry_to_relieved_during_chapter_one()
        {
            // Arrange
            var novel = new TheExperienceMaker();

            // Act
            string protagonistEmotionAtStartOfChapterOne = novel.GetProtagonistEmotionAtStartOfChapter(1);
            string protagonistEmotionAtEndOfChapterOne = novel.GetProtagonistEmotionAtEndOfChapter(1);

            // Assert
            Assert.AreEqual("Angry", protagonistEmotionAtStartOfChapterOne);
            Assert.AreEqual("Relieved", protagonistEmotionAtEndOfChapterOne);
        }

        [Test]
        public void The_initial_crisis_is_that_protagonist_has_just_savagely_murdered_somebody()
        {
            // Arrange
            var novel = new TheExperienceMaker();

            // Act
            Chapter chapter1 = novel.GetChapter(1);

            // Assert
            Assert.AreEqual("Seren has just murdered somebody savagely!", chapter1.GetEvent(1).Summary);
        }

        [Test]
        public void InChapter1TheTurningPointIsThatSerenExitsTheExperienceAndRealisesSheIsNotAMurderer()
        {
            // Arrange
            var novel = new TheExperienceMaker();

            // Act
            Chapter chapter1 = novel.GetChapter(1);

            // Assert
            Assert.AreEqual("Seren exits from the experience and realises that she is not a murderer.", chapter1.GetEvent(1).TurningPoint);
        }
    }
}

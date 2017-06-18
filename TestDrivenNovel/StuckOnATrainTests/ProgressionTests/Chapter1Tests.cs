using NovelDomain;
using NovelDomain.ActualNovels.StuckOnATrain;
using NUnit.Framework;

namespace TestDrivenNovel.StuckOnATrainTests.ProgressionTests
{
    [TestFixture]  
    class Chapter1Tests 
    {
        [Test]
        public void Protagonist_goes_from_sad_to_happy_during_chapter_one()
        {
            // Arrange
            var novel = new StuckOnATrain();

            // Act
            string protagonistEmotionAtEndOfChapterOne = novel.GetProtagonistEmotionAtEndOfChapter(1);
            string protagonistEmotionAtStartOfChapterOne = novel.GetProtagonistEmotionAtEndOfChapter(0);

            // Assert
            Assert.AreEqual("happy", protagonistEmotionAtEndOfChapterOne);
            Assert.AreEqual("sad", protagonistEmotionAtStartOfChapterOne);
        }

        [Test]
        public void Protagonist_is_not_on_train_at_start_of_book()
        {
            // Arrange
            var novel = new StuckOnATrain();

            // Act
            var chapter = novel.GetChapter(1);
            var firstEvent = chapter.GetEvent(1);

            // Assert
            Assert.AreNotEqual("on the train", firstEvent.StartLocation);
        }

        [Test]
        public void Protagonist_is_on_train_by_the_end_of_chapter_one()
        {
            // Arrange
            var novel = new StuckOnATrain();

            // Act
            var chapter = novel.GetChapter(1);
            var lastEvent = chapter.GetEvent(chapter.NumEvents);

            // Assert
            Assert.AreEqual("on the train", lastEvent.FinalLocation);
        }

        [Test]
        public void The_initial_crisis_is_that_protagonist_is_being_chased_by_a_demon()
        {
            // Arrange
            var novel = new StuckOnATrain();

            // Act
            Chapter chapter1 = novel.GetChapter(1);

            // Assert
            Assert.AreEqual("Aloysius is on the run from a terrible demon!", chapter1.GetEvent(1).Description);
        }

        [Test]
        public void InChapter1TheTurningPointIsThatAloysiusFindsATrainToEscapeOnto()
        {
            // Arrange
            var novel = new StuckOnATrain();

            // Act
            Chapter chapter1 = novel.GetChapter(1);

            // Assert
            Assert.AreEqual("Aloysius finds a train to escape onto.", chapter1.GetEvent(1).TurningPoint);
        }
    }
}

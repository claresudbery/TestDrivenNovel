using System.Collections.Generic;
using NovelDomain;
using NovelDomain.ActualNovels.StuckOnATrain;
using NUnit.Framework;

namespace TestDrivenNovel.StuckOnATrainTests
{
    [TestFixture]  
    class GenericNovelTests 
    {
        private INovel CreateNovel()
        {
            return new StuckOnATrain();
        }

        [Test]
        public void Protagonist_changes_emotion_during_all_chapters()
        {
            // Arrange
            var novel = CreateNovel();

            for (int chapter = 1; chapter <= novel.NumChapters(); chapter++)
            {
                string protagonistEmotionAtEndOfPreviousChapter = novel.GetProtagonistEmotionAtEndOfChapter(chapter - 1);

                // Act
                string protagonistEmotionAtEndOfChapterUnderTest = novel.GetProtagonistEmotionAtEndOfChapter(chapter);

                // Assert
                Assert.AreNotEqual(protagonistEmotionAtEndOfPreviousChapter, protagonistEmotionAtEndOfChapterUnderTest);
            }
        }

        [Test]
        public void Protagonist_emotion_at_end_of_each_chapter_is_same_as_emotion_at_start_of_next_chapter()
        {
            // Arrange
            var novel = CreateNovel();

            for (int chapter = 1; chapter <= novel.NumChapters(); chapter++)
            {
                string protagonistEmotionAtEndOfPreviousChapter = novel.GetProtagonistEmotionAtEndOfChapter(chapter - 1);

                // Act
                string protagonistEmotionAtStartOfChapterUnderTest = novel.GetProtagonistEmotionAtStartOfChapter(chapter);

                // Assert
                Assert.AreEqual(protagonistEmotionAtEndOfPreviousChapter, protagonistEmotionAtStartOfChapterUnderTest);
            }
        }

        [Test]
        public void Novel_starts_with_a_crisis()
        {
            // Arrange
            var novel = CreateNovel();

            // Act
            Chapter chapter1 = novel.GetChapter(1);

            // Assert
            Assert.AreEqual(true, chapter1.GetEvent(1).IsCrisis);
        }

        [Test]
        public void AllChaptersHaveTurningPoints()
        {
            // Arrange
            var novel = CreateNovel();

            for (int chapter = 1; chapter <= novel.NumChapters(); chapter++)
            {
                var turningPoint = novel.GetChapter(chapter).GetTurningPoint();

                // Assert
                Assert.IsNotNull(turningPoint);
            }
        }

        [Test]
        public void AllChaptersHaveOnlyOneTurningPoint()
        {
            // Arrange
            var novel = CreateNovel();

            for (int chapter = 1; chapter <= novel.NumChapters(); chapter++)
            {
                List<string> turningPoints = novel.GetChapter(chapter).GetAllTurningPoints();

                // Assert
                Assert.AreEqual(1, turningPoints.Count);
            }
        }
    }
}

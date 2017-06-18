using System.Collections.Generic;
using NovelDomain;
using NovelDomain.ActualNovels.TheExperienceMaker;
using NUnit.Framework;

namespace TestDrivenNovel
{
    public static class GenericNovelTests 
    {
        public static void Protagonist_changes_emotion_during_all_chapters(INovel novel)
        {
            for (int chapter = 1; chapter <= novel.NumChapters(); chapter++)
            {
                // Arrange
                string protagonistEmotionAtEndOfPreviousChapter = novel.GetProtagonistEmotionAtEndOfChapter(chapter - 1);

                // Act
                string protagonistEmotionAtEndOfChapterUnderTest = novel.GetProtagonistEmotionAtEndOfChapter(chapter);

                // Assert
                Assert.AreNotEqual(protagonistEmotionAtEndOfPreviousChapter, protagonistEmotionAtEndOfChapterUnderTest);
            }
        }

        public static void Protagonist_emotion_at_end_of_each_chapter_is_same_as_emotion_at_start_of_next_chapter(INovel novel)
        {
            for (int chapter = 1; chapter <= novel.NumChapters(); chapter++)
            {
                // Arrange
                string protagonistEmotionAtEndOfPreviousChapter = novel.GetProtagonistEmotionAtEndOfChapter(chapter - 1);

                // Act
                string protagonistEmotionAtStartOfChapterUnderTest = novel.GetProtagonistEmotionAtStartOfChapter(chapter);

                // Assert
                Assert.AreEqual(protagonistEmotionAtEndOfPreviousChapter, protagonistEmotionAtStartOfChapterUnderTest);
            }
        }

        public static void Novel_starts_with_a_crisis(INovel novel)
        {
            // Act
            IChapter chapter1 = novel.GetChapter(1);

            // Assert
            Assert.AreEqual(true, chapter1.GetEvent(1).IsCrisis);
        }

        public static void AllChaptersHaveTurningPoints(INovel novel)
        {
            for (int chapter = 1; chapter <= novel.NumChapters(); chapter++)
            {
                // Act
                var turningPoint = novel.GetChapter(chapter).GetTurningPoint();

                // Assert
                Assert.IsNotNull(turningPoint);
            }
        }

        public static void AllChaptersHaveOnlyOneTurningPoint(INovel novel)
        {
            for (int chapter = 1; chapter <= novel.NumChapters(); chapter++)
            {
                // Act
                List<string> turningPoints = novel.GetChapter(chapter).GetAllTurningPoints();

                // Assert
                Assert.AreEqual(1, turningPoints.Count);
            }
        }
    }
}

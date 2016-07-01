using NovelDomain;
using NUnit.Framework;

namespace TestDrivenNovel
{
    [TestFixture]  
    class NovelTests 
    {
        [Test]
        public void Protagonist_changes_state_during_chapter_one()
        {
            // Arrange
            var novel = new StuckOnATrain();
            bool protagonistIsHappyAtStartOfChapterOne = novel.GetProtagonistAtEndOfChapter(0).State;

            // Act
            bool protagonistIsHappyAtEndOfChapterOne = novel.GetProtagonistAtEndOfChapter(1).State;

            // Assert
            Assert.AreNotEqual(protagonistIsHappyAtStartOfChapterOne, protagonistIsHappyAtEndOfChapterOne);
        }

        [Test]
        public void Protagonist_changes_state_during_chapter_two()
        {
            // Arrange
            var novel = new StuckOnATrain();
            bool protagonistIsHappyAtStartOfChapterOne = novel.GetProtagonistAtEndOfChapter(1).State;

            // Act
            bool protagonistIsHappyAtEndOfChapterOne = novel.GetProtagonistAtEndOfChapter(2).State;

            // Assert
            Assert.AreNotEqual(protagonistIsHappyAtStartOfChapterOne, protagonistIsHappyAtEndOfChapterOne);
        }

        [Test]
        public void Protagonist_changes_state_during_all_chapters()
        {
            // Arrange
            var novel = new StuckOnATrain();

            for (int chapter = 1; chapter <= novel.NumChapters(); chapter++)
            {
                bool protagonistIsHappyAtStartOfPreviousChapter = novel.GetProtagonistAtEndOfChapter(chapter - 1).State;

                // Act
                bool protagonistIsHappyAtEndOfChapterUnderTest = novel.GetProtagonistAtEndOfChapter(chapter).State;

                // Assert
                Assert.AreNotEqual(protagonistIsHappyAtStartOfPreviousChapter, protagonistIsHappyAtEndOfChapterUnderTest);
            }
        }
    }
}

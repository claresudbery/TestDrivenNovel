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

        [Test]
        public void Novel_is_called_StuckOnATrain()
        {
            // Arrange & Act
            var novel = new StuckOnATrain();

            // Assert
            Assert.AreEqual("Stuck on a Train", novel.Name);
        } 

        [Test]
        public void Protagonist_is_called_Aloysius()
        {
            // Arrange
            var novel = new StuckOnATrain();

            // Act
            var protagonist = novel.GetProtagonist();

            // Assert
            Assert.AreEqual("Aloysius", protagonist.Name);
        }

        [Test]
        public void Protagonist_is_not_on_train_at_start_of_book()
        {
            // Arrange
            var novel = new StuckOnATrain();

            // Act
            var protagonist = novel.GetProtagonistAtEndOfChapter(0);

            // Assert
            Assert.AreNotEqual("on the train", protagonist.Location);
        }

        [Test]
        public void Protagonist_is_on_train_by_the_end_of_chapter_one()
        {
            // Arrange
            var novel = new StuckOnATrain();

            // Act
            var protagonist = novel.GetProtagonistAtEndOfChapter(1);

            // Assert
            Assert.AreEqual("on the train", protagonist.Location);
        }

        [Test]
        public void Novel_starts_with_a_crisis()
        {
            // Arrange
            var novel = new StuckOnATrain();

            // Act
            Chapter chapter1 = novel.GetChapter(1);

            // Assert
            Assert.AreEqual(true, chapter1.GetEvent(1).IsCrisis);
        }

        [Test]
        public void The_initial_crisis_is_that_protagonist_cannot_leave_the_train()
        {
            // Arrange
            var novel = new StuckOnATrain();

            // Act
            Chapter chapter1 = novel.GetChapter(1);

            // Assert
            Assert.AreEqual("Aloysius cannot get off the train! The doors will not open.", chapter1.GetEvent(1).Description);
        }

        [Test]
        public void Novel_has_one_chapter()
        {
            // Arrange & Act
            var novel = new StuckOnATrain();

            // Assert
            Assert.AreEqual(1, novel.NumChapters());
        }

        [Test]
        public void Chapter1_has_one_event()
        {
            // Arrange & Act
            var novel = new StuckOnATrain();

            // Assert
            Assert.AreEqual(1, novel.GetChapter(1).NumEvents);
        }

        [Test]
        public void The_location_of_an_event_must_match_its_character_location()
        {
            // Arrange
            var novel = new StuckOnATrain();

            // Act & Assert
            for (int chapterNum = 1; chapterNum <= novel.NumChapters(); chapterNum++)
            {
                var chapter = novel.GetChapter(chapterNum);
                for (int eventNum = 1; eventNum <= chapter.NumEvents; eventNum++)
                {
                    var novelEvent = chapter.GetEvent(eventNum);
                    Assert.AreEqual(novelEvent.Location, novelEvent.Character.Location);
                }
            }
        }
    }
}

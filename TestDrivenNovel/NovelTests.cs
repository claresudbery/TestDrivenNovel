﻿using NovelDomain;
using NUnit.Framework;

namespace TestDrivenNovel
{
    [TestFixture]  
    class NovelTests 
    {
        [Test]
        public void Protagonist_goes_from_sad_to_happy_during_chapter_one()
        {
            // Arrange
            var novel = new StuckOnATrain();

            // Act
            string protagonistIsHappyAtEndOfChapterOne = novel.GetHappinessAtEndOfChapter(1);
            string protagonistIsHappyAtStartOfChapterOne = novel.GetHappinessAtEndOfChapter(0);

            // Assert
            Assert.AreEqual("happy", protagonistIsHappyAtEndOfChapterOne);
            Assert.AreEqual("sad", protagonistIsHappyAtStartOfChapterOne);
        }

        [Test]
        public void Protagonist_goes_from_happy_to_sad_during_chapter_two()
        {
            // Arrange
            var novel = new StuckOnATrain();

            // Act
            string protagonistIsHappyAtEndOfChapterTwo = novel.GetHappinessAtEndOfChapter(2);
            string protagonistIsHappyAtStartOfChapterTwo = novel.GetHappinessAtEndOfChapter(1);

            // Assert
            Assert.AreEqual("sad", protagonistIsHappyAtEndOfChapterTwo);
            Assert.AreEqual("happy", protagonistIsHappyAtStartOfChapterTwo);
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
            Assert.AreEqual("Aloysius is on the run from a terrible demon!", chapter1.GetEvent(1).Description);
        }

        [Test]
        public void Novel_has_two_chapters()
        {
            // Arrange & Act
            var novel = new StuckOnATrain();

            // Assert
            Assert.AreEqual(2, novel.NumChapters());
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
        public void InChapter2AloysiusWillFallFoulOfAVillian()
        {
            // Arrange
            var novel = new StuckOnATrain();

            // Act
            Chapter chapter2 = novel.GetChapter(2);

            // Assert
            Assert.AreEqual("Aloysius falls foul of a wicked villian!", chapter2.GetTurningPoint());
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

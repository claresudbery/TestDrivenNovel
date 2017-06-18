using System.Collections.Generic;
using NovelDomain;
using NovelDomain.ActualNovels.TheExperienceMaker;
using NUnit.Framework;

namespace TestDrivenNovel.TheExperienceMakerTests
{
    [TestFixture]  
    class GenericNovelTests 
    {
        private INovel CreateNovel()
        {
            return new TheExperienceMaker();
        }

        [Test]
        public void Protagonist_changes_emotion_during_all_chapters()
        {
            TestDrivenNovel.GenericNovelTests.Protagonist_changes_emotion_during_all_chapters(CreateNovel());
        }

        [Test]
        public void Protagonist_emotion_at_end_of_each_chapter_is_same_as_emotion_at_start_of_next_chapter()
        {
            TestDrivenNovel.GenericNovelTests.Protagonist_emotion_at_end_of_each_chapter_is_same_as_emotion_at_start_of_next_chapter(CreateNovel());
        }

        [Test]
        public void Novel_starts_with_a_crisis()
        {
            TestDrivenNovel.GenericNovelTests.Novel_starts_with_a_crisis(CreateNovel());
        }

        [Test]
        public void AllChaptersHaveTurningPoints()
        {
            TestDrivenNovel.GenericNovelTests.AllChaptersHaveTurningPoints(CreateNovel());
        }

        [Test]
        public void AllChaptersHaveOnlyOneTurningPoint()
        {
            TestDrivenNovel.GenericNovelTests.AllChaptersHaveOnlyOneTurningPoint(CreateNovel());
        }
    }
}

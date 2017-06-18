using System.Collections.Generic;

namespace NovelDomain.ActualNovels.StuckOnATrain
{
    public sealed class StuckOnATrain : INovel
    {
        private Character _protagonist;
        private List<Chapter> _chapters;

        public StuckOnATrain()
        {
            Name = NovelNames.StuckOnATrain;
            InitialiseProtagonist();
            InitialiseChapters();
        }

        public string Name { get; set; }

        public int NumChapters()
        {
            return _chapters.Count;
        }

        public string GetProtagonistEmotionAtStartOfChapter(int chapterNum)
        {
            return GetChapter(chapterNum).StartEmotion;
        }

        public string GetProtagonistEmotionAtEndOfChapter(int chapterNum)
        {
            return (chapterNum >= 1)
                ? GetChapter(chapterNum).FinalEmotion
                : GetChapter(chapterNum + 1).StartEmotion;
        }

        public Character GetProtagonist()
        {
            return _protagonist;
        }

        public IChapter GetChapter(int chapterNumber)
        {
            return _chapters[chapterNumber - 1];
        }

        private void InitialiseProtagonist()
        {
            _protagonist = new Character();
            _protagonist.Name = "Aloysius";
        }

        private void InitialiseChapters()
        {
            _chapters = new List<Chapter>
            {
                new Chapter
                {
                    StartEmotion = "sad",
                    FinalEmotion = "happy",
                    NovelEvents = new List<NovelEvent>
                    {
                        new NovelEvent
                        {
                            IsCrisis = true,
                            Summary = "Aloysius is on the run from a terrible demon!",
                            StartLocation = "not on the train",
                            FinalLocation = "on the train",
                            TurningPoint = "Aloysius finds a train to escape onto.",
                            Character = _protagonist
                        }
                    }
                },
                new Chapter
                {
                    StartEmotion = "happy",
                    FinalEmotion = "sad",
                    NovelEvents = new List<NovelEvent>
                    {
                        new NovelEvent
                        {
                            Summary = "Aloysius falls foul of a wicked villian!",
                            StartLocation = "on the train",
                            FinalLocation = "on the train",
                            TurningPoint = "Aloysius falls foul of a wicked villian!",
                            Character = _protagonist
                        }
                    }
                }
            };
        }
    }
}
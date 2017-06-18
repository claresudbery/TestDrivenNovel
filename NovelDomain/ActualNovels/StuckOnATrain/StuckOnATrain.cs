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

        private void InitialiseChapters()
        {
            _chapters = new List<Chapter>
            {
                new Chapter
                {
                    NovelEvents = new List<NovelEvent>
                    {
                        new NovelEvent
                        {
                            IsCrisis = true,
                            Description = "Aloysius is on the run from a terrible demon!",
                            StartLocation = "not on the train",
                            FinalLocation = "on the train",
                            TurningPoint = "Aloysius finds a train to escape onto.",
                            Character = _protagonist
                        }
                    }
                },
                new Chapter
                {
                    NovelEvents = new List<NovelEvent>
                    {
                        new NovelEvent
                        {
                            Description = "Aloysius falls foul of a wicked villian!",
                            StartLocation = "on the train",
                            FinalLocation = "on the train",
                            TurningPoint = "Aloysius falls foul of a wicked villian!",
                            Character = _protagonist
                        }
                    }
                }
            };
        }

        public string Name { get; set; }

        public Character GetProtagonistAtEndOfChapter(int chapterNumber)
        {
            string[] emotions = new[] {"sad", "happy"};
            _protagonist.Emotion = emotions[chapterNumber % 2];

            return _protagonist;
        }

        private void InitialiseProtagonist()
        {
            _protagonist = new Character();
            _protagonist.Name = "Aloysius";
        }

        public int NumChapters()
        {
            return _chapters.Count;
        }

        public string GetProtagonistEmotionAtEndOfChapter(int chapterNum)
        {
            return GetProtagonistAtEndOfChapter(chapterNum).Emotion;
        }

        public Character GetProtagonist()
        {
            return _protagonist;
        }

        public Chapter GetChapter(int chapterNumber)
        {
            return _chapters[chapterNumber - 1];
        }
    }
}
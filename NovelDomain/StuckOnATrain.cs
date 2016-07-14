using System;
using System.Collections.Generic;
using System.Reflection;

namespace NovelDomain
{
    public sealed class StuckOnATrain : INovel
    {
        private Character _protagonist;
        private List<Chapter> _chapters;

        public StuckOnATrain()
        {
            Name = "Stuck on a Train";
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
                            Character = new Character {Name = "Aloysius"}
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
                            Character = new Character {Name = "Aloysius"}
                        }
                    }
                }
            };
        }

        public string Name { get; set; }

        public Character GetProtagonistAtEndOfChapter(int chapterNumber)
        {
            _protagonist.State = Convert.ToBoolean(chapterNumber % 2);

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

        public string GetHappinessAtEndOfChapter(int chapterNum)
        {
            return GetProtagonistAtEndOfChapter(chapterNum).State ? "happy" : "sad";
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
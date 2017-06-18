using System.Collections.Generic;

namespace NovelDomain.ActualNovels.TheExperienceMaker
{
    public sealed class TheExperienceMaker : INovel
    {
        private Character _protagonist;
        private List<Chapter> _chapters;

        public TheExperienceMaker()
        {
            Name = NovelNames.TheExperienceMaker;
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
            return (chapterNum <= _chapters.Count)
                ? GetChapter(chapterNum).StartEmotion
                : GetChapter(chapterNum - 1).FinalEmotion;
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

        public Chapter GetChapter(int chapterNumber)
        {
            return _chapters[chapterNumber - 1];
        }

        private void InitialiseProtagonist()
        {
            _protagonist = new Character();
            _protagonist.Name = "Seren";
        }

        private void InitialiseChapters()
        {
            _chapters = new List<Chapter>
            {
                new Chapter
                {
                    StartEmotion = "Angry",
                    FinalEmotion = "Relieved",
                    NovelEvents = new List<NovelEvent>
                    {
                        new NovelEvent
                        {
                            IsCrisis = true,
                            Summary = "Seren has just murdered somebody savagely!",
                            TurningPoint = "Seren exits from the experience and realises that she is not a murderer.",
                            Character = _protagonist
                        }
                    }
                }
            };
        }
    }
}
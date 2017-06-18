using System.Collections.Generic;

namespace NovelDomain.ActualNovels.UnderstandMe
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

        private void InitialiseChapters()
        {
            _chapters = new List<Chapter>();
        }

        public string Name { get; set; }

        public Character GetProtagonistAtEndOfChapter(int chapterNumber)
        {
            return _protagonist;
        }

        private void InitialiseProtagonist()
        {
            _protagonist = new Character();
            _protagonist.Name = "Seren";
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
            return new Chapter();
        }
    }
}
using System.Collections.Generic;

namespace NovelDomain.ActualNovels
{
    public sealed class NullNovel : INovel
    {
        public NullNovel()
        {
            Name = "Empty Novel";
        }

        public string Name { get; set; }

        public Character GetProtagonistAtEndOfChapter(int chapterNumber)
        {
            return new Character();
        }

        public int NumChapters()
        {
            return 0;
        }

        public string GetProtagonistEmotionAtEndOfChapter(int chapterNum)
        {
            return GetProtagonistAtEndOfChapter(chapterNum).Emotion;
        }

        public Character GetProtagonist()
        {
            return new Character();
        }

        public Chapter GetChapter(int chapterNumber)
        {
            return new Chapter();
        }
    }
}
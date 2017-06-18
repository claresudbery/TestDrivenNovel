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

        public int NumChapters()
        {
            return 0;
        }

        public string GetProtagonistEmotionAtStartOfChapter(int chapterNum)
        {
            return GetChapter(chapterNum).StartEmotion;
        }

        public string GetProtagonistEmotionAtEndOfChapter(int chapterNum)
        {
            return GetChapter(chapterNum).FinalEmotion;
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
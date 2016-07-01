using System;

namespace NovelDomain
{
    public sealed class StuckOnATrain
    {
        public Character GetProtagonistAtEndOfChapter(int chapterNumber)
        {
            var protagonist = new Character();

            protagonist.State = Convert.ToBoolean(chapterNumber % 2);

            return protagonist;
        }

        public int NumChapters()
        {
            return 10;
        }

        public void ShowText()
        {
            Console.WriteLine("At the start of the book, protagonist is " + GetHappiness(0) + ":");
            Console.WriteLine("");
            for (int chapterNum = 1; chapterNum <= NumChapters(); chapterNum++)
            {
                Console.WriteLine("Chapter " + chapterNum + ":");
                Console.WriteLine("At the end of this chapter, protagonist is " + GetHappiness(chapterNum) + ".");
                Console.WriteLine("");
            }
        }

        private string GetHappiness(int chapterNum)
        {
            return GetProtagonistAtEndOfChapter(chapterNum).State ? "happy" : "sad";
        }
    }
}
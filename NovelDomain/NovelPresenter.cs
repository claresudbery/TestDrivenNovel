using System;

namespace NovelDomain
{
    public sealed class NovelPresenter
    {
        private readonly INovel _novelToPresent;

        public NovelPresenter(INovel novelToPresent)
        {
            _novelToPresent = novelToPresent;
        }

        public void ShowText()
        {
            ShowIntro();
            Console.WriteLine("");
            for (int chapterNum = 1; chapterNum <= _novelToPresent.NumChapters(); chapterNum++)
            {
                Console.WriteLine("Chapter " + chapterNum + ":");
                EndChapter(chapterNum);
                Console.WriteLine("");
            }
        }

        private void EndChapter(int chapterNum)
        {
            string line1 = string.Format("At the end of this chapter, {0} is {1}.",
                _novelToPresent.GetProtagonist().Name,
                _novelToPresent.GetHappiness(chapterNum));

            Console.WriteLine(line1);
        }

        private void ShowIntro()
        {
            string line1 = "Our main character is called " + GetProtagonist().Name + ".";
            string line2 = string.Format("At the start of the book, {0} is {1}.",
                _novelToPresent.GetProtagonist().Name,
                _novelToPresent.GetHappiness(0));

            Console.WriteLine(line1);
            Console.WriteLine(line2);
        }
    }
}
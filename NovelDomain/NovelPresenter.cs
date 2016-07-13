using System;
using System.Collections.Generic;

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
            Console.WriteLine("");
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
            var lines = new List<string>();

            lines.Add(string.Format("At the end of this chapter, {0} is {1}.",
                _novelToPresent.GetProtagonist().Name,
                _novelToPresent.GetProtagonistAtEndOfChapter(chapterNum).Location));

            lines.Add(string.Format("At the end of this chapter, {0} is {1}.",
                _novelToPresent.GetProtagonist().Name,
                _novelToPresent.GetHappiness(chapterNum)));

            WriteLines(lines);
        }

        private void ShowIntro()
        {
            var lines = new List<string>();

            lines.Add("This novel is called " + _novelToPresent.Name + ".");

            lines.Add("The main character is called " + _novelToPresent.GetProtagonist().Name + ".");

            lines.Add(string.Format("At the start of the book, {0} is {1}.",
                _novelToPresent.GetProtagonist().Name,
                _novelToPresent.GetProtagonistAtEndOfChapter(0).Location));

            lines.Add(string.Format("At the start of the book, {0} is {1}.",
                _novelToPresent.GetProtagonist().Name,
                _novelToPresent.GetHappiness(0)));

            WriteLines(lines);
        }

        private void WriteLines(List<string> lines)
        {
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}
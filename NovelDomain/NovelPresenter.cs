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
                ShowChapter(chapterNum);
                EndChapter(chapterNum);
                Console.WriteLine("");
            }
        }

        private void ShowChapter(int chapterNum)
        {
            var chapter = _novelToPresent.GetChapter(chapterNum);

            for (int eventNum = 1; eventNum <= chapter.NumEvents; eventNum++)
            {
                var novelEvent = chapter.GetEvent(eventNum);

                if (novelEvent.IsCrisis)
                {
                    Console.WriteLine("The {0} event is a crisis.", 
                        GetNumberDescriptor(eventNum));
                }

                Console.WriteLine("This event happens to {0}.",
                    novelEvent.Character.Name);

                Console.WriteLine("This event happens when {0} is {1}.",
                    novelEvent.Character.Name,
                    novelEvent.Location);

                Console.WriteLine("The {0} event is that {1}", 
                    GetNumberDescriptor(eventNum), 
                    novelEvent.Description);
            }
        }

        private string GetNumberDescriptor(int number)
        {
            var descriptorDictionary = new Dictionary<int, string>
            {
                {1, "first"},
                {2, "second"},
                {3, "third"},
                {4, "fourth"},
                {5, "fifth"},
                {6, "sixth"},
                {7, "seventh"},
                {8, "eighth"},
                {9, "ninth"},
                {10, "tenth"},
            };

            return descriptorDictionary.ContainsKey(number) ? descriptorDictionary[number] : "nth";
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

            lines.Add("This novel has " + _novelToPresent.NumChapters() + " chapters.");

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
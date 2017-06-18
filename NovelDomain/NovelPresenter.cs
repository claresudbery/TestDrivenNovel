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
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("-------------------------------------");
            for (int chapterNum = 1; chapterNum <= _novelToPresent.NumChapters(); chapterNum++)
            {
                Console.WriteLine("");
                Console.WriteLine("Chapter " + chapterNum + ":");
                StartChapter(chapterNum);
                ShowChapter(chapterNum);
                EndChapter(chapterNum);
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("-------------------------------------");
            }
        }

        private void ShowChapter(int chapterNum)
        {
            var chapter = _novelToPresent.GetChapter(chapterNum);

            for (int eventNum = 1; eventNum <= chapter.NumEvents; eventNum++)
            {
                ShowEvent(chapter.GetEvent(eventNum), eventNum);
            }

            Console.WriteLine("-------------------------------------");
        }

        private void ShowEvent(NovelEvent novelEvent, int eventNum)
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("{0} event: ", GetNumberDescriptor(eventNum));
            Console.WriteLine("It happens to {0}.", novelEvent.Character.Name);
            if (novelEvent.IsCrisis)
            {
                Console.WriteLine("It is a crisis.");
            }
            WriteIf(string.Format("It starts {0}.", novelEvent.StartLocation)); 
            WriteIf(string.Format("It ends {0}.", novelEvent.FinalLocation));
            Console.WriteLine(novelEvent.Summary);
            ShowEventDescription(novelEvent.Description);
            if (novelEvent.TurningPoint != null)
            {
                if (novelEvent.TurningPoint == novelEvent.Summary)
                {
                    Console.WriteLine("It is a turning point.");
                }
                else
                {
                    Console.WriteLine("This event has a turning point, when {0}", novelEvent.TurningPoint);
                }
            }
        }

        private void WriteIf(string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                Console.WriteLine(text);
            }
        }

        private void ShowEventDescription(List<string> eventDescription)
        {
            if (eventDescription != null)
            {
                Console.WriteLine("Details:");
                foreach (var line in eventDescription)
                {
                    Console.WriteLine(line);
                }
            }
        }

        private string GetNumberDescriptor(int number)
        {
            var descriptorDictionary = new Dictionary<int, string>
            {
                {1, "First"},
                {2, "Second"},
                {3, "Third"},
                {4, "Fourth"},
                {5, "Fifth"},
                {6, "Sixth"},
                {7, "Seventh"},
                {8, "Eighth"},
                {9, "Ninth"},
                {10, "Tenth"},
            };

            return descriptorDictionary.ContainsKey(number) ? descriptorDictionary[number] : "nth";
        }

        private void StartChapter(int chapterNum)
        {
            var lines = new List<string>();

            lines.Add(string.Format("At the start of this chapter, {0} is {1}.",
                _novelToPresent.GetProtagonist().Name,
                _novelToPresent.GetProtagonistEmotionAtEndOfChapter(chapterNum-1)));

            WriteLines(lines);
        }

        private void EndChapter(int chapterNum)
        {
            var lines = new List<string>();

            lines.Add(string.Format("At the end of this chapter, {0} is {1}.",
                _novelToPresent.GetProtagonist().Name,
                _novelToPresent.GetProtagonistEmotionAtEndOfChapter(chapterNum)));

            WriteLines(lines);
        }

        private void ShowIntro()
        {
            var lines = new List<string>();

            lines.Add("This novel is called " + _novelToPresent.Name + ".");

            lines.Add("This novel has " + _novelToPresent.NumChapters() + " chapter(s).");

            lines.Add("The main character is called " + _novelToPresent.GetProtagonist().Name + ".");

            lines.Add(string.Format("At the start of the book, {0} is {1}.",
                _novelToPresent.GetProtagonist().Name,
                _novelToPresent.GetProtagonistEmotionAtEndOfChapter(0)));

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
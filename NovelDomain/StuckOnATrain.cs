﻿using System;
using System.Reflection;

namespace NovelDomain
{
    public sealed class StuckOnATrain : INovel
    {
        private Character _protagonist;

        public StuckOnATrain()
        {
            Name = "Stuck on a Train";
            InitialiseProtagonist();
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
            return 10;
        }

        public string GetHappiness(int chapterNum)
        {
            return GetProtagonistAtEndOfChapter(chapterNum).State ? "happy" : "sad";
        }

        public Character GetProtagonist()
        {
            return _protagonist;
        }
    }
}
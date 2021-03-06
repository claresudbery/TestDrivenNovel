﻿namespace NovelDomain
{
    public interface INovel
    {
        string Name { get; set; }

        int NumChapters();

        Character GetProtagonist();

        string GetProtagonistEmotionAtStartOfChapter(int chapterNum);

        string GetProtagonistEmotionAtEndOfChapter(int chapterNum);

        IChapter GetChapter(int chapterNumber);
    }
}
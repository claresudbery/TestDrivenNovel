namespace NovelDomain
{
    public interface INovel
    {

        string Name { get; set; }

        Character GetProtagonistAtEndOfChapter(int chapterNumber);

        int NumChapters();

        Character GetProtagonist();

        string GetHappiness(int chapterNum);

        Chapter GetChapter(int chapterNumber);
    }
}
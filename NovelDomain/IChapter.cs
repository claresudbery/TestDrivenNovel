using System.Collections.Generic;

namespace NovelDomain
{
    public interface IChapter
    {
        List<NovelEvent> NovelEvents { get; set; }
        string StartEmotion { get; set; }
        string FinalEmotion { get; set; }
        NovelEvent GetEvent(int eventNumber);
        int NumEvents { get; }
        string GetTurningPoint();
        List<string> GetAllTurningPoints();
    }
}
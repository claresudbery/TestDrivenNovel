using System.Collections.Generic;
using System.Linq.Expressions;

namespace NovelDomain
{
    public sealed class Chapter : IChapter
    {
        public List<NovelEvent> NovelEvents { get; set; }
        public string StartEmotion { get; set; }
        public string FinalEmotion { get; set; }

        public NovelEvent GetEvent(int eventNumber)
        {
            return NovelEvents[eventNumber-1];
        }

        public int NumEvents
        {
            get { return NovelEvents.Count; }
        }

        public string GetTurningPoint()
        {
            return ChapterMaster.GetTurningPoint(this);
        }

        public List<string> GetAllTurningPoints()
        {
            return ChapterMaster.GetAllTurningPoints(this);
        }
    }
}
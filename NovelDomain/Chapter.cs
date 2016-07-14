using System.Collections.Generic;
using System.Linq.Expressions;

namespace NovelDomain
{
    public sealed class Chapter
    {
        public List<NovelEvent> NovelEvents { get; set; }

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
            var turningPoint = "";

            for (int eventNum = 1; eventNum <= NumEvents; eventNum++)
            {
                if (GetEvent(eventNum).TurningPoint != null)
                {
                    turningPoint = GetEvent(eventNum).TurningPoint;
                }
            }

            return turningPoint;
        }
    }
}
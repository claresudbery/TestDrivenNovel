using System.Collections.Generic;
using System.Linq.Expressions;

namespace NovelDomain
{
    public sealed class Chapter
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
            string turningPoint = null;

            for (int eventNum = 1; eventNum <= NumEvents; eventNum++)
            {
                if (GetEvent(eventNum).TurningPoint != null)
                {
                    turningPoint = GetEvent(eventNum).TurningPoint;
                }
            }

            return turningPoint;
        }

        public List<string> GetAllTurningPoints()
        {
            List<string> turningPoints = new List<string>();

            for (int eventNum = 1; eventNum <= NumEvents; eventNum++)
            {
                if (GetEvent(eventNum).TurningPoint != null)
                {
                    turningPoints.Add(GetEvent(eventNum).TurningPoint);
                }
            }

            return turningPoints;
        }
    }
}
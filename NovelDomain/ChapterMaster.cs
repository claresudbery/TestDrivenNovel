using System.Collections.Generic;

namespace NovelDomain
{
    public static class ChapterMaster
    {
        public static string GetTurningPoint(IChapter chapter)
        {
            string turningPoint = null;

            for (int eventNum = 1; eventNum <= chapter.NumEvents; eventNum++)
            {
                if (chapter.GetEvent(eventNum).TurningPoint != null)
                {
                    turningPoint = chapter.GetEvent(eventNum).TurningPoint;
                }
            }

            return turningPoint;
        }

        public static List<string> GetAllTurningPoints(IChapter chapter)
        {
            List<string> turningPoints = new List<string>();

            for (int eventNum = 1; eventNum <= chapter.NumEvents; eventNum++)
            {
                if (chapter.GetEvent(eventNum).TurningPoint != null)
                {
                    turningPoints.Add(chapter.GetEvent(eventNum).TurningPoint);
                }
            }

            return turningPoints;
        }
    }
}
using System.Collections.Generic;

namespace NovelDomain.ActualNovels.TheExperienceMaker
{
    public sealed class ExperienceMakerChap2 : IChapter
    {
        private readonly Character _protagonist;

        public ExperienceMakerChap2(Character protagonist)
        {
            _protagonist = protagonist;
        }

        public string StartEmotion
        {
            get { return "relieved"; }
            set { throw new System.NotImplementedException(); }
        }

        public string FinalEmotion
        {
            get { return "scared"; }
            set { throw new System.NotImplementedException(); }
        }

        public List<NovelEvent> NovelEvents
        {
            get
            {
                return new List<NovelEvent>
                {
                    new NovelEvent
                    {
                        IsCrisis = false,
                        Summary = "",
                        Description = new List<string>
                        {
                        },
                        TurningPoint = "",
                        Character = _protagonist,
                        StartLocation = "",
                        FinalLocation = ""
                    }
                };
            }
            set { throw new System.NotImplementedException(); }
        }

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
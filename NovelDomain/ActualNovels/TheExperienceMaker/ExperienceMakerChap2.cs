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
            get { return "terrified"; }
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
                        Summary = "The protagonist is lured into feeling a rollercoaster experience that turns out to belong to the murderer.",
                        Description = new List<string>
                        {
                            "The thing about experiences is that you cannot escape them.",
                            "Because they are totally immersive, you effectively accept a waiver at the start of each one."
                        },
                        TurningPoint = "It is very exciting and exhilarating, but at the end he looks into a mirror and contemplates his next kill.",
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
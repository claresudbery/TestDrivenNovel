using System.Collections.Generic;

namespace NovelDomain.ActualNovels.TheExperienceMaker
{
    public sealed class ExperienceMakerChap1 : IChapter
    {
        private readonly Character _protagonist;

        public ExperienceMakerChap1(Character protagonist)
        {
            _protagonist = protagonist;
        }

        public string StartEmotion
        {
            get { return "angry"; }
            set { throw new System.NotImplementedException(); }
        }

        public string FinalEmotion
        {
            get { return "relieved"; }
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
                        IsCrisis = true,
                        Summary = "Seren has just murdered somebody savagely!",
                        Description = new List<string>
                        {
                            "Seren is having the experience of murdering sombody savagely, in a furious rage.",
                            "But then we discover this is a manufactured experience, and Seren is in court.",
                            "Seren is on jury duty, at the first murder trial to make use of 'experience' recorders.",
                            "Experience recordings allow people to plug themselves directly into the live recorded experiences of others.",
                            "They experience every thought, feeling, taste, sound, sight and smell... first hand.",
                            "In this case it has been made possible because the murderer recorded the experience in the equivalent of a Facebook Live broadcast.",
                            "The experience is so real that Seren really believes she is in the act of murdering somebody.",
                            "When she exits, she and her fellow jurors are all deeply affected. Some throw up."
                        },
                        TurningPoint = "Seren exits from the experience and realises that she is not a murderer.",
                        Character = _protagonist,
                        StartLocation = "in court",
                        FinalLocation = "in court"
                    },
                    new NovelEvent
                    {
                        IsCrisis = false,
                        Summary = "After going through the murder experience, Seren makes eye contact with the murderer.",
                        Description = new List<string>
                        {
                            "It feels as though he is singling her out. As though some kind of connection is being formed."
                        },
                        Character = _protagonist,
                        StartLocation = "in court",
                        FinalLocation = "in court"
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
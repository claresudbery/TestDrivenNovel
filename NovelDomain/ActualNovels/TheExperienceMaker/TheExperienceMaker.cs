using System.Collections.Generic;

namespace NovelDomain.ActualNovels.TheExperienceMaker
{
    public sealed class TheExperienceMaker : INovel
    {
        private Character _protagonist;
        private List<Chapter> _chapters;

        public TheExperienceMaker()
        {
            Name = NovelNames.TheExperienceMaker;
            InitialiseProtagonist();
            InitialiseChapters();
        }

        public string Name { get; set; }

        public int NumChapters()
        {
            return _chapters.Count;
        }

        public string GetProtagonistEmotionAtStartOfChapter(int chapterNum)
        {
            return (chapterNum <= _chapters.Count)
                ? GetChapter(chapterNum).StartEmotion
                : GetChapter(chapterNum - 1).FinalEmotion;
        }

        public string GetProtagonistEmotionAtEndOfChapter(int chapterNum)
        {
            return (chapterNum >= 1)
                ? GetChapter(chapterNum).FinalEmotion
                : GetChapter(chapterNum + 1).StartEmotion;
        }

        public Character GetProtagonist()
        {
            return _protagonist;
        }

        public Chapter GetChapter(int chapterNumber)
        {
            return _chapters[chapterNumber - 1];
        }

        private void InitialiseProtagonist()
        {
            _protagonist = new Character();
            _protagonist.Name = "Seren";
        }

        private void InitialiseChapters()
        {
            _chapters = new List<Chapter>
            {
                new Chapter
                {
                    StartEmotion = "angry",
                    FinalEmotion = "relieved",
                    NovelEvents = new List<NovelEvent>
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
                        }
                    }
                }
            };
        }
    }
}
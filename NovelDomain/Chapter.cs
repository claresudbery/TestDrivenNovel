using System.Linq.Expressions;

namespace NovelDomain
{
    public sealed class Chapter
    {
        public Chapter()
        {
            NumEvents = 1;
        }

        public NovelEvent GetEvent(int eventNumber)
        {
            var novelEvent = new NovelEvent
            {
                IsCrisis = true,
                Description = "Aloysius is on the run from a terrible demon!",
                StartLocation = "not on the train",
                FinalLocation = "on the train",
                Character = new Character {Name = "Aloysius"}
            };
            return novelEvent;
        }

        public int NumEvents { get; set; }
    }
}
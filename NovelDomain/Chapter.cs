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
            var novelEvent = new NovelEvent();
            novelEvent.IsCrisis = true;
            novelEvent.Description = "Aloysius cannot get off the train! The doors will not open.";
            return novelEvent;
        }

        public int NumEvents { get; set; }
    }
}
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
            novelEvent.StartLocation = "not on the train";
            novelEvent.FinalLocation = "on the train";
            novelEvent.Character = new Character();
            novelEvent.Character.Name = "Aloysius";
            return novelEvent;
        }

        public int NumEvents { get; set; }
    }
}
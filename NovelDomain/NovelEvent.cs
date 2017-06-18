using System.Collections.Generic;

namespace NovelDomain
{
    public sealed class NovelEvent
    {
        public bool IsCrisis { get; set; }
        public string Summary { get; set; }
        public List<string> Description { get; set; }
        public string StartLocation { get; set; }
        public string FinalLocation { get; set; }
        public Character Character { get; set; }
        public string TurningPoint { get; set; }
    }
}
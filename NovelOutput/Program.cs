using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NovelDomain;
using NovelDomain.ActualNovels;
using NovelDomain.ActualNovels.StuckOnATrain;
using NovelDomain.ActualNovels.UnderstandMe;

namespace NovelOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            var novelFactory = new NovelFactory();
            novelFactory.ChooseAndDisplayNovel();
        }
    }
}

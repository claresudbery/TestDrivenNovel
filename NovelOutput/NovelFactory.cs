using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NovelDomain;
using NovelDomain.ActualNovels;
using NovelDomain.ActualNovels.StuckOnATrain;
using NovelDomain.ActualNovels.TheExperienceMaker;

namespace NovelOutput
{
    class NovelFactory
    {
        private delegate INovel NovelCreator();

        private static readonly Dictionary<int, string> Options = new Dictionary<int, string>
        {
            {1, NovelNames.StuckOnATrain},
            {2, NovelNames.TheExperienceMaker},
            {3, "Exit"},
        };

        private static readonly Dictionary<string, NovelCreator> Novels = new Dictionary<string, NovelCreator>
        {
            {"1", CreateStuckOnATrain},
            {"2", CreateTheExperienceMaker},
        };

        public void ChooseAndDisplayNovel()
        {
            OutputOptions();
            string input = System.Console.ReadLine();

            while (input != LastOptionKey() && input.ToUpper() != "EXIT")
            {
                Console.WriteLine("");
                Console.WriteLine("");
                if (Novels.ContainsKey(input))
                {
                    OutputNovel(Novels[input]());
                }

                OutputOptions();
                input = System.Console.ReadLine();
            }

            Console.WriteLine("");
            Console.WriteLine("OK, then, if you really must. Goodbye [sob].");
            Thread.Sleep(System.TimeSpan.FromSeconds(2));
        }

        private static INovel CreateStuckOnATrain()
        {
            return new StuckOnATrain();
        }

        private static INovel CreateTheExperienceMaker()
        {
            return new TheExperienceMaker();
        }

        private static string LastOptionKey()
        {
            return Options.Keys.ElementAt(Options.Count - 1).ToString();
        }

        private static void OutputNovel(INovel novel)
        {
            var novelPresenter = new NovelPresenter(novel);
            Console.WriteLine("Welcome to my novel. It goes like this...");
            try
            {
                novelPresenter.ShowText();
                Console.WriteLine("");
                Console.WriteLine("Press enter to return to menu.");
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Oopsidaisy! I done a boo boo.");
                Thread.Sleep(System.TimeSpan.FromSeconds(5));
            }
        }

        private static void OutputOptions()
        {
            System.Console.WriteLine("Enter the number next to the option you want.");

            foreach (var option in Options)
            {
                System.Console.WriteLine(string.Format("{0}. {1}", option.Key, option.Value));
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NovelDomain;

namespace NovelOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            var novel = new NovelPresenter(new StuckOnATrain());
            Console.WriteLine("Welcome to my novel. It goes like this...");
            try
            {
                novel.ShowText();
                Console.WriteLine("Press enter to end.");
                Console.ReadLine();
                Console.WriteLine("OK, then, if you really must. Goodbye [sob].");
                Thread.Sleep(System.TimeSpan.FromSeconds(10));
            }
            catch (Exception)
            {
                Console.WriteLine("Oopsidaisy! I done a boo boo.");
                Thread.Sleep(System.TimeSpan.FromSeconds(10));
            }
        }
    }
}

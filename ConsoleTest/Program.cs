using NHyphenator;
using System;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //a simple test since I cannot run tests due to this http://stackoverflow.com/questions/43494462/why-test-explorer-doesnt-see-my-nunit-tests-for-asp-net-core-mvc
            var hyphenator = new Hyphenator(HyphenatePatternsLanguage.EnglishBritish, hyphenateLastWord: true);
            Console.WriteLine(hyphenator.HyphenateText("Discuss social networking"));
            Console.ReadKey();
        }
    }
}
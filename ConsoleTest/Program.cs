using NHyphenator;
using System;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //a simple test since I cannot run tests due to this http://stackoverflow.com/questions/43494462/why-test-explorer-doesnt-see-my-nunit-tests-for-asp-net-core-mvc
            var hyphenatorEn = new Hyphenator(HyphenatePatternsLanguage.EnglishBritish, hyphenateSymbol: "-", hyphenateLastWord: true);
            var hyphenatorDe = new Hyphenator(HyphenatePatternsLanguage.German, hyphenateSymbol: "-", hyphenateLastWord: true);
            var hyphenatorEs = new Hyphenator(HyphenatePatternsLanguage.Spanish, hyphenateSymbol: "-", hyphenateLastWord: true);

            var en = hyphenatorEn.HyphenateText("Discuss social networking");
            var de = hyphenatorDe.HyphenateText("Jemanden begrüßen und sich vorstellen");
            var es = hyphenatorEs.HyphenateText("Llamar a una persona por teléfono");

            Console.WriteLine(en);
            Console.WriteLine(de);
            Console.WriteLine(es);
            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class Program
    {
        static void Main(string[] args)
        {
            var reader = new FileReader();
            // reader.InitializeReviews(@"..\..\..\dataset\part1\neg");
            var topWordsNeg = new List<string>()
                /* TFIDF.Transform(ref reader.AllReviews.Content, ref reader.AllReviews, true)*/;

            reader.Clear();
            reader.InitializeReviews(@"..\..\..\dataset\part1\pos");
            var topWordsPos = TFIDF.Transform(ref reader.AllReviews.Content, ref reader.AllReviews, false);

            var writer = new StreamWriter(@"..\..\..\dataset\result.txt");

            foreach (var word in topWordsPos.Concat(topWordsNeg))
            {
                writer.WriteLine("\"" + word + "\"" + ",");
                writer.Flush();
            }
        }
    }
}

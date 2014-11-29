using System;
using System.Collections.Generic;
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
            reader.InitializeReviews(@"..\..\..\dataset\part1\neg");

            TFIDF.Transform(ref reader.AllReviews.Content, reader.AllReviews);
        }
    }
}

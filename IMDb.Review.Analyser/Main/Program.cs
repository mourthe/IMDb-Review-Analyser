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
            reader.InitializeReviews(@"..\..\..\..\dataset\neg");

            TFIDFExample.TFIDF.Transform(ref reader.Reviews.Content);
        }
    }
}

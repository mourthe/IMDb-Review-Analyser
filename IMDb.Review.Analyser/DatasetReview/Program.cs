using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatasetReview
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new DatasetReader();
            reader.Read(@"..\..\..\dataset.arff");

            var result = reader.GetBadWords();

            foreach (var r in result)
            {
                Console.WriteLine(r);
            }
        }
    }
}

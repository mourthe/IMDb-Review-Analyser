using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class Reviews
    {
        public string[] Content;
        public double[][] Score;

        public Reviews()
        {
            Content = new string[12500];
            Score = new double[12500][];
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DatasetReview
{
    public class DatasetReader
    {
        public List<string> BadWordsNeg;
        public List<string> BadWordsPos;
        private string[][] _appears;
        private List<Word> _words;

        private const int Size = 25000;
        private const int EndOfNeg = 12500;

        public void Read(string path)
        {
            var reader = new StreamReader(path);
            _words = new List<Word>();
            _appears = new string[Size][];

            // discard the first line
            reader.ReadLine();

            var i = 0;
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                
                if (line[0] == '@' && !line.Contains("{") && !line.Contains("isPositive") && !line.Contains("data"))
                {
                    var sline = line.Split(' ');
                    _words.Add(new Word(sline[1]));
                }

                if (line[0] == '1' || line[0] == '2' || line[0] == '3' || line[0] == '4' || line[0] == '5' ||
                    line[0] == '6' || line[0] == '7' || line[0] == '8' || line[0] == '9' || line[0] == '0')
                {
                    _appears[i++] = (line.Split(','));
                } 
            }
        }

        public List<string> GetBadWords()
        {
            FillWords();

            return
                (from word in _words
                    where word.NumberNeg > 1.5*word.NumberPos || 1.5*word.NumberNeg < word.NumberPos
                    select word.Value).ToList();
        }

        private void FillWords()
        {
            for (var i = 0; i < Size; i++)
            {
                for (var j = 0; j < _appears[i].Length - 2; j++)
                {
                    if (i < EndOfNeg)
                    {
                        _words[j].NumberNeg += Convert.ToInt32(_appears[i][j]);
                    }
                    else
                    {
                        _words[j].NumberPos += Convert.ToInt32(_appears[i][j]);
                    }
                }
            }
        }
    }

    internal class Word
    {
        public string Value;
        public int NumberNeg;
        public int NumberPos;

        public Word(string s)
        {
            Value = s;
            NumberPos = NumberNeg = 0;
        }
    }
}
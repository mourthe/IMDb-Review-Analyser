using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;
using EnglishStemmer;

namespace Main
{
    public class WordAndScore
    {
        public string Word;
        public double Score;

        public WordAndScore(string word, double score)
        {
            Word = word;
            Score = score;
        }
    }

    public static class TFIDF
    {
        private static Dictionary<string, double> _vocabularyIdf = new Dictionary<string, double>();

        public static IList<string> Transform(ref string[] documents, ref Reviews reviews, bool isNeg, int vocabularyThreshold = 3)
        {
            List<List<string>> stemmedDocs;

            // Get the vocabulary and stem the documents at the same time.
            var vocabulary = GetVocabulary(documents, out stemmedDocs, vocabularyThreshold, isNeg);

            Console.Clear();
            Console.WriteLine("Fills the _vocabulary");
            if (_vocabularyIdf.Count == 0)
            {
                // Calculate the IDF for each vocabulary term.
                foreach (var term in vocabulary)
                {
                    double numberOfDocsContainingTerm = stemmedDocs.Count(d => d.Contains(term));
                    _vocabularyIdf[term] = Math.Log((double)stemmedDocs.Count / ((double)1 + numberOfDocsContainingTerm));
                }
            }
            Console.WriteLine("_vocabulary filled");

            // Transform each document into a vector of tfidf values.
            return TransformToTfidfVectors(stemmedDocs, _vocabularyIdf, ref reviews);
        }

        private static List<string> TransformToTfidfVectors(IEnumerable<List<string>> stemmedDocs, Dictionary<string, double> vocabularyIDF, ref Reviews reviews)
        {
            Console.Clear();
            Console.WriteLine("TFIDF Vectors");

            var i = 0;
            var words = new List<WordAndScore>();

            // Transform each document into a vector of tfidf values
            foreach (var doc in stemmedDocs)
            {
                var vector = new List<double>();
                
                foreach (var vocab in vocabularyIDF)
                {
                    // Term frequency = count how many times the term appears in this document.
                    var tf = doc.Count(d => d == vocab.Key);
                    var tfidf = tf * vocab.Value;

                    AddOnWordsArray(ref words, vocab.Key, tfidf);
                    
                    vector.Add(tfidf);
                }

                if (i % 100 == 0)
                    Console.WriteLine(i + "/12500");
            
                reviews.Score[i++] = vector.ToArray();
            }
            
            Console.WriteLine("TFIDF finished");

            return words.Select(word => word.Word + " " + word.Score).ToList();
        }

        private static void AddOnWordsArray(ref List<WordAndScore> words, string key, double tfidf)
        {
            var nWord = new WordAndScore(key, tfidf);
            
            if (words.Count < 100)
            {
                words.Add(nWord);
            }
            else
            {
                var w = words[0];
                for (var i = 1; i < 100; i++)
                {
                    if (w.Score < words[i].Score)
                    {
                        w = words[i];
                    }
                }

                if (w.Score < nWord.Score)
                {
                    words.Remove(w);
                    words.Add(nWord);
                }
            }
        }

        public static double[][] Normalize(double[][] vectors)
        {
            // Normalize the vectors using L2-Norm.
            var normalizedVectors = new List<double[]>();
            foreach (var vector in vectors)
            {
                var normalized = Normalize(vector);
                normalizedVectors.Add(normalized);
            }

            return normalizedVectors.ToArray();
        }

        public static double[] Normalize(double[] vector)
        {
            var sumSquared = vector.Sum(value => value*value);

            var sqrtSumSquared = Math.Sqrt(sumSquared);

            return vector.Select(value => value/sqrtSumSquared).ToArray();
        }

        public static void Save(string filePath = "vocabulary.dat")
        {
            // Save result to disk.
            using (var fs = new FileStream(filePath, FileMode.Create))
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(fs, _vocabularyIdf);
            }
        }

        public static void Load(string filePath = "vocabulary.dat")
        {
            // Load from disk.
            using (var fs = new FileStream(filePath, FileMode.Open))
            {
                var formatter = new BinaryFormatter();
                _vocabularyIdf = (Dictionary<string, double>)formatter.Deserialize(fs);
            }
        }

        #region Private Helpers

        private static IEnumerable<string> GetVocabulary(string[] docs, out List<List<string>> stemmedDocs, int vocabularyThreshold,  bool isNeg)
        {
            var vocabulary = new List<string>();
            var wordCountList = new Dictionary<string, int>();
            stemmedDocs = new List<List<string>>();

            var docIndex = 0;

            foreach (var doc in docs)
            {
                var stemmedDoc = new List<string>();

                docIndex++;

                if (docIndex % 100 == 0)
                {
                    Console.WriteLine("Processing " + docIndex + "/" + docs.Length);
                }

                var parts2 = Tokenize(doc);

                var words = new List<string>();
                foreach (var part in parts2)
                {
// Strip non-alphanumeric characters.
                    var stripped = Regex.Replace(part, "[^a-zA-Z0-9]", "");

                    if (!StopWords.StopWordsList(isNeg).Contains(stripped.ToLower()))
                    {
                        try
                        {
                            var english = new EnglishWord(stripped);
                            var stem = english.Stem;
                            words.Add(stem);

                            if (stem.Length > 0)
                            {
                                // Build the word count list.
                                if (wordCountList.ContainsKey(stem))
                                {
                                    wordCountList[stem]++;
                                }
                                else
                                {
                                    wordCountList.Add(stem, 0);
                                }

                                stemmedDoc.Add(stem);
                            }
                        }
                        catch
                        {
                        }
                    }
                }

                stemmedDocs.Add(stemmedDoc);
            }

            // Get the top words.
            var vocabList = wordCountList.Where(w => w.Value >= vocabularyThreshold);
            foreach (var item in vocabList)
            {
                vocabulary.Add(item.Key);
            }

            return vocabulary;
        }

        private static string[] Tokenize(string text)
        {
            // Strip all HTML.
            text = Regex.Replace(text, "<[^<>]+>", "");

            // Strip numbers.
            text = Regex.Replace(text, "[0-9]+", "number");

            // Strip urls.
            text = Regex.Replace(text, @"(http|https)://[^\s]*", "httpaddr");

            // Strip email addresses.
            text = Regex.Replace(text, @"[^\s]+@[^\s]+", "emailaddr");

            // Strip dollar sign.
            text = Regex.Replace(text, "[$]+", "dollar");

            // Strip usernames.
            text = Regex.Replace(text, @"@[^\s]+", "username");

            // Tokenize and also get rid of any punctuation
            return text.Split(" @$/#.-:&*+=[]?!(){},''\">_<;%\\".ToCharArray());
        }

        #endregion
    }
}

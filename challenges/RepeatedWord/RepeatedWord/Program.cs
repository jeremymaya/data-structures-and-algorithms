using RepeatedWord.Classes;
using System;
using System.Text.RegularExpressions;

namespace RepeatedWord
{
    public class Program
    {
        static void Main(string[] args)
        {
            string exampleOne = "Once upon a time, there was a brave princess who...";
            string exampleTwo = "It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way – in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative degree of comparison only...";
            string exampleThree = "It was a queer, sultry summer, the summer they electrocuted the Rosenbergs, and I didn’t know what I was doing in New York...";


            Console.WriteLine(RepeatedWord(exampleOne));
            Console.WriteLine(RepeatedWord(exampleTwo));
            Console.WriteLine(RepeatedWord(exampleThree));
        }

        /// <summary>
        /// This method utilizes a custom hashtable to check for the first word to occur more than once in a phrase
        /// </summary>
        /// <param name="phrase">Lengthy String</param>
        /// <returns>The first word to occur more than once in phrase parameter or "No Repeated Word"</returns>
        public static string RepeatedWord(string phrase)
        {
            string[] words = phrase.Split(' ');

            Hashtable hashtable = new Hashtable();

            for (int i = 0; i < words.Length; i++)
            {
                // Source: https://www.geeksforgeeks.org/removing-punctuations-given-string/
                string word = Regex.Replace(words[i].ToLower(), @"[^\w\d\s]", "");

                if (hashtable.Contains(word))
                {
                    return hashtable.Get(word).Value;
                }

                hashtable.Add(word, word);
            }

            return "No Repeated Word";
        }
    }
}
